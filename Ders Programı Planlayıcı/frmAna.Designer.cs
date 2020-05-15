namespace Ders_Programı_Planlayıcı
{
    partial class frmAna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlAlt = new System.Windows.Forms.Panel();
            this.lvwBasarisizlar = new System.Windows.Forms.ListView();
            this.clmnKayit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnTanimlama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flpOgretmenler = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSiniflar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDersBilgi = new System.Windows.Forms.Panel();
            this.lblDerslik = new System.Windows.Forms.Label();
            this.lblOgretmen = new System.Windows.Forms.Label();
            this.lblSinif = new System.Windows.Forms.Label();
            this.lblDers = new System.Windows.Forms.Label();
            this.lblEtiket = new System.Windows.Forms.Label();
            this.tpAnaMenu = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbYeni = new System.Windows.Forms.ToolStripButton();
            this.tsbKaydet = new System.Windows.Forms.ToolStripButton();
            this.tsbOnizle = new System.Windows.Forms.ToolStripButton();
            this.tsbVeritabani = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDersler = new System.Windows.Forms.ToolStripButton();
            this.tsbSiniflar = new System.Windows.Forms.ToolStripButton();
            this.tsbDerslikler = new System.Windows.Forms.ToolStripButton();
            this.tsbOgretmenler = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOnceKontrol = new System.Windows.Forms.ToolStripButton();
            this.tsbPlanlama = new System.Windows.Forms.ToolStripButton();
            this.tsbSonraKontrol = new System.Windows.Forms.ToolStripButton();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblBasari = new System.Windows.Forms.Label();
            this.lblAnaTur = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.tpDersCizelgesi = new System.Windows.Forms.TabPage();
            this.tpDerslikler = new System.Windows.Forms.TabPage();
            this.tpOgretmenler = new System.Windows.Forms.TabPage();
            this.tpSiniflar = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.flpDerslikler = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpSiniflar = new Ders_Programı_Planlayıcı.DBLayoutPanel(this.components);
            this.tlpOgretmenler = new Ders_Programı_Planlayıcı.DBLayoutPanel(this.components);
            this.tlpDerslikler = new Ders_Programı_Planlayıcı.DBLayoutPanel(this.components);
            this.pnlAlt.SuspendLayout();
            this.pnlDersBilgi.SuspendLayout();
            this.tpAnaMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tpDerslikler.SuspendLayout();
            this.tpOgretmenler.SuspendLayout();
            this.tpSiniflar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(10, 653);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1382, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlAlt
            // 
            this.pnlAlt.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlAlt.Controls.Add(this.flpDerslikler);
            this.pnlAlt.Controls.Add(this.lvwBasarisizlar);
            this.pnlAlt.Controls.Add(this.flpOgretmenler);
            this.pnlAlt.Controls.Add(this.flpSiniflar);
            this.pnlAlt.Controls.Add(this.pnlDersBilgi);
            this.pnlAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAlt.Location = new System.Drawing.Point(10, 514);
            this.pnlAlt.Name = "pnlAlt";
            this.pnlAlt.Size = new System.Drawing.Size(1382, 139);
            this.pnlAlt.TabIndex = 2;
            // 
            // lvwBasarisizlar
            // 
            this.lvwBasarisizlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwBasarisizlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnKayit,
            this.clmnTanimlama});
            this.lvwBasarisizlar.FullRowSelect = true;
            this.lvwBasarisizlar.HideSelection = false;
            this.lvwBasarisizlar.Location = new System.Drawing.Point(1180, 6);
            this.lvwBasarisizlar.MultiSelect = false;
            this.lvwBasarisizlar.Name = "lvwBasarisizlar";
            this.lvwBasarisizlar.Size = new System.Drawing.Size(195, 130);
            this.lvwBasarisizlar.TabIndex = 15;
            this.lvwBasarisizlar.UseCompatibleStateImageBehavior = false;
            this.lvwBasarisizlar.View = System.Windows.Forms.View.Details;
            this.lvwBasarisizlar.Visible = false;
            // 
            // clmnKayit
            // 
            this.clmnKayit.Text = "Kayıt";
            this.clmnKayit.Width = 223;
            // 
            // clmnTanimlama
            // 
            this.clmnTanimlama.Text = "Tanımlama";
            this.clmnTanimlama.Width = 500;
            // 
            // flpOgretmenler
            // 
            this.flpOgretmenler.AutoScroll = true;
            this.flpOgretmenler.BackColor = System.Drawing.Color.White;
            this.flpOgretmenler.Location = new System.Drawing.Point(739, 6);
            this.flpOgretmenler.Name = "flpOgretmenler";
            this.flpOgretmenler.Size = new System.Drawing.Size(214, 130);
            this.flpOgretmenler.TabIndex = 15;
            // 
            // flpSiniflar
            // 
            this.flpSiniflar.AutoScroll = true;
            this.flpSiniflar.BackColor = System.Drawing.Color.White;
            this.flpSiniflar.Location = new System.Drawing.Point(506, 6);
            this.flpSiniflar.Name = "flpSiniflar";
            this.flpSiniflar.Size = new System.Drawing.Size(227, 130);
            this.flpSiniflar.TabIndex = 14;
            // 
            // pnlDersBilgi
            // 
            this.pnlDersBilgi.BackColor = System.Drawing.Color.DimGray;
            this.pnlDersBilgi.Controls.Add(this.lblDerslik);
            this.pnlDersBilgi.Controls.Add(this.lblOgretmen);
            this.pnlDersBilgi.Controls.Add(this.lblSinif);
            this.pnlDersBilgi.Controls.Add(this.lblDers);
            this.pnlDersBilgi.Controls.Add(this.lblEtiket);
            this.pnlDersBilgi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDersBilgi.Location = new System.Drawing.Point(0, 0);
            this.pnlDersBilgi.Name = "pnlDersBilgi";
            this.pnlDersBilgi.Size = new System.Drawing.Size(500, 139);
            this.pnlDersBilgi.TabIndex = 0;
            // 
            // lblDerslik
            // 
            this.lblDerslik.AutoSize = true;
            this.lblDerslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDerslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDerslik.Location = new System.Drawing.Point(138, 103);
            this.lblDerslik.Name = "lblDerslik";
            this.lblDerslik.Size = new System.Drawing.Size(0, 20);
            this.lblDerslik.TabIndex = 4;
            // 
            // lblOgretmen
            // 
            this.lblOgretmen.AutoSize = true;
            this.lblOgretmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOgretmen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOgretmen.Location = new System.Drawing.Point(138, 73);
            this.lblOgretmen.Name = "lblOgretmen";
            this.lblOgretmen.Size = new System.Drawing.Size(0, 20);
            this.lblOgretmen.TabIndex = 3;
            // 
            // lblSinif
            // 
            this.lblSinif.AutoSize = true;
            this.lblSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSinif.Location = new System.Drawing.Point(138, 43);
            this.lblSinif.Name = "lblSinif";
            this.lblSinif.Size = new System.Drawing.Size(0, 20);
            this.lblSinif.TabIndex = 2;
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDers.Location = new System.Drawing.Point(138, 13);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(0, 20);
            this.lblDers.TabIndex = 1;
            // 
            // lblEtiket
            // 
            this.lblEtiket.BackColor = System.Drawing.Color.DimGray;
            this.lblEtiket.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEtiket.Location = new System.Drawing.Point(12, 13);
            this.lblEtiket.Name = "lblEtiket";
            this.lblEtiket.Size = new System.Drawing.Size(116, 53);
            this.lblEtiket.TabIndex = 0;
            this.lblEtiket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpAnaMenu
            // 
            this.tpAnaMenu.Controls.Add(this.toolStrip1);
            this.tpAnaMenu.Location = new System.Drawing.Point(4, 25);
            this.tpAnaMenu.Name = "tpAnaMenu";
            this.tpAnaMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tpAnaMenu.Size = new System.Drawing.Size(1374, 102);
            this.tpAnaMenu.TabIndex = 0;
            this.tpAnaMenu.Text = "Ana Menü";
            this.tpAnaMenu.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbYeni,
            this.tsbKaydet,
            this.tsbOnizle,
            this.tsbVeritabani,
            this.toolStripSeparator1,
            this.tsbDersler,
            this.tsbSiniflar,
            this.tsbDerslikler,
            this.tsbOgretmenler,
            this.toolStripSeparator2,
            this.tsbOnceKontrol,
            this.tsbPlanlama,
            this.tsbSonraKontrol});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1368, 96);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbYeni
            // 
            this.tsbYeni.Image = ((System.Drawing.Image)(resources.GetObject("tsbYeni.Image")));
            this.tsbYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYeni.Name = "tsbYeni";
            this.tsbYeni.Padding = new System.Windows.Forms.Padding(10);
            this.tsbYeni.Size = new System.Drawing.Size(60, 93);
            this.tsbYeni.Text = "Yeni";
            this.tsbYeni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbKaydet
            // 
            this.tsbKaydet.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.kaydet32px;
            this.tsbKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKaydet.Name = "tsbKaydet";
            this.tsbKaydet.Padding = new System.Windows.Forms.Padding(10);
            this.tsbKaydet.Size = new System.Drawing.Size(79, 93);
            this.tsbKaydet.Text = "Kaydet";
            this.tsbKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbKaydet.ToolTipText = "Verileri veritabanına günceller";
            // 
            // tsbOnizle
            // 
            this.tsbOnizle.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.onizle32px;
            this.tsbOnizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOnizle.Name = "tsbOnizle";
            this.tsbOnizle.Padding = new System.Windows.Forms.Padding(10);
            this.tsbOnizle.Size = new System.Drawing.Size(75, 93);
            this.tsbOnizle.Text = "Önizle";
            this.tsbOnizle.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbOnizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOnizle.ToolTipText = "Oluşturulan ders programlarını A4 çıktısı olarak gösterir";
            this.tsbOnizle.Click += new System.EventHandler(this.tsbOnizle_Click);
            // 
            // tsbVeritabani
            // 
            this.tsbVeritabani.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.veritabaniIndir32px;
            this.tsbVeritabani.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVeritabani.Name = "tsbVeritabani";
            this.tsbVeritabani.Size = new System.Drawing.Size(84, 93);
            this.tsbVeritabani.Text = "Veritabanı ";
            this.tsbVeritabani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbVeritabani.ToolTipText = "Veritabanında veri çekmek için pencere açar";
            this.tsbVeritabani.Click += new System.EventHandler(this.tsbVeritabani_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 96);
            // 
            // tsbDersler
            // 
            this.tsbDersler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbDersler.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.ders32px;
            this.tsbDersler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDersler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDersler.Name = "tsbDersler";
            this.tsbDersler.Padding = new System.Windows.Forms.Padding(10);
            this.tsbDersler.Size = new System.Drawing.Size(80, 93);
            this.tsbDersler.Text = "Dersler";
            this.tsbDersler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDersler.Click += new System.EventHandler(this.tsbDersler_Click);
            // 
            // tsbSiniflar
            // 
            this.tsbSiniflar.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.sinif32px;
            this.tsbSiniflar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSiniflar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSiniflar.Name = "tsbSiniflar";
            this.tsbSiniflar.Padding = new System.Windows.Forms.Padding(10);
            this.tsbSiniflar.Size = new System.Drawing.Size(79, 93);
            this.tsbSiniflar.Text = "Sınıflar";
            this.tsbSiniflar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSiniflar.Click += new System.EventHandler(this.tsbSiniflar_Click);
            // 
            // tsbDerslikler
            // 
            this.tsbDerslikler.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.derslik32px;
            this.tsbDerslikler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDerslikler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDerslikler.Name = "tsbDerslikler";
            this.tsbDerslikler.Padding = new System.Windows.Forms.Padding(10);
            this.tsbDerslikler.Size = new System.Drawing.Size(95, 93);
            this.tsbDerslikler.Text = "Derslikler";
            this.tsbDerslikler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDerslikler.Click += new System.EventHandler(this.tsbDerslikler_Click);
            // 
            // tsbOgretmenler
            // 
            this.tsbOgretmenler.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.ogretmen32px;
            this.tsbOgretmenler.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOgretmenler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOgretmenler.Name = "tsbOgretmenler";
            this.tsbOgretmenler.Padding = new System.Windows.Forms.Padding(10);
            this.tsbOgretmenler.Size = new System.Drawing.Size(117, 93);
            this.tsbOgretmenler.Text = "Öğretmenler";
            this.tsbOgretmenler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOgretmenler.Click += new System.EventHandler(this.tsbOgretmenler_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 96);
            // 
            // tsbOnceKontrol
            // 
            this.tsbOnceKontrol.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.onkontrol32px;
            this.tsbOnceKontrol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbOnceKontrol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOnceKontrol.Name = "tsbOnceKontrol";
            this.tsbOnceKontrol.Padding = new System.Windows.Forms.Padding(10);
            this.tsbOnceKontrol.Size = new System.Drawing.Size(195, 93);
            this.tsbOnceKontrol.Text = "Planlama Öncesi Kontrol";
            this.tsbOnceKontrol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbOnceKontrol.ToolTipText = "Otomatik planlama öncesinde verilerin doğruluğu hakkınnda ön kontrol gerçekleştir" +
    "ir";
            this.tsbOnceKontrol.Click += new System.EventHandler(this.tsbKontrol_Click);
            // 
            // tsbPlanlama
            // 
            this.tsbPlanlama.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.algoritma32px;
            this.tsbPlanlama.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbPlanlama.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlanlama.Name = "tsbPlanlama";
            this.tsbPlanlama.Padding = new System.Windows.Forms.Padding(10);
            this.tsbPlanlama.Size = new System.Drawing.Size(215, 93);
            this.tsbPlanlama.Text = "Otomatik Planlamayı Başlat";
            this.tsbPlanlama.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbPlanlama.ToolTipText = "Otomatik ders planlamayı başlatır";
            this.tsbPlanlama.Click += new System.EventHandler(this.tsbPlanlama_Click);
            // 
            // tsbSonraKontrol
            // 
            this.tsbSonraKontrol.CheckOnClick = true;
            this.tsbSonraKontrol.Image = global::Ders_Programı_Planlayıcı.Properties.Resources.sonraKontrol32px;
            this.tsbSonraKontrol.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbSonraKontrol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSonraKontrol.Name = "tsbSonraKontrol";
            this.tsbSonraKontrol.Padding = new System.Windows.Forms.Padding(10);
            this.tsbSonraKontrol.Size = new System.Drawing.Size(199, 93);
            this.tsbSonraKontrol.Text = "Planlama Sonrası Kontrol";
            this.tsbSonraKontrol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSonraKontrol.ToolTipText = "Otomatik ders planlamayı başlatır";
            this.tsbSonraKontrol.Click += new System.EventHandler(this.tsbSonraKontrol_Click);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tpAnaMenu);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMenu.Location = new System.Drawing.Point(10, 10);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1382, 131);
            this.tabMenu.TabIndex = 0;
            // 
            // lblTur
            // 
            this.lblTur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblTur.Location = new System.Drawing.Point(507, -5);
            this.lblTur.Margin = new System.Windows.Forms.Padding(0);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(100, 23);
            this.lblTur.TabIndex = 3;
            this.lblTur.Text = "TUR";
            this.lblTur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBasari
            // 
            this.lblBasari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBasari.Location = new System.Drawing.Point(638, -5);
            this.lblBasari.Name = "lblBasari";
            this.lblBasari.Size = new System.Drawing.Size(303, 23);
            this.lblBasari.TabIndex = 4;
            this.lblBasari.Text = "0/0";
            this.lblBasari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnaTur
            // 
            this.lblAnaTur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblAnaTur.Location = new System.Drawing.Point(967, -5);
            this.lblAnaTur.Name = "lblAnaTur";
            this.lblAnaTur.Size = new System.Drawing.Size(100, 23);
            this.lblAnaTur.TabIndex = 5;
            this.lblAnaTur.Text = "anafonktur";
            this.lblAnaTur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMax
            // 
            this.lblMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblMax.Location = new System.Drawing.Point(286, -5);
            this.lblMax.Margin = new System.Windows.Forms.Padding(0);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(100, 23);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "0";
            this.lblMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpDersCizelgesi
            // 
            this.tpDersCizelgesi.Location = new System.Drawing.Point(25, 4);
            this.tpDersCizelgesi.Name = "tpDersCizelgesi";
            this.tpDersCizelgesi.Size = new System.Drawing.Size(1353, 365);
            this.tpDersCizelgesi.TabIndex = 4;
            this.tpDersCizelgesi.Text = "Ders Çizelgesi";
            this.tpDersCizelgesi.UseVisualStyleBackColor = true;
            // 
            // tpDerslikler
            // 
            this.tpDerslikler.Controls.Add(this.tlpDerslikler);
            this.tpDerslikler.Location = new System.Drawing.Point(25, 4);
            this.tpDerslikler.Name = "tpDerslikler";
            this.tpDerslikler.Size = new System.Drawing.Size(1353, 365);
            this.tpDerslikler.TabIndex = 2;
            this.tpDerslikler.Text = "Derslikler";
            this.tpDerslikler.UseVisualStyleBackColor = true;
            // 
            // tpOgretmenler
            // 
            this.tpOgretmenler.Controls.Add(this.tlpOgretmenler);
            this.tpOgretmenler.Location = new System.Drawing.Point(25, 4);
            this.tpOgretmenler.Name = "tpOgretmenler";
            this.tpOgretmenler.Size = new System.Drawing.Size(1353, 365);
            this.tpOgretmenler.TabIndex = 1;
            this.tpOgretmenler.Text = "Öğretmenler";
            this.tpOgretmenler.UseVisualStyleBackColor = true;
            // 
            // tpSiniflar
            // 
            this.tpSiniflar.Controls.Add(this.tlpSiniflar);
            this.tpSiniflar.Location = new System.Drawing.Point(25, 4);
            this.tpSiniflar.Name = "tpSiniflar";
            this.tpSiniflar.Size = new System.Drawing.Size(1353, 365);
            this.tpSiniflar.TabIndex = 0;
            this.tpSiniflar.Text = "Sınıflar";
            this.tpSiniflar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpSiniflar);
            this.tabControl1.Controls.Add(this.tpOgretmenler);
            this.tabControl1.Controls.Add(this.tpDerslikler);
            this.tabControl1.Controls.Add(this.tpDersCizelgesi);
            this.tabControl1.Location = new System.Drawing.Point(10, 141);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 373);
            this.tabControl1.TabIndex = 3;
            // 
            // flpDerslikler
            // 
            this.flpDerslikler.AutoScroll = true;
            this.flpDerslikler.BackColor = System.Drawing.Color.White;
            this.flpDerslikler.Location = new System.Drawing.Point(959, 6);
            this.flpDerslikler.Name = "flpDerslikler";
            this.flpDerslikler.Size = new System.Drawing.Size(214, 130);
            this.flpDerslikler.TabIndex = 16;
            // 
            // tlpSiniflar
            // 
            this.tlpSiniflar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpSiniflar.AutoScroll = true;
            this.tlpSiniflar.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpSiniflar.ColumnCount = 1;
            this.tlpSiniflar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpSiniflar.Location = new System.Drawing.Point(0, 3);
            this.tlpSiniflar.Name = "tlpSiniflar";
            this.tlpSiniflar.RowCount = 1;
            this.tlpSiniflar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSiniflar.Size = new System.Drawing.Size(1353, 362);
            this.tlpSiniflar.TabIndex = 15;
            this.tlpSiniflar.Text = "DBLayoutPanel";
            this.tlpSiniflar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tlpSiniflar_MouseClick);
            // 
            // tlpOgretmenler
            // 
            this.tlpOgretmenler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpOgretmenler.AutoScroll = true;
            this.tlpOgretmenler.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpOgretmenler.ColumnCount = 1;
            this.tlpOgretmenler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOgretmenler.Location = new System.Drawing.Point(0, 1);
            this.tlpOgretmenler.Name = "tlpOgretmenler";
            this.tlpOgretmenler.RowCount = 1;
            this.tlpOgretmenler.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOgretmenler.Size = new System.Drawing.Size(1353, 362);
            this.tlpOgretmenler.TabIndex = 16;
            this.tlpOgretmenler.Text = "DBLayoutPanel";
            // 
            // tlpDerslikler
            // 
            this.tlpDerslikler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpDerslikler.AutoScroll = true;
            this.tlpDerslikler.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpDerslikler.ColumnCount = 1;
            this.tlpDerslikler.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDerslikler.Location = new System.Drawing.Point(0, 1);
            this.tlpDerslikler.Name = "tlpDerslikler";
            this.tlpDerslikler.RowCount = 1;
            this.tlpDerslikler.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDerslikler.Size = new System.Drawing.Size(1353, 362);
            this.tlpDerslikler.TabIndex = 17;
            this.tlpDerslikler.Text = "DBLayoutPanel";
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 685);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblAnaTur);
            this.Controls.Add(this.lblBasari);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlAlt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabMenu);
            this.Name = "frmAna";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Programı Planlayıcı";
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.pnlAlt.ResumeLayout(false);
            this.pnlDersBilgi.ResumeLayout(false);
            this.pnlDersBilgi.PerformLayout();
            this.tpAnaMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabMenu.ResumeLayout(false);
            this.tpDerslikler.ResumeLayout(false);
            this.tpOgretmenler.ResumeLayout(false);
            this.tpSiniflar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlAlt;
        private System.Windows.Forms.Panel pnlDersBilgi;
        private System.Windows.Forms.TabPage tpAnaMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbYeni;
        private System.Windows.Forms.ToolStripButton tsbKaydet;
        private System.Windows.Forms.ToolStripButton tsbOnizle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDersler;
        private System.Windows.Forms.ToolStripButton tsbSiniflar;
        private System.Windows.Forms.ToolStripButton tsbDerslikler;
        private System.Windows.Forms.ToolStripButton tsbOgretmenler;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbOnceKontrol;
        private System.Windows.Forms.ToolStripButton tsbSonraKontrol;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.ToolStripButton tsbVeritabani;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblBasari;
        private System.Windows.Forms.Label lblAnaTur;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TabPage tpDersCizelgesi;
        private System.Windows.Forms.TabPage tpDerslikler;
        private System.Windows.Forms.TabPage tpOgretmenler;
        private System.Windows.Forms.TabPage tpSiniflar;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.Label lblEtiket;
        public System.Windows.Forms.Label lblDers;
        public System.Windows.Forms.Label lblDerslik;
        public System.Windows.Forms.Label lblOgretmen;
        public System.Windows.Forms.Label lblSinif;
        private System.Windows.Forms.ToolStripButton tsbPlanlama;
        private System.Windows.Forms.ListView lvwBasarisizlar;
        private System.Windows.Forms.ColumnHeader clmnKayit;
        private System.Windows.Forms.ColumnHeader clmnTanimlama;
        public System.Windows.Forms.FlowLayoutPanel flpSiniflar;
        public DBLayoutPanel tlpSiniflar;
        public System.Windows.Forms.FlowLayoutPanel flpOgretmenler;
        public DBLayoutPanel tlpOgretmenler;
        public DBLayoutPanel tlpDerslikler;
        public System.Windows.Forms.FlowLayoutPanel flpDerslikler;
    }
}

