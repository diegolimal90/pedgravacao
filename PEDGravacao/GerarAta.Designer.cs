namespace PEDGravacao
{
    partial class GerarAta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerarAta));
            this.btnCriaDoc = new System.Windows.Forms.Button();
            this.tituloDoc = new System.Windows.Forms.TextBox();
            this.contAta = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.brnGeraTexto = new System.Windows.Forms.Button();
            this.audioList = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriaDoc
            // 
            this.btnCriaDoc.Location = new System.Drawing.Point(12, 436);
            this.btnCriaDoc.Name = "btnCriaDoc";
            this.btnCriaDoc.Size = new System.Drawing.Size(444, 52);
            this.btnCriaDoc.TabIndex = 0;
            this.btnCriaDoc.Text = "CRIAR DOCUMENTO";
            this.btnCriaDoc.UseVisualStyleBackColor = true;
            this.btnCriaDoc.Click += new System.EventHandler(this.button1_Click);
            // 
            // tituloDoc
            // 
            this.tituloDoc.Location = new System.Drawing.Point(6, 29);
            this.tituloDoc.Name = "tituloDoc";
            this.tituloDoc.Size = new System.Drawing.Size(432, 20);
            this.tituloDoc.TabIndex = 3;
            // 
            // contAta
            // 
            this.contAta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contAta.Cursor = System.Windows.Forms.Cursors.Default;
            this.contAta.EnableAutoDragDrop = true;
            this.contAta.Location = new System.Drawing.Point(6, 31);
            this.contAta.Name = "contAta";
            this.contAta.ReadOnly = true;
            this.contAta.Size = new System.Drawing.Size(432, 199);
            this.contAta.TabIndex = 4;
            this.contAta.Text = "";
            this.contAta.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tituloDoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Titulo da ATA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contAta);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 252);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.brnGeraTexto);
            this.groupBox3.Controls.Add(this.audioList);
            this.groupBox3.Location = new System.Drawing.Point(12, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(444, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selecionar Audio";
            // 
            // brnGeraTexto
            // 
            this.brnGeraTexto.Location = new System.Drawing.Point(6, 48);
            this.brnGeraTexto.Name = "brnGeraTexto";
            this.brnGeraTexto.Size = new System.Drawing.Size(432, 23);
            this.brnGeraTexto.TabIndex = 1;
            this.brnGeraTexto.Text = "GERAR TEXTO";
            this.brnGeraTexto.UseVisualStyleBackColor = true;
            this.brnGeraTexto.Click += new System.EventHandler(this.brnGeraTexto_Click);
            // 
            // audioList
            // 
            this.audioList.FormattingEnabled = true;
            this.audioList.Location = new System.Drawing.Point(6, 21);
            this.audioList.Name = "audioList";
            this.audioList.Size = new System.Drawing.Size(432, 21);
            this.audioList.TabIndex = 0;
            // 
            // GerarAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCriaDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerarAta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerarAta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GerarAta_FormClosed);
            this.Load += new System.EventHandler(this.GerarAta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriaDoc;
        private System.Windows.Forms.TextBox tituloDoc;
        private System.Windows.Forms.RichTextBox contAta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox audioList;
        private System.Windows.Forms.Button brnGeraTexto;
    }
}