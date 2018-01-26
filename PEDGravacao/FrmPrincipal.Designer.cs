namespace PEDGravacao
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_frmAta = new System.Windows.Forms.PictureBox();
            this.btn_frmGrava = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_frmAta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_frmGrava)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "ABRIR GRAVADOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "GERAR DE ATA";
            // 
            // logo
            // 
            this.logo.Image = global::PEDGravacao.Properties.Resources.PED_logo;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(664, 121);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            // 
            // btn_frmAta
            // 
            this.btn_frmAta.Image = global::PEDGravacao.Properties.Resources.PED_ic_txt;
            this.btn_frmAta.Location = new System.Drawing.Point(425, 218);
            this.btn_frmAta.Name = "btn_frmAta";
            this.btn_frmAta.Size = new System.Drawing.Size(199, 199);
            this.btn_frmAta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_frmAta.TabIndex = 1;
            this.btn_frmAta.TabStop = false;
            this.btn_frmAta.Click += new System.EventHandler(this.btn_frmAta_Click);
            // 
            // btn_frmGrava
            // 
            this.btn_frmGrava.Image = global::PEDGravacao.Properties.Resources.PED_ic_rec;
            this.btn_frmGrava.InitialImage = null;
            this.btn_frmGrava.Location = new System.Drawing.Point(57, 218);
            this.btn_frmGrava.Name = "btn_frmGrava";
            this.btn_frmGrava.Size = new System.Drawing.Size(199, 199);
            this.btn_frmGrava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_frmGrava.TabIndex = 0;
            this.btn_frmGrava.TabStop = false;
            this.btn_frmGrava.Click += new System.EventHandler(this.btn_frmGrava_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(688, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btn_frmAta);
            this.Controls.Add(this.btn_frmGrava);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PED Gravação";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_frmAta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_frmGrava)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_frmGrava;
        private System.Windows.Forms.PictureBox btn_frmAta;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

