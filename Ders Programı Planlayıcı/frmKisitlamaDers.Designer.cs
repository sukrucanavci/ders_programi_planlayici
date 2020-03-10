namespace Ders_Programı_Planlayıcı
{
    partial class frmKisitlamaDers
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
            this.trbDagilimKisitlamasi = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKisitlama = new System.Windows.Forms.Label();
            this.btnTumuneUygula = new System.Windows.Forms.Button();
            this.chkSanalDers = new System.Windows.Forms.CheckBox();
            this.btnTamam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbDagilimKisitlamasi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trbDagilimKisitlamasi
            // 
            this.trbDagilimKisitlamasi.Location = new System.Drawing.Point(15, 40);
            this.trbDagilimKisitlamasi.Maximum = 3;
            this.trbDagilimKisitlamasi.Name = "trbDagilimKisitlamasi";
            this.trbDagilimKisitlamasi.Size = new System.Drawing.Size(489, 56);
            this.trbDagilimKisitlamasi.TabIndex = 0;
            this.trbDagilimKisitlamasi.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trbDagilimKisitlamasi.Value = 1;
            this.trbDagilimKisitlamasi.Scroll += new System.EventHandler(this.trbDagilimKisitlamasi_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKisitlama);
            this.groupBox1.Controls.Add(this.btnTumuneUygula);
            this.groupBox1.Controls.Add(this.trbDagilimKisitlamasi);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Bloklarının Günlere Dağılımı";
            // 
            // lblKisitlama
            // 
            this.lblKisitlama.AutoSize = true;
            this.lblKisitlama.Location = new System.Drawing.Point(12, 99);
            this.lblKisitlama.Name = "lblKisitlama";
            this.lblKisitlama.Size = new System.Drawing.Size(78, 17);
            this.lblKisitlama.TabIndex = 2;
            this.lblKisitlama.Text = "lblKisitlama";
            // 
            // btnTumuneUygula
            // 
            this.btnTumuneUygula.Location = new System.Drawing.Point(325, 99);
            this.btnTumuneUygula.Name = "btnTumuneUygula";
            this.btnTumuneUygula.Size = new System.Drawing.Size(179, 38);
            this.btnTumuneUygula.TabIndex = 1;
            this.btnTumuneUygula.Text = "Tüm Derslere Uygula";
            this.btnTumuneUygula.UseVisualStyleBackColor = true;
            this.btnTumuneUygula.Click += new System.EventHandler(this.btnTumuneUygula_Click);
            // 
            // chkSanalDers
            // 
            this.chkSanalDers.AutoSize = true;
            this.chkSanalDers.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.chkSanalDers.Location = new System.Drawing.Point(12, 169);
            this.chkSanalDers.Name = "chkSanalDers";
            this.chkSanalDers.Size = new System.Drawing.Size(100, 21);
            this.chkSanalDers.TabIndex = 2;
            this.chkSanalDers.Text = "Sanal Ders";
            this.chkSanalDers.UseVisualStyleBackColor = true;
            this.chkSanalDers.CheckedChanged += new System.EventHandler(this.chkSanalDers_CheckedChanged);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(338, 196);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(179, 40);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // frmKisitlamaDers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 249);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.chkSanalDers);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKisitlamaDers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kısıtlama - ";
            ((System.ComponentModel.ISupportInitialize)(this.trbDagilimKisitlamasi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbDagilimKisitlamasi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTumuneUygula;
        private System.Windows.Forms.CheckBox chkSanalDers;
        private System.Windows.Forms.Label lblKisitlama;
        private System.Windows.Forms.Button btnTamam;
    }
}