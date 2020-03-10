namespace Ders_Programı_Planlayıcı
{
    partial class frmVeriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeriler));
            this.pnlSag = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKısıtlamalar = new System.Windows.Forms.Button();
            this.btnZamanTablosu = new System.Windows.Forms.Button();
            this.btnDersAtamasi = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.btnOgretmenler = new System.Windows.Forms.Button();
            this.btnDerslikler = new System.Windows.Forms.Button();
            this.btnSiniflar = new System.Windows.Forms.Button();
            this.btnDersler = new System.Windows.Forms.Button();
            this.pnlOrta = new System.Windows.Forms.Panel();
            this.lvwOgretmenler = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.img16pxIcons = new System.Windows.Forms.ImageList(this.components);
            this.lvwDerslikler = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwSiniflar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwDersler = new System.Windows.Forms.ListView();
            this.clmnAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnKod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnTS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnDagilim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListeAdi = new System.Windows.Forms.Label();
            this.pnlSag.SuspendLayout();
            this.pnlSol.SuspendLayout();
            this.pnlOrta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSag
            // 
            this.pnlSag.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlSag.Controls.Add(this.btnKapat);
            this.pnlSag.Controls.Add(this.btnKısıtlamalar);
            this.pnlSag.Controls.Add(this.btnZamanTablosu);
            this.pnlSag.Controls.Add(this.btnDersAtamasi);
            this.pnlSag.Controls.Add(this.btnSil);
            this.pnlSag.Controls.Add(this.btnGuncelle);
            this.pnlSag.Controls.Add(this.btnYeni);
            this.pnlSag.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSag.Location = new System.Drawing.Point(840, 0);
            this.pnlSag.Name = "pnlSag";
            this.pnlSag.Size = new System.Drawing.Size(210, 578);
            this.pnlSag.TabIndex = 9;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(9, 523);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(192, 43);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKısıtlamalar
            // 
            this.btnKısıtlamalar.BackColor = System.Drawing.Color.White;
            this.btnKısıtlamalar.Location = new System.Drawing.Point(9, 323);
            this.btnKısıtlamalar.Name = "btnKısıtlamalar";
            this.btnKısıtlamalar.Size = new System.Drawing.Size(192, 43);
            this.btnKısıtlamalar.TabIndex = 6;
            this.btnKısıtlamalar.Text = "Kısıtlamalar";
            this.btnKısıtlamalar.UseVisualStyleBackColor = false;
            this.btnKısıtlamalar.Click += new System.EventHandler(this.btnKısıtlamalar_Click);
            // 
            // btnZamanTablosu
            // 
            this.btnZamanTablosu.BackColor = System.Drawing.Color.White;
            this.btnZamanTablosu.Location = new System.Drawing.Point(9, 274);
            this.btnZamanTablosu.Name = "btnZamanTablosu";
            this.btnZamanTablosu.Size = new System.Drawing.Size(192, 43);
            this.btnZamanTablosu.TabIndex = 5;
            this.btnZamanTablosu.Text = "Zaman Tablosu";
            this.btnZamanTablosu.UseVisualStyleBackColor = false;
            this.btnZamanTablosu.Click += new System.EventHandler(this.btnZamanTablosu_Click);
            // 
            // btnDersAtamasi
            // 
            this.btnDersAtamasi.BackColor = System.Drawing.Color.White;
            this.btnDersAtamasi.Location = new System.Drawing.Point(9, 225);
            this.btnDersAtamasi.Name = "btnDersAtamasi";
            this.btnDersAtamasi.Size = new System.Drawing.Size(192, 43);
            this.btnDersAtamasi.TabIndex = 4;
            this.btnDersAtamasi.Text = "Ders Atama";
            this.btnDersAtamasi.UseVisualStyleBackColor = false;
            this.btnDersAtamasi.Click += new System.EventHandler(this.btnDersAtamasi_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(6, 121);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(192, 43);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(6, 72);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(192, 43);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.White;
            this.btnYeni.Location = new System.Drawing.Point(6, 23);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(192, 43);
            this.btnYeni.TabIndex = 1;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlSol.Controls.Add(this.btnOgretmenler);
            this.pnlSol.Controls.Add(this.btnDerslikler);
            this.pnlSol.Controls.Add(this.btnSiniflar);
            this.pnlSol.Controls.Add(this.btnDersler);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(210, 578);
            this.pnlSol.TabIndex = 8;
            // 
            // btnOgretmenler
            // 
            this.btnOgretmenler.BackColor = System.Drawing.Color.White;
            this.btnOgretmenler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOgretmenler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgretmenler.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.ogretmen64px;
            this.btnOgretmenler.Location = new System.Drawing.Point(12, 368);
            this.btnOgretmenler.Name = "btnOgretmenler";
            this.btnOgretmenler.Size = new System.Drawing.Size(184, 107);
            this.btnOgretmenler.TabIndex = 3;
            this.btnOgretmenler.Text = "Öğretmenler";
            this.btnOgretmenler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOgretmenler.UseVisualStyleBackColor = false;
            this.btnOgretmenler.Click += new System.EventHandler(this.btnOgretmenler_Click);
            // 
            // btnDerslikler
            // 
            this.btnDerslikler.BackColor = System.Drawing.Color.White;
            this.btnDerslikler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDerslikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDerslikler.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.derslik64px;
            this.btnDerslikler.Location = new System.Drawing.Point(12, 255);
            this.btnDerslikler.Name = "btnDerslikler";
            this.btnDerslikler.Size = new System.Drawing.Size(184, 107);
            this.btnDerslikler.TabIndex = 2;
            this.btnDerslikler.Text = "Derslikler";
            this.btnDerslikler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDerslikler.UseVisualStyleBackColor = false;
            this.btnDerslikler.Click += new System.EventHandler(this.btnDerslikler_Click);
            // 
            // btnSiniflar
            // 
            this.btnSiniflar.BackColor = System.Drawing.Color.White;
            this.btnSiniflar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiniflar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiniflar.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.sinif64px;
            this.btnSiniflar.Location = new System.Drawing.Point(12, 142);
            this.btnSiniflar.Name = "btnSiniflar";
            this.btnSiniflar.Size = new System.Drawing.Size(184, 107);
            this.btnSiniflar.TabIndex = 1;
            this.btnSiniflar.Text = "Sınıflar";
            this.btnSiniflar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSiniflar.UseVisualStyleBackColor = false;
            this.btnSiniflar.Click += new System.EventHandler(this.btnSiniflar_Click);
            // 
            // btnDersler
            // 
            this.btnDersler.BackColor = System.Drawing.Color.White;
            this.btnDersler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDersler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersler.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.ders64px;
            this.btnDersler.Location = new System.Drawing.Point(12, 29);
            this.btnDersler.Name = "btnDersler";
            this.btnDersler.Size = new System.Drawing.Size(184, 107);
            this.btnDersler.TabIndex = 0;
            this.btnDersler.Text = "Dersler";
            this.btnDersler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDersler.UseVisualStyleBackColor = false;
            this.btnDersler.Click += new System.EventHandler(this.btnDersler_Click);
            // 
            // pnlOrta
            // 
            this.pnlOrta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlOrta.Controls.Add(this.lvwOgretmenler);
            this.pnlOrta.Controls.Add(this.lvwDerslikler);
            this.pnlOrta.Controls.Add(this.lvwSiniflar);
            this.pnlOrta.Controls.Add(this.lvwDersler);
            this.pnlOrta.Controls.Add(this.lblListeAdi);
            this.pnlOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrta.Location = new System.Drawing.Point(210, 0);
            this.pnlOrta.Name = "pnlOrta";
            this.pnlOrta.Size = new System.Drawing.Size(630, 578);
            this.pnlOrta.TabIndex = 10;
            // 
            // lvwOgretmenler
            // 
            this.lvwOgretmenler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader12,
            this.columnHeader10,
            this.columnHeader11});
            this.lvwOgretmenler.FullRowSelect = true;
            this.lvwOgretmenler.HideSelection = false;
            this.lvwOgretmenler.Location = new System.Drawing.Point(0, 440);
            this.lvwOgretmenler.MultiSelect = false;
            this.lvwOgretmenler.Name = "lvwOgretmenler";
            this.lvwOgretmenler.ShowGroups = false;
            this.lvwOgretmenler.Size = new System.Drawing.Size(624, 129);
            this.lvwOgretmenler.SmallImageList = this.img16pxIcons;
            this.lvwOgretmenler.TabIndex = 5;
            this.lvwOgretmenler.UseCompatibleStateImageBehavior = false;
            this.lvwOgretmenler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Adı";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Soyadı";
            this.columnHeader12.Width = 120;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Kısa Kodu";
            this.columnHeader10.Width = 100;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Toplam Saat";
            this.columnHeader11.Width = 100;
            // 
            // img16pxIcons
            // 
            this.img16pxIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img16pxIcons.ImageStream")));
            this.img16pxIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.img16pxIcons.Images.SetKeyName(0, "ders16px.png");
            this.img16pxIcons.Images.SetKeyName(1, "sinif16px.png");
            this.img16pxIcons.Images.SetKeyName(2, "derslik16px.png");
            this.img16pxIcons.Images.SetKeyName(3, "ogretmen16px.png");
            // 
            // lvwDerslikler
            // 
            this.lvwDerslikler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvwDerslikler.FullRowSelect = true;
            this.lvwDerslikler.HideSelection = false;
            this.lvwDerslikler.Location = new System.Drawing.Point(0, 305);
            this.lvwDerslikler.MultiSelect = false;
            this.lvwDerslikler.Name = "lvwDerslikler";
            this.lvwDerslikler.ShowGroups = false;
            this.lvwDerslikler.Size = new System.Drawing.Size(624, 129);
            this.lvwDerslikler.SmallImageList = this.img16pxIcons;
            this.lvwDerslikler.TabIndex = 4;
            this.lvwDerslikler.UseCompatibleStateImageBehavior = false;
            this.lvwDerslikler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Adı";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kısa Kodu";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Toplam Saat";
            this.columnHeader7.Width = 100;
            // 
            // lvwSiniflar
            // 
            this.lvwSiniflar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwSiniflar.FullRowSelect = true;
            this.lvwSiniflar.HideSelection = false;
            this.lvwSiniflar.Location = new System.Drawing.Point(0, 170);
            this.lvwSiniflar.MultiSelect = false;
            this.lvwSiniflar.Name = "lvwSiniflar";
            this.lvwSiniflar.ShowGroups = false;
            this.lvwSiniflar.Size = new System.Drawing.Size(624, 129);
            this.lvwSiniflar.SmallImageList = this.img16pxIcons;
            this.lvwSiniflar.TabIndex = 3;
            this.lvwSiniflar.UseCompatibleStateImageBehavior = false;
            this.lvwSiniflar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kısa Kodu";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Toplam Saat";
            this.columnHeader3.Width = 100;
            // 
            // lvwDersler
            // 
            this.lvwDersler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnAd,
            this.clmnKod,
            this.clmnTS,
            this.clmnDagilim});
            this.lvwDersler.FullRowSelect = true;
            this.lvwDersler.HideSelection = false;
            this.lvwDersler.Location = new System.Drawing.Point(0, 35);
            this.lvwDersler.MultiSelect = false;
            this.lvwDersler.Name = "lvwDersler";
            this.lvwDersler.ShowGroups = false;
            this.lvwDersler.Size = new System.Drawing.Size(624, 129);
            this.lvwDersler.SmallImageList = this.img16pxIcons;
            this.lvwDersler.TabIndex = 2;
            this.lvwDersler.UseCompatibleStateImageBehavior = false;
            this.lvwDersler.View = System.Windows.Forms.View.Details;
            // 
            // clmnAd
            // 
            this.clmnAd.Text = "Adı";
            this.clmnAd.Width = 200;
            // 
            // clmnKod
            // 
            this.clmnKod.Text = "Kısa Kodu";
            this.clmnKod.Width = 92;
            // 
            // clmnTS
            // 
            this.clmnTS.Text = "Toplam Saat";
            this.clmnTS.Width = 100;
            // 
            // clmnDagilim
            // 
            this.clmnDagilim.Text = "Dağılım Şekli";
            this.clmnDagilim.Width = 100;
            // 
            // lblListeAdi
            // 
            this.lblListeAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblListeAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListeAdi.Location = new System.Drawing.Point(0, 0);
            this.lblListeAdi.Name = "lblListeAdi";
            this.lblListeAdi.Size = new System.Drawing.Size(630, 32);
            this.lblListeAdi.TabIndex = 0;
            this.lblListeAdi.Text = "Tanımlı Dersler";
            this.lblListeAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmVeriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 578);
            this.Controls.Add(this.pnlOrta);
            this.Controls.Add(this.pnlSag);
            this.Controls.Add(this.pnlSol);
            this.Name = "frmVeriler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dersler";
            this.pnlSag.ResumeLayout(false);
            this.pnlSol.ResumeLayout(false);
            this.pnlOrta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSag;
        private System.Windows.Forms.Button btnKısıtlamalar;
        private System.Windows.Forms.Button btnZamanTablosu;
        private System.Windows.Forms.Button btnDersAtamasi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Button btnOgretmenler;
        private System.Windows.Forms.Button btnDerslikler;
        private System.Windows.Forms.Button btnSiniflar;
        private System.Windows.Forms.Button btnDersler;
        private System.Windows.Forms.Panel pnlOrta;
        private System.Windows.Forms.Label lblListeAdi;
        private System.Windows.Forms.ImageList img16pxIcons;
        private System.Windows.Forms.ListView lvwDersler;
        private System.Windows.Forms.ColumnHeader clmnAd;
        private System.Windows.Forms.ColumnHeader clmnKod;
        private System.Windows.Forms.ColumnHeader clmnTS;
        private System.Windows.Forms.ColumnHeader clmnDagilim;
        private System.Windows.Forms.ListView lvwOgretmenler;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ListView lvwDerslikler;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lvwSiniflar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnKapat;
    }
}