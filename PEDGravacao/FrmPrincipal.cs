using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEDGravacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_frmGrava_Click(object sender, EventArgs e)
        {
            GravarAudio frmGrava = new GravarAudio();
            this.Hide();
            frmGrava.Show();
            
        }

        private void btn_frmAta_Click(object sender, EventArgs e)
        {
            GerarAta frmAta = new GerarAta();
            this.Hide();
            frmAta.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Boolean validaMicrofone = false;
            MMDeviceEnumerator listDevice = new MMDeviceEnumerator();
            var devices = listDevice.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            foreach (MMDevice device in devices)
            {
                if (device.State != DeviceState.NotPresent)
                {
                    validaMicrofone = true;
                }
            }

            if (!validaMicrofone)
            {
                MessageBox.Show("Seu computador não atende as especificações do sistema!\r\n Microfone não localizado!");
                this.Close();
            }
            if (!Directory.Exists(@"C:\PEDGRAVACAO\")){
                Directory.CreateDirectory(@"C:\PEDGRAVACAO\"); 
            }
            if(!Directory.Exists(@"C:\PEDGRAVACAO\Audios")){ 
                Directory.CreateDirectory(@"C:\PEDGRAVACAO\Audios"); 
            }
            if(!Directory.Exists(@"C:\PEDGRAVACAO\Documentos")){ 
                Directory.CreateDirectory(@"C:\PEDGRAVACAO\Documentos"); 
            };
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormCollection listForm = Application.OpenForms;

            foreach (Form frmitem in listForm)
            {
                if (!frmitem.Visible)
                    frmitem.Close();

            }
        }
    }
}
