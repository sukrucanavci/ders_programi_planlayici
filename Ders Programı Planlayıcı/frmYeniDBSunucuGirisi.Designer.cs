namespace Ders_Programı_Planlayıcı
{
    partial class frmYeniDBSunucuGirisi
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
            this.rdoSqlServerAuto = new System.Windows.Forms.RadioButton();
            this.rdoWinAuto = new System.Windows.Forms.RadioButton();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.txtVeritabaniAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtServerAdresi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUstVT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGunlukDers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdoSqlServerAuto
            // 
            this.rdoSqlServerAuto.AutoSize = true;
            this.rdoSqlServerAuto.Location = new System.Drawing.Point(610, 18);
            this.rdoSqlServerAuto.Name = "rdoSqlServerAuto";
            this.rdoSqlServerAuto.Size = new System.Drawing.Size(197, 21);
            this.rdoSqlServerAuto.TabIndex = 23;
            this.rdoSqlServerAuto.Text = "SQL Server Authentication";
            this.rdoSqlServerAuto.UseVisualStyleBackColor = true;
            this.rdoSqlServerAuto.CheckedChanged += new System.EventHandler(this.rdoSqlServerAuto_CheckedChanged);
            // 
            // rdoWinAuto
            // 
            this.rdoWinAuto.AutoSize = true;
            this.rdoWinAuto.Checked = true;
            this.rdoWinAuto.Location = new System.Drawing.Point(411, 18);
            this.rdoWinAuto.Name = "rdoWinAuto";
            this.rdoWinAuto.Size = new System.Drawing.Size(179, 21);
            this.rdoWinAuto.TabIndex = 22;
            this.rdoWinAuto.TabStop = true;
            this.rdoWinAuto.Text = "Windows Authentication";
            this.rdoWinAuto.UseVisualStyleBackColor = true;
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(411, 167);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(383, 40);
            this.btnBaglan.TabIndex = 7;
            this.btnBaglan.Text = "Sunucuya Bağlan ve Veritabanını Oluştur";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // txtVeritabaniAdi
            // 
            this.txtVeritabaniAdi.Location = new System.Drawing.Point(173, 100);
            this.txtVeritabaniAdi.Name = "txtVeritabaniAdi";
            this.txtVeritabaniAdi.Size = new System.Drawing.Size(184, 22);
            this.txtVeritabaniAdi.TabIndex = 2;
            // 
            // txtSifre
            // 
            this.txtSifre.Enabled = false;
            this.txtSifre.Location = new System.Drawing.Point(569, 100);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(225, 22);
            this.txtSifre.TabIndex = 6;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(569, 57);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(225, 22);
            this.txtKullaniciAdi.TabIndex = 5;
            // 
            // txtServerAdresi
            // 
            this.txtServerAdresi.Location = new System.Drawing.Point(173, 19);
            this.txtServerAdresi.Name = "txtServerAdresi";
            this.txtServerAdresi.Size = new System.Drawing.Size(184, 22);
            this.txtServerAdresi.TabIndex = 0;
            this.txtServerAdresi.Text = ".\\SQLEXPRESS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yeni Veritabanının Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Enabled = false;
            this.lblSifre.Location = new System.Drawing.Point(408, 103);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 17);
            this.lblSifre.TabIndex = 15;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Enabled = false;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(408, 60);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(84, 17);
            this.lblKullaniciAdi.TabIndex = 14;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sunucu Adresi";
            // 
            // txtUstVT
            // 
            this.txtUstVT.Enabled = false;
            this.txtUstVT.Location = new System.Drawing.Point(173, 57);
            this.txtUstVT.Name = "txtUstVT";
            this.txtUstVT.Size = new System.Drawing.Size(184, 22);
            this.txtUstVT.TabIndex = 1;
            this.txtUstVT.Text = "master";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Üst Veritabanı Adı";
            // 
            // txtGun
            // 
            this.txtGun.Enabled = false;
            this.txtGun.Location = new System.Drawing.Point(173, 141);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(184, 22);
            this.txtGun.TabIndex = 3;
            this.txtGun.Text = "5";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 47);
            this.label2.TabIndex = 26;
            this.label2.Text = "Haftalık Ders Günü Sayısı";
            // 
            // txtGunlukDers
            // 
            this.txtGunlukDers.Enabled = false;
            this.txtGunlukDers.Location = new System.Drawing.Point(173, 185);
            this.txtGunlukDers.Name = "txtGunlukDers";
            this.txtGunlukDers.Size = new System.Drawing.Size(184, 22);
            this.txtGunlukDers.TabIndex = 4;
            this.txtGunlukDers.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Günlük Ders Sayısı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(411, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Veritabanı sadece MSSQL desteklemektedir.";
            // 
            // frmYeniDBSunucuGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 230);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGunlukDers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUstVT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoSqlServerAuto);
            this.Controls.Add(this.rdoWinAuto);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.txtVeritabaniAdi);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtServerAdresi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "frmYeniDBSunucuGirisi";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni veritabanınızın sunucu bilgilerini giriniz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoSqlServerAuto;
        private System.Windows.Forms.RadioButton rdoWinAuto;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.TextBox txtVeritabaniAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtServerAdresi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUstVT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGunlukDers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}