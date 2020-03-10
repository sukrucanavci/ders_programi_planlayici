namespace Ders_Programı_Planlayıcı
{
    partial class frmGunler
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
            this.lvwGunler = new System.Windows.Forms.ListView();
            this.clmnGunIndex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnGunler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwGunler
            // 
            this.lvwGunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnGunIndex,
            this.clmnGunler});
            this.lvwGunler.FullRowSelect = true;
            this.lvwGunler.HideSelection = false;
            this.lvwGunler.Location = new System.Drawing.Point(12, 12);
            this.lvwGunler.MultiSelect = false;
            this.lvwGunler.Name = "lvwGunler";
            this.lvwGunler.Size = new System.Drawing.Size(328, 337);
            this.lvwGunler.TabIndex = 0;
            this.lvwGunler.UseCompatibleStateImageBehavior = false;
            this.lvwGunler.View = System.Windows.Forms.View.Details;
            // 
            // clmnGunIndex
            // 
            this.clmnGunIndex.Text = "";
            this.clmnGunIndex.Width = 55;
            // 
            // clmnGunler
            // 
            this.clmnGunler.Text = "Günler";
            this.clmnGunler.Width = 157;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(12, 355);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(162, 43);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.White;
            this.btnTamam.Location = new System.Drawing.Point(178, 355);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(162, 43);
            this.btnTamam.TabIndex = 4;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // frmGunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 407);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.lvwGunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Günler";
            this.Load += new System.EventHandler(this.frmGunler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwGunler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ColumnHeader clmnGunIndex;
        private System.Windows.Forms.ColumnHeader clmnGunler;
        private System.Windows.Forms.Button btnTamam;
    }
}