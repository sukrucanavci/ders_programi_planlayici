namespace Ders_Programı_Planlayıcı
{
    partial class frmParametre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGeriDön = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.tpVeritabani = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoSqlServerAuto = new System.Windows.Forms.RadioButton();
            this.rdoWinAuto = new System.Windows.Forms.RadioButton();
            this.btnBaglanVerileriCek = new System.Windows.Forms.Button();
            this.txtVeritabaniAdi = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtServerAdresi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpParametreler = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkDerslerOgleArasindaBolunebilir = new System.Windows.Forms.CheckBox();
            this.lblKacinciDerstenSonra = new System.Windows.Forms.Label();
            this.btnHaftaninGunleriniGuncelle = new System.Windows.Forms.Button();
            this.chkOgleArasi = new System.Windows.Forms.CheckBox();
            this.cmbOgleArasiZamani = new System.Windows.Forms.ComboBox();
            this.btnDersSaatleriniDuzenle = new System.Windows.Forms.Button();
            this.cmbGunSayisi = new System.Windows.Forms.ComboBox();
            this.cmbGunlukDersSayisi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSihirbaz = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.tpVeritabani.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tpParametreler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabSihirbaz.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnGeriDön);
            this.panel1.Controls.Add(this.btnTamam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 60);
            this.panel1.TabIndex = 1;
            // 
            // btnGeriDön
            // 
            this.btnGeriDön.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGeriDön.Location = new System.Drawing.Point(667, 10);
            this.btnGeriDön.Name = "btnGeriDön";
            this.btnGeriDön.Size = new System.Drawing.Size(147, 38);
            this.btnGeriDön.TabIndex = 4;
            this.btnGeriDön.Text = "Geri Dön";
            this.btnGeriDön.UseVisualStyleBackColor = true;
            this.btnGeriDön.Visible = false;
            this.btnGeriDön.Click += new System.EventHandler(this.btnGeriDön_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.Location = new System.Drawing.Point(820, 10);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(147, 38);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "İlerle";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // tpVeritabani
            // 
            this.tpVeritabani.Controls.Add(this.panel3);
            this.tpVeritabani.Location = new System.Drawing.Point(4, 25);
            this.tpVeritabani.Name = "tpVeritabani";
            this.tpVeritabani.Padding = new System.Windows.Forms.Padding(3);
            this.tpVeritabani.Size = new System.Drawing.Size(971, 563);
            this.tpVeritabani.TabIndex = 2;
            this.tpVeritabani.Text = "Veritabanı";
            this.tpVeritabani.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rdoSqlServerAuto);
            this.panel3.Controls.Add(this.rdoWinAuto);
            this.panel3.Controls.Add(this.btnBaglanVerileriCek);
            this.panel3.Controls.Add(this.txtVeritabaniAdi);
            this.panel3.Controls.Add(this.txtSifre);
            this.panel3.Controls.Add(this.txtKullaniciAdi);
            this.panel3.Controls.Add(this.txtServerAdresi);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lblSifre);
            this.panel3.Controls.Add(this.lblKullaniciAdi);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(957, 179);
            this.panel3.TabIndex = 11;
            // 
            // rdoSqlServerAuto
            // 
            this.rdoSqlServerAuto.AutoSize = true;
            this.rdoSqlServerAuto.Location = new System.Drawing.Point(619, 19);
            this.rdoSqlServerAuto.Name = "rdoSqlServerAuto";
            this.rdoSqlServerAuto.Size = new System.Drawing.Size(197, 21);
            this.rdoSqlServerAuto.TabIndex = 12;
            this.rdoSqlServerAuto.Text = "SQL Server Authentication";
            this.rdoSqlServerAuto.UseVisualStyleBackColor = true;
            this.rdoSqlServerAuto.CheckedChanged += new System.EventHandler(this.rdoSqlServerAuto_CheckedChanged);
            // 
            // rdoWinAuto
            // 
            this.rdoWinAuto.AutoSize = true;
            this.rdoWinAuto.Checked = true;
            this.rdoWinAuto.Location = new System.Drawing.Point(420, 19);
            this.rdoWinAuto.Name = "rdoWinAuto";
            this.rdoWinAuto.Size = new System.Drawing.Size(179, 21);
            this.rdoWinAuto.TabIndex = 11;
            this.rdoWinAuto.TabStop = true;
            this.rdoWinAuto.Text = "Windows Authentication";
            this.rdoWinAuto.UseVisualStyleBackColor = true;
            // 
            // btnBaglanVerileriCek
            // 
            this.btnBaglanVerileriCek.Location = new System.Drawing.Point(182, 101);
            this.btnBaglanVerileriCek.Name = "btnBaglanVerileriCek";
            this.btnBaglanVerileriCek.Size = new System.Drawing.Size(184, 34);
            this.btnBaglanVerileriCek.TabIndex = 10;
            this.btnBaglanVerileriCek.Text = "Bağlan ve Verileri Çek";
            this.btnBaglanVerileriCek.UseVisualStyleBackColor = true;
            this.btnBaglanVerileriCek.Click += new System.EventHandler(this.btnBaglanVerileriCek_Click);
            // 
            // txtVeritabaniAdi
            // 
            this.txtVeritabaniAdi.Location = new System.Drawing.Point(182, 59);
            this.txtVeritabaniAdi.Name = "txtVeritabaniAdi";
            this.txtVeritabaniAdi.Size = new System.Drawing.Size(184, 22);
            this.txtVeritabaniAdi.TabIndex = 9;
            // 
            // txtSifre
            // 
            this.txtSifre.Enabled = false;
            this.txtSifre.Location = new System.Drawing.Point(578, 101);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(184, 22);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.Text = "12345678";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Enabled = false;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(578, 58);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(184, 22);
            this.txtKullaniciAdi.TabIndex = 7;
            this.txtKullaniciAdi.Text = "sa";
            // 
            // txtServerAdresi
            // 
            this.txtServerAdresi.Location = new System.Drawing.Point(182, 20);
            this.txtServerAdresi.Name = "txtServerAdresi";
            this.txtServerAdresi.Size = new System.Drawing.Size(184, 22);
            this.txtServerAdresi.TabIndex = 6;
            this.txtServerAdresi.Text = "localhost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Veritabanı Adı";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Enabled = false;
            this.lblSifre.Location = new System.Drawing.Point(417, 104);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(37, 17);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Enabled = false;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(417, 61);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(84, 17);
            this.lblKullaniciAdi.TabIndex = 3;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sunucu Adresi";
            // 
            // tpParametreler
            // 
            this.tpParametreler.Controls.Add(this.panel2);
            this.tpParametreler.Location = new System.Drawing.Point(4, 25);
            this.tpParametreler.Name = "tpParametreler";
            this.tpParametreler.Padding = new System.Windows.Forms.Padding(3);
            this.tpParametreler.Size = new System.Drawing.Size(971, 563);
            this.tpParametreler.TabIndex = 0;
            this.tpParametreler.Text = "Parametreler";
            this.tpParametreler.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chkDerslerOgleArasindaBolunebilir);
            this.panel2.Controls.Add(this.lblKacinciDerstenSonra);
            this.panel2.Controls.Add(this.btnHaftaninGunleriniGuncelle);
            this.panel2.Controls.Add(this.chkOgleArasi);
            this.panel2.Controls.Add(this.cmbOgleArasiZamani);
            this.panel2.Controls.Add(this.btnDersSaatleriniDuzenle);
            this.panel2.Controls.Add(this.cmbGunSayisi);
            this.panel2.Controls.Add(this.cmbGunlukDersSayisi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 172);
            this.panel2.TabIndex = 0;
            // 
            // chkDerslerOgleArasindaBolunebilir
            // 
            this.chkDerslerOgleArasindaBolunebilir.AutoSize = true;
            this.chkDerslerOgleArasindaBolunebilir.Location = new System.Drawing.Point(568, 123);
            this.chkDerslerOgleArasindaBolunebilir.Name = "chkDerslerOgleArasindaBolunebilir";
            this.chkDerslerOgleArasindaBolunebilir.Size = new System.Drawing.Size(281, 21);
            this.chkDerslerOgleArasindaBolunebilir.TabIndex = 9;
            this.chkDerslerOgleArasindaBolunebilir.Text = "Dersler öğle arası zamanında bölünebiir";
            this.chkDerslerOgleArasindaBolunebilir.UseVisualStyleBackColor = true;
            this.chkDerslerOgleArasindaBolunebilir.Visible = false;
            this.chkDerslerOgleArasindaBolunebilir.CheckedChanged += new System.EventHandler(this.chkDerslerOgleArasindaBolunebilir_CheckedChanged);
            // 
            // lblKacinciDerstenSonra
            // 
            this.lblKacinciDerstenSonra.AutoSize = true;
            this.lblKacinciDerstenSonra.Location = new System.Drawing.Point(287, 124);
            this.lblKacinciDerstenSonra.Name = "lblKacinciDerstenSonra";
            this.lblKacinciDerstenSonra.Size = new System.Drawing.Size(262, 17);
            this.lblKacinciDerstenSonra.TabIndex = 8;
            this.lblKacinciDerstenSonra.Text = ". dersten sonra öğle arası oluşturulacak.";
            this.lblKacinciDerstenSonra.Visible = false;
            // 
            // btnHaftaninGunleriniGuncelle
            // 
            this.btnHaftaninGunleriniGuncelle.Location = new System.Drawing.Point(420, 70);
            this.btnHaftaninGunleriniGuncelle.Name = "btnHaftaninGunleriniGuncelle";
            this.btnHaftaninGunleriniGuncelle.Size = new System.Drawing.Size(238, 34);
            this.btnHaftaninGunleriniGuncelle.TabIndex = 7;
            this.btnHaftaninGunleriniGuncelle.Text = "Haftanın Günlerini Güncelle";
            this.btnHaftaninGunleriniGuncelle.UseVisualStyleBackColor = true;
            this.btnHaftaninGunleriniGuncelle.Click += new System.EventHandler(this.btnHaftaninGunleriniGuncelle_Click);
            // 
            // chkOgleArasi
            // 
            this.chkOgleArasi.AutoSize = true;
            this.chkOgleArasi.Location = new System.Drawing.Point(43, 120);
            this.chkOgleArasi.Name = "chkOgleArasi";
            this.chkOgleArasi.Size = new System.Drawing.Size(96, 21);
            this.chkOgleArasi.TabIndex = 5;
            this.chkOgleArasi.Text = "Öğle Arası";
            this.chkOgleArasi.UseVisualStyleBackColor = true;
            this.chkOgleArasi.CheckedChanged += new System.EventHandler(this.chkOgleArasi_CheckedChanged);
            // 
            // cmbOgleArasiZamani
            // 
            this.cmbOgleArasiZamani.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOgleArasiZamani.FormattingEnabled = true;
            this.cmbOgleArasiZamani.Location = new System.Drawing.Point(223, 118);
            this.cmbOgleArasiZamani.Name = "cmbOgleArasiZamani";
            this.cmbOgleArasiZamani.Size = new System.Drawing.Size(58, 24);
            this.cmbOgleArasiZamani.TabIndex = 6;
            this.cmbOgleArasiZamani.Visible = false;
            this.cmbOgleArasiZamani.SelectedIndexChanged += new System.EventHandler(this.cmbOgleArasiZamani_SelectedIndexChanged);
            // 
            // btnDersSaatleriniDuzenle
            // 
            this.btnDersSaatleriniDuzenle.Location = new System.Drawing.Point(420, 25);
            this.btnDersSaatleriniDuzenle.Name = "btnDersSaatleriniDuzenle";
            this.btnDersSaatleriniDuzenle.Size = new System.Drawing.Size(238, 34);
            this.btnDersSaatleriniDuzenle.TabIndex = 4;
            this.btnDersSaatleriniDuzenle.Text = "Ders Saatlerini Düzenle";
            this.btnDersSaatleriniDuzenle.UseVisualStyleBackColor = true;
            this.btnDersSaatleriniDuzenle.Click += new System.EventHandler(this.btnDersSaatleriniDuzenle_Click);
            // 
            // cmbGunSayisi
            // 
            this.cmbGunSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGunSayisi.FormattingEnabled = true;
            this.cmbGunSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbGunSayisi.Location = new System.Drawing.Point(223, 70);
            this.cmbGunSayisi.Name = "cmbGunSayisi";
            this.cmbGunSayisi.Size = new System.Drawing.Size(58, 24);
            this.cmbGunSayisi.TabIndex = 3;
            this.cmbGunSayisi.SelectedIndexChanged += new System.EventHandler(this.cmbGunSayisi_SelectedIndexChanged);
            // 
            // cmbGunlukDersSayisi
            // 
            this.cmbGunlukDersSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGunlukDersSayisi.FormattingEnabled = true;
            this.cmbGunlukDersSayisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbGunlukDersSayisi.Location = new System.Drawing.Point(223, 25);
            this.cmbGunlukDersSayisi.Name = "cmbGunlukDersSayisi";
            this.cmbGunlukDersSayisi.Size = new System.Drawing.Size(58, 24);
            this.cmbGunlukDersSayisi.TabIndex = 2;
            this.cmbGunlukDersSayisi.SelectedIndexChanged += new System.EventHandler(this.cmbGunlukDersSayisi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gün Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günlük Ders Sayısı\r\n";
            // 
            // tabSihirbaz
            // 
            this.tabSihirbaz.Controls.Add(this.tpVeritabani);
            this.tabSihirbaz.Controls.Add(this.tpParametreler);
            this.tabSihirbaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSihirbaz.Location = new System.Drawing.Point(0, 0);
            this.tabSihirbaz.Name = "tabSihirbaz";
            this.tabSihirbaz.SelectedIndex = 0;
            this.tabSihirbaz.Size = new System.Drawing.Size(979, 592);
            this.tabSihirbaz.TabIndex = 3;
            // 
            // frmParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 652);
            this.ControlBox = false;
            this.Controls.Add(this.tabSihirbaz);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "frmParametre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurulum Sihirbazı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmParametre_FormClosing);
            this.Load += new System.EventHandler(this.frmParametre_Load);
            this.panel1.ResumeLayout(false);
            this.tpVeritabani.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tpParametreler.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabSihirbaz.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.TabPage tpVeritabani;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBaglanVerileriCek;
        private System.Windows.Forms.TextBox txtVeritabaniAdi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtServerAdresi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpParametreler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkDerslerOgleArasindaBolunebilir;
        private System.Windows.Forms.Label lblKacinciDerstenSonra;
        private System.Windows.Forms.Button btnHaftaninGunleriniGuncelle;
        private System.Windows.Forms.CheckBox chkOgleArasi;
        private System.Windows.Forms.ComboBox cmbOgleArasiZamani;
        private System.Windows.Forms.Button btnDersSaatleriniDuzenle;
        private System.Windows.Forms.ComboBox cmbGunSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabSihirbaz;
        private System.Windows.Forms.Button btnGeriDön;
        public System.Windows.Forms.ComboBox cmbGunlukDersSayisi;
        public System.Windows.Forms.RadioButton rdoSqlServerAuto;
        public System.Windows.Forms.RadioButton rdoWinAuto;
    }
}