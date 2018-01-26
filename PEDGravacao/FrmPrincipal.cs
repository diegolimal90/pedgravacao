using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
