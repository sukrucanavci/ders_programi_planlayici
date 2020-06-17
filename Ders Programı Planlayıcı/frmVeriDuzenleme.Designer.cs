namespace Ders_Programı_Planlayıcı
{
    partial class frmVeriDuzenleme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDagilim = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.cmbDagilim = new System.Windows.Forms.ComboBox();
            this.grpRenk = new System.Windows.Forms.GroupBox();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpRenk.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kısa Kodu";
            // 
            // lblDagilim
            // 
            this.lblDagilim.AutoSize = true;
            this.lblDagilim.Location = new System.Drawing.Point(14, 126);
            this.lblDagilim.Name = "lblDagilim";
            this.lblDagilim.Size = new System.Drawing.Size(88, 17);
            this.lblDagilim.TabIndex = 2;
            this.lblDagilim.Text = "Dağılım Şekli";
            this.lblDagilim.Visible = false;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(135, 3);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(141, 36);
            this.btnTamam.TabIndex = 7;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(284, 3);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(141, 36);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // txtAd
            // 
            this.txtAd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAd.Location = new System.Drawing.Point(175, 11);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(250, 22);
            this.txtAd.TabIndex = 0;
            // 
            // txtKod
            // 
            this.txtKod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKod.Location = new System.Drawing.Point(175, 67);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(250, 22);
            this.txtKod.TabIndex = 2;
            // 
            // cmbDagilim
            // 
            this.cmbDagilim.FormattingEnabled = true;
            this.cmbDagilim.Items.AddRange(new object[] {
            "1",
            "2",
            "1+1",
            "3",
            "2+1+1",
            "1+1+1",
            "4",
            "2+2",
            "5",
            "3+2",
            "2+2+1",
            "1+1+1+1+1",
            "6",
            "4+2",
            "2+2+2",
            "7",
            "4+3",
            "8",
            "4+4",
            "2+2+2+2"});
            this.cmbDagilim.Location = new System.Drawing.Point(175, 123);
            this.cmbDagilim.Name = "cmbDagilim";
            this.cmbDagilim.Size = new System.Drawing.Size(250, 24);
            this.cmbDagilim.TabIndex = 3;
            this.cmbDagilim.Visible = false;
            // 
            // grpRenk
            // 
            this.grpRenk.Controls.Add(this.btnRenkDegistir);
            this.grpRenk.Controls.Add(this.lblRenk);
            this.grpRenk.Location = new System.Drawing.Point(12, 175);
            this.grpRenk.Name = "grpRenk";
            this.grpRenk.Size = new System.Drawing.Size(438, 182);
            this.grpRenk.TabIndex = 4;
            this.grpRenk.TabStop = false;
            this.grpRenk.Text = "Renk";
            this.grpRenk.Visible = false;
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(269, 27);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(156, 36);
            this.btnRenkDegistir.TabIndex = 5;
            this.btnRenkDegistir.Text = "Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            this.btnRenkDegistir.Click += new System.EventHandler(this.btnRenkDegistir_Click);
            // 
            // lblRenk
            // 
            this.lblRenk.BackColor = System.Drawing.Color.Blue;
            this.lblRenk.Location = new System.Drawing.Point(14, 27);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(249, 142);
            this.lblRenk.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSoyad.Location = new System.Drawing.Point(175, 39);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(250, 22);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Visible = false;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(14, 42);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(51, 17);
            this.lblSoyad.TabIndex = 10;
            this.lblSoyad.Text = "Soyadı";
            this.lblSoyad.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSoyad);
            this.panel1.Controls.Add(this.lblDagilim);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Controls.Add(this.cmbDagilim);
            this.panel1.Controls.Add(this.txtKod);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 157);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnIptal);
            this.panel2.Controls.Add(this.btnTamam);
            this.panel2.Location = new System.Drawing.Point(12, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 49);
            this.panel2.TabIndex = 6;
            // 
            // frmVeriDuzenleme
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(462, 425);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpRenk);
            this.Name = "frmVeriDuzenleme";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.grpRenk.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDagilim;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.ComboBox cmbDagilim;
        private System.Windows.Forms.GroupBox grpRenk;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}