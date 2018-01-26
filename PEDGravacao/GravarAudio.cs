using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEDGravacao
{
    public partial class GravarAudio : Form
    {
        public GravarAudio()
        {
            InitializeComponent();

            
        }

        NAudio.Wave.WaveIn sourceStream = null;
        NAudio.Wave.DirectSoundOut waveOut = null;
        NAudio.Wave.WaveFileWriter waveWriter = null;
        private int gravado;

        private void GravarAudio_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FrmPrincipal frmPrincipal = new FrmPrincipal();
            btnParar_Click(sender, e);
            FormCollection listForm = Application.OpenForms;

            foreach (Form frmitem in listForm)
            {
                if (!frmitem.Visible)
                    frmitem.Visible = true;

            }
            //frmPrincipal.Show();
        }

        private void GravarAudio_Load(object sender, EventArgs e)
        {
            MMDeviceEnumerator listDevice = new MMDeviceEnumerator();
            var devices = listDevice.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            micList.Items.AddRange(devices.ToArray());
            gravado = 0;

            btnParar.Enabled = false;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string pasta = @"C:\PEDGRAVACAO\Audios", 
                nmAudio;

            int dia = DateTime.Now.Day, 
                mes = DateTime.Now.Month, 
                ano = DateTime.Now.Year;

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(micList.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecionar o Microfone a ser usado!");
            }
            else
            {
                
                nmAudio = ano.ToString()+"_" + mes.ToString()+"_" + dia.ToString() + ".wav";
                String nvCaminho = Path.Combine(pasta, nmAudio);
                


                var deviceNumber = micList.SelectedIndex;
                
                sourceStream = new NAudio.Wave.WaveIn();
                sourceStream.DeviceNumber = deviceNumber;
                sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(16000, 1);

                sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
                waveWriter = new NAudio.Wave.WaveFileWriter(nvCaminho, sourceStream.WaveFormat);

                sourceStream.StartRecording();

                btnParar.Enabled = true;
                btnIniciar.Enabled = false;
                
            }

            

        }

        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();

            int timer = (int)(waveWriter.Length / waveWriter.WaveFormat.AverageBytesPerSecond);
            int hora = 0;
            int minu = 0;
            int seg = 0;
            string tSeg = null, tMin = null, tHora = null ;
            
            if(timer >= 60)
            {
                minu = (int)(timer / 60);
                if( minu >= 60)
                {
                    hora = (int)(minu / 60);
                    minu = minu % 60;

                }
                seg = timer % 60;

                tHora = hora < 10 ? "0" + hora.ToString() : tHora = hora.ToString();
                tMin = minu < 10 ? "0" + minu.ToString() : tMin = minu.ToString();
                tSeg = seg < 10 ? "0" + seg.ToString() : tSeg = seg.ToString();

                timerHora.Text = tHora;
                timerMinuto.Text = tMin;
                timerSec.Text = tSeg;
            }
            else
            {
                if(timer < 10)
                {
                    tSeg = "0" + timer.ToString();
                }
                else
                {
                    tSeg = timer.ToString();
                }
                timerSec.Text = tSeg;
            }

            var device = (MMDevice)micList.SelectedItem;
            WaveAudioLevel.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }
            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }

            btnIniciar.Enabled = true;
            btnParar.Enabled = false;
            WaveAudioLevel.Value = 0;
        }

        private void countAudioLevel_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
