namespace PEDGravacao
{
    partial class GravarAudio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GravarAudio));
            this.countAudioLevel = new System.Windows.Forms.Timer(this.components);
            this.micList = new System.Windows.Forms.ComboBox();
            this.WaveAudioLevel = new System.Windows.Forms.ProgressBar();
            this.timerHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerMinuto = new System.Windows.Forms.Label();
            this.timerSec = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.selectMic = new System.Windows.Forms.GroupBox();
            this.gpControle = new System.Windows.Forms.GroupBox();
            this.gpProcess = new System.Windows.Forms.GroupBox();
            this.selectMic.SuspendLayout();
            this.gpControle.SuspendLayout();
            this.gpProcess.SuspendLayout();
            this.SuspendLayout();
            // 
            // countAudioLevel
            // 
            this.countAudioLevel.Tick += new System.EventHandler(this.countAudioLevel_Tick);
            // 
            // micList
            // 
            this.micList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.micList.FormattingEnabled = true;
            this.micList.Location = new System.Drawing.Point(14, 40);
            this.micList.Name = "micList";
            this.micList.Size = new System.Drawing.Size(385, 21);
            this.micList.TabIndex = 1;
            // 
            // WaveAudioLevel
            // 
            this.WaveAudioLevel.Location = new System.Drawing.Point(14, 19);
            this.WaveAudioLevel.Name = "WaveAudioLevel";
            this.WaveAudioLevel.Size = new System.Drawing.Size(385, 42);
            this.WaveAudioLevel.TabIndex = 16;
            // 
            // timerHora
            // 
            this.timerHora.AutoSize = true;
            this.timerHora.BackColor = System.Drawing.Color.Transparent;
            this.timerHora.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerHora.Location = new System.Drawing.Point(111, 84);
            this.timerHora.Name = "timerHora";
            this.timerHora.Size = new System.Drawing.Size(41, 30);
            this.timerHora.TabIndex = 13;
            this.timerHora.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = ":";
            // 
            // timerMinuto
            // 
            this.timerMinuto.AutoSize = true;
            this.timerMinuto.BackColor = System.Drawing.Color.Transparent;
            this.timerMinuto.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerMinuto.Location = new System.Drawing.Point(184, 84);
            this.timerMinuto.Name = "timerMinuto";
            this.timerMinuto.Size = new System.Drawing.Size(41, 30);
            this.timerMinuto.TabIndex = 12;
            this.timerMinuto.Text = "00";
            // 
            // timerSec
            // 
            this.timerSec.AutoSize = true;
            this.timerSec.BackColor = System.Drawing.Color.Transparent;
            this.timerSec.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerSec.Location = new System.Drawing.Point(257, 84);
            this.timerSec.Name = "timerSec";
            this.timerSec.Size = new System.Drawing.Size(41, 30);
            this.timerSec.TabIndex = 11;
            this.timerSec.Text = "00";
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(209, 38);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(191, 29);
            this.btnParar.TabIndex = 3;
            this.btnParar.Text = "Parar Gravação";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIniciar.Location = new System.Drawing.Point(14, 38);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(189, 29);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Gravação";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // selectMic
            // 
            this.selectMic.Controls.Add(this.micList);
            this.selectMic.Location = new System.Drawing.Point(12, 12);
            this.selectMic.Name = "selectMic";
            this.selectMic.Size = new System.Drawing.Size(416, 100);
            this.selectMic.TabIndex = 17;
            this.selectMic.TabStop = false;
            this.selectMic.Text = "Selecionar Microfone";
            // 
            // gpControle
            // 
            this.gpControle.Controls.Add(this.btnIniciar);
            this.gpControle.Controls.Add(this.btnParar);
            this.gpControle.Location = new System.Drawing.Point(12, 125);
            this.gpControle.Name = "gpControle";
            this.gpControle.Size = new System.Drawing.Size(416, 100);
            this.gpControle.TabIndex = 18;
            this.gpControle.TabStop = false;
            this.gpControle.Text = "Controles de gravação";
            // 
            // gpProcess
            // 
            this.gpProcess.Controls.Add(this.WaveAudioLevel);
            this.gpProcess.Controls.Add(this.timerSec);
            this.gpProcess.Controls.Add(this.timerMinuto);
            this.gpProcess.Controls.Add(this.label3);
            this.gpProcess.Controls.Add(this.timerHora);
            this.gpProcess.Controls.Add(this.label4);
            this.gpProcess.Location = new System.Drawing.Point(12, 244);
            this.gpProcess.Name = "gpProcess";
            this.gpProcess.Size = new System.Drawing.Size(416, 122);
            this.gpProcess.TabIndex = 0;
            this.gpProcess.TabStop = false;
            this.gpProcess.Text = "Processamento da Gravação";
            // 
            // GravarAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 383);
            this.Controls.Add(this.gpProcess);
            this.Controls.Add(this.gpControle);
            this.Controls.Add(this.selectMic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GravarAudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GravarAudio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GravarAudio_FormClosed);
            this.Load += new System.EventHandler(this.GravarAudio_Load);
            this.selectMic.ResumeLayout(false);
            this.gpControle.ResumeLayout(false);
            this.gpProcess.ResumeLayout(false);
            this.gpProcess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer countAudioLevel;
        private System.Windows.Forms.ComboBox micList;
        private System.Windows.Forms.ProgressBar WaveAudioLevel;
        private System.Windows.Forms.Label timerHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerMinuto;
        private System.Windows.Forms.Label timerSec;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.GroupBox selectMic;
        private System.Windows.Forms.GroupBox gpControle;
        private System.Windows.Forms.GroupBox gpProcess;
    }
}