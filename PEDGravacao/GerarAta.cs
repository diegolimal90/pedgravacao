using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Google.Cloud.Speech.V1;
using System.Threading;

namespace PEDGravacao
{
    public partial class GerarAta : Form
    {

        public GerarAta()
        {
            InitializeComponent();
        }

        private void GerarAta_Load(object sender, EventArgs e)
        {
            listar();
            contAta.Text = "Selecione o arquivo e Clique em Gerar Texto";
            btnCriaDoc.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String conteudo, titulo;
            conteudo = contAta.Text;
            titulo = tituloDoc.Text;
            if( tituloDoc.Text != "" && contAta.Text != "")
            {

                object oMissing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

                //Start Word and create a new document.
                Word._Application oWord;
                Word._Document oDoc;
                oWord = new Word.Application();
                oWord.Visible = true;
                oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);

                //Insert a paragraph at the beginning of the document.
                Word.Paragraph oPara1;
                oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara1.Range.Text = titulo;
                oPara1.Range.Font.Bold = 1;
                oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
                oPara1.Range.InsertParagraphAfter();

                //Insert a paragraph at the end of the document.
                object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                
                //Insert another paragraph.
                Word.Paragraph oPara3;
                oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara3 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara3.Range.Text = conteudo;
                oPara3.Range.Font.Bold = 0;
                oPara3.Format.SpaceAfter = 24;
                oPara3.Range.InsertParagraphAfter();

                oWord.Application.ActiveDocument.SaveAs2(@"C:\PEDGRAVACAO\Documentos\" + titulo + ".docx");
                //Close this form.
                //this.Close();

            }
            else
            {
                MessageBox.Show("Por favor, Coloque um titulo e gere o texto para o documento!");
            }
            
        }

        private void GerarAta_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FrmPrincipal frmPrincipal = new FrmPrincipal();
            
            FormCollection listForm = Application.OpenForms;

            foreach (Form frmitem in listForm)
            {
                if (!frmitem.Visible)
                    frmitem.Visible = true;

            }
            //frmPrincipal.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listar()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\PEDGRAVACAO\Audios");

            FileInfo[] file = dir.GetFiles();
            foreach(FileInfo File in file)
            {
                audioList.Items.Add(File.FullName);
            }
        }

        private void brnGeraTexto_Click(object sender, EventArgs e)
        {
            if(audioList.SelectedItem != null)
            {
                var audio = audioList.SelectedItem;
                audio = Path.GetFileName(audio.ToString());

                var txt = StreamingRecognizeAsync(@"C:\PEDGRAVACAO\Audios\" + audio.ToString());
                contAta.Text = "Gerando texto aguarde!";
            }
            else
            {
                MessageBox.Show("Favor selecionar um audio da lista!");
            }
            
        }

        async Task<string> StreamingRecognizeAsync(string filePath)
        {
            
            var speech = SpeechClient.Create();
            var streamingCall = speech.StreamingRecognize();
            String texto, ultimoTexto = "", txt;
            txt = null;
            // Write the initial request with the config.
            await streamingCall.WriteAsync(
                new StreamingRecognizeRequest()
                {
                    StreamingConfig = new StreamingRecognitionConfig()
                    {
                        Config = new RecognitionConfig()
                        {
                            Encoding =
                            RecognitionConfig.Types.AudioEncoding.Linear16,
                            SampleRateHertz = 16000,
                            LanguageCode = "pt-br",
                        },
                        InterimResults = true,
                    }
                });
            // Print responses as they arrive.
            Task printResponses = Task.Run(async () =>
            {
                while (await streamingCall.ResponseStream.MoveNext(
                    default(CancellationToken)))
                {
                    foreach (var result in streamingCall.ResponseStream
                        .Current.Results)
                    {
                        foreach (var alternative in result.Alternatives)
                        {
                            texto = alternative.Transcript;
                            if (ultimoTexto != texto)
                            {
                                ultimoTexto = texto;
                                txt = txt + ultimoTexto + " ";
                                Console.WriteLine(texto);
                                
                            }
                        }
                    }
                }
                contAta.Invoke((MethodInvoker)delegate { contAta.Clear(); });
                //Need to call this on UI thread ....
                contAta.Invoke((MethodInvoker)delegate { contAta.AppendText(txt); });
                btnCriaDoc.Invoke((MethodInvoker)delegate { btnCriaDoc.Enabled = true; });
                brnGeraTexto.Invoke((MethodInvoker)delegate { brnGeraTexto.Enabled = false; });
            });
            // Stream the file content to the API.  Write 2 32kb chunks per
            // second.
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                var buffer = new byte[32 * 1024];
                int bytesRead;
                while ((bytesRead = await fileStream.ReadAsync(
                    buffer, 0, buffer.Length)) > 0)
                {
                    await streamingCall.WriteAsync(
                        new StreamingRecognizeRequest()
                        {
                            AudioContent = Google.Protobuf.ByteString
                            .CopyFrom(buffer, 0, bytesRead),
                        });
                    await Task.Delay(500);
                };
            }
            await streamingCall.WriteCompleteAsync();
            //return printResponses;
            return txt;

            
        }

    }
}
