namespace Ders_Programı_Planlayıcı
{
    partial class frmPlanlamaIlıskileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPlanlamaIlıskileri));
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAraclar = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEkle = new System.Windows.Forms.ToolStripButton();
            this.tsbDuzenle = new System.Windows.Forms.ToolStripButton();
            this.tsbSil = new System.Windows.Forms.ToolStripButton();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAktifEt = new System.Windows.Forms.ToolStripButton();
            this.tsbDevreDisiBirak = new System.Windows.Forms.ToolStripButton();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbYukari = new System.Windows.Forms.ToolStripButton();
            this.tsbAsagi = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chSira = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chOnemDüzeyi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAktifPasif = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDersler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUygula = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTanimlama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chParametreler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlAraclar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planlama İlişkileri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAraclar
            // 
            this.pnlAraclar.Controls.Add(this.toolStrip1);
            this.pnlAraclar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAraclar.Location = new System.Drawing.Point(0, 458);
            this.pnlAraclar.Name = "pnlAraclar";
            this.pnlAraclar.Size = new System.Drawing.Size(793, 82);
            this.pnlAraclar.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEkle,
            this.tsbDuzenle,
            this.tsbSil,
            this.tss1,
            this.tsbAktifEt,
            this.tsbDevreDisiBirak,
            this.tss2,
            this.tsbYukari,
            this.tsbAsagi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(793, 82);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEkle
            // 
            this.tsbEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsbEkle.Image")));
            this.tsbEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEkle.Name = "tsbEkle";
            this.tsbEkle.Size = new System.Drawing.Size(40, 79);
            this.tsbEkle.Text = "Ekle";
            this.tsbEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbDuzenle
            // 
            this.tsbDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("tsbDuzenle.Image")));
            this.tsbDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDuzenle.Name = "tsbDuzenle";
            this.tsbDuzenle.Size = new System.Drawing.Size(67, 79);
            this.tsbDuzenle.Text = "Düzenle";
            this.tsbDuzenle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbSil
            // 
            this.tsbSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbSil.Image")));
            this.tsbSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSil.Name = "tsbSil";
            this.tsbSil.Size = new System.Drawing.Size(29, 79);
            this.tsbSil.Text = "Sil";
            this.tsbSil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 82);
            // 
            // tsbAktifEt
            // 
            this.tsbAktifEt.Image = ((System.Drawing.Image)(resources.GetObject("tsbAktifEt.Image")));
            this.tsbAktifEt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAktifEt.Name = "tsbAktifEt";
            this.tsbAktifEt.Size = new System.Drawing.Size(61, 79);
            this.tsbAktifEt.Text = "Aktif Et";
            this.tsbAktifEt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbDevreDisiBirak
            // 
            this.tsbDevreDisiBirak.Image = ((System.Drawing.Image)(resources.GetObject("tsbDevreDisiBirak.Image")));
            this.tsbDevreDisiBirak.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDevreDisiBirak.Name = "tsbDevreDisiBirak";
            this.tsbDevreDisiBirak.Size = new System.Drawing.Size(118, 79);
            this.tsbDevreDisiBirak.Text = "Devre Dışı Bırak";
            this.tsbDevreDisiBirak.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(6, 82);
            // 
            // tsbYukari
            // 
            this.tsbYukari.Image = ((System.Drawing.Image)(resources.GetObject("tsbYukari.Image")));
            this.tsbYukari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbYukari.Name = "tsbYukari";
            this.tsbYukari.Size = new System.Drawing.Size(53, 79);
            this.tsbYukari.Text = "Yukarı";
            this.tsbYukari.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbAsagi
            // 
            this.tsbAsagi.Image = ((System.Drawing.Image)(resources.GetObject("tsbAsagi.Image")));
            this.tsbAsagi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAsagi.Name = "tsbAsagi";
            this.tsbAsagi.Size = new System.Drawing.Size(50, 79);
            this.tsbAsagi.Text = "Aşağı";
            this.tsbAsagi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSira,
            this.chOnemDüzeyi,
            this.chAktifPasif,
            this.chDersler,
            this.chUygula,
            this.chTanimlama,
            this.chParametreler});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 47);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(793, 411);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // chSira
            // 
            this.chSira.Text = "";
            // 
            // chOnemDüzeyi
            // 
            this.chOnemDüzeyi.Text = "";
            // 
            // chAktifPasif
            // 
            this.chAktifPasif.Text = "";
            // 
            // chDersler
            // 
            this.chDersler.Text = "Dersler";
            this.chDersler.Width = 80;
            // 
            // chUygula
            // 
            this.chUygula.Text = "Uygula";
            this.chUygula.Width = 80;
            // 
            // chTanimlama
            // 
            this.chTanimlama.Text = "Tanımlama";
            this.chTanimlama.Width = 80;
            // 
            // chParametreler
            // 
            this.chParametreler.Text = "Parametreler";
            this.chParametreler.Width = 102;
            // 
            // frmPlanlamaIlıskileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 540);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pnlAraclar);
            this.Controls.Add(this.label1);
            this.Name = "frmPlanlamaIlıskileri";
            this.ShowIcon = false;
            this.Text = "Planlama İlişkileri";
            this.pnlAraclar.ResumeLayout(false);
            this.pnlAraclar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAraclar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEkle;
        private System.Windows.Forms.ToolStripButton tsbDuzenle;
        private System.Windows.Forms.ToolStripButton tsbSil;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripButton tsbAktifEt;
        private System.Windows.Forms.ToolStripButton tsbDevreDisiBirak;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripButton tsbYukari;
        private System.Windows.Forms.ToolStripButton tsbAsagi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader chSira;
        private System.Windows.Forms.ColumnHeader chOnemDüzeyi;
        private System.Windows.Forms.ColumnHeader chAktifPasif;
        private System.Windows.Forms.ColumnHeader chDersler;
        private System.Windows.Forms.ColumnHeader chUygula;
        private System.Windows.Forms.ColumnHeader chTanimlama;
        private System.Windows.Forms.ColumnHeader chParametreler;
    }
}