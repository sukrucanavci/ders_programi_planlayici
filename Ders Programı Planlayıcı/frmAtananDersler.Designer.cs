namespace Ders_Programı_Planlayıcı
{
    partial class frmAtananDersler
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
            this.lblImage = new System.Windows.Forms.Label();
            this.lblKod = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnYeniDers = new System.Windows.Forms.Button();
            this.dgwAtananDersler = new System.Windows.Forms.DataGridView();
            this.clmnKart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOgretmen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSinif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDagilim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnDerslik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAtananDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblImage);
            this.panel1.Controls.Add(this.lblKod);
            this.panel1.Controls.Add(this.lblAd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 95);
            this.panel1.TabIndex = 10;
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(12, 9);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(93, 82);
            this.lblImage.TabIndex = 3;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(111, 45);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(47, 17);
            this.lblKod.TabIndex = 2;
            this.lblKod.Text = "lblKod";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(111, 9);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(61, 25);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "lblAd";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnGuncelle);
            this.panel2.Controls.Add(this.btnYeniDers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 535);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 60);
            this.panel2.TabIndex = 11;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Location = new System.Drawing.Point(624, 7);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(121, 41);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(266, 7);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(121, 41);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(139, 7);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 41);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnYeniDers
            // 
            this.btnYeniDers.Location = new System.Drawing.Point(12, 7);
            this.btnYeniDers.Name = "btnYeniDers";
            this.btnYeniDers.Size = new System.Drawing.Size(121, 41);
            this.btnYeniDers.TabIndex = 0;
            this.btnYeniDers.Text = "Yeni Ders";
            this.btnYeniDers.UseVisualStyleBackColor = true;
            // 
            // dgwAtananDersler
            // 
            this.dgwAtananDersler.AllowUserToAddRows = false;
            this.dgwAtananDersler.AllowUserToDeleteRows = false;
            this.dgwAtananDersler.AllowUserToResizeColumns = false;
            this.dgwAtananDersler.AllowUserToResizeRows = false;
            this.dgwAtananDersler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwAtananDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwAtananDersler.BackgroundColor = System.Drawing.Color.White;
            this.dgwAtananDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAtananDersler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnKart,
            this.clmnDers,
            this.clmnOgretmen,
            this.clmnSinif,
            this.clmnDagilim,
            this.clmnDerslik});
            this.dgwAtananDersler.Location = new System.Drawing.Point(12, 94);
            this.dgwAtananDersler.MultiSelect = false;
            this.dgwAtananDersler.Name = "dgwAtananDersler";
            this.dgwAtananDersler.ReadOnly = true;
            this.dgwAtananDersler.RowHeadersVisible = false;
            this.dgwAtananDersler.RowHeadersWidth = 51;
            this.dgwAtananDersler.RowTemplate.Height = 24;
            this.dgwAtananDersler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAtananDersler.Size = new System.Drawing.Size(733, 435);
            this.dgwAtananDersler.TabIndex = 12;
            // 
            // clmnKart
            // 
            this.clmnKart.HeaderText = "";
            this.clmnKart.MinimumWidth = 6;
            this.clmnKart.Name = "clmnKart";
            this.clmnKart.ReadOnly = true;
            // 
            // clmnDers
            // 
            this.clmnDers.HeaderText = "Ders";
            this.clmnDers.MinimumWidth = 6;
            this.clmnDers.Name = "clmnDers";
            this.clmnDers.ReadOnly = true;
            // 
            // clmnOgretmen
            // 
            this.clmnOgretmen.HeaderText = "Öğretmen";
            this.clmnOgretmen.MinimumWidth = 6;
            this.clmnOgretmen.Name = "clmnOgretmen";
            this.clmnOgretmen.ReadOnly = true;
            // 
            // clmnSinif
            // 
            this.clmnSinif.HeaderText = "Sınıf";
            this.clmnSinif.MinimumWidth = 6;
            this.clmnSinif.Name = "clmnSinif";
            this.clmnSinif.ReadOnly = true;
            // 
            // clmnDagilim
            // 
            this.clmnDagilim.HeaderText = "Dağılım Şekli";
            this.clmnDagilim.MinimumWidth = 6;
            this.clmnDagilim.Name = "clmnDagilim";
            this.clmnDagilim.ReadOnly = true;
            // 
            // clmnDerslik
            // 
            this.clmnDerslik.HeaderText = "Derslik";
            this.clmnDerslik.MinimumWidth = 6;
            this.clmnDerslik.Name = "clmnDerslik";
            this.clmnDerslik.ReadOnly = true;
            // 
            // frmAtananDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 595);
            this.Controls.Add(this.dgwAtananDersler);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAtananDersler";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atanan Dersler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAtananDersler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwAtananDersler;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnKart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOgretmen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSinif;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDagilim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnDerslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnYeniDers;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblImage;
    }
}