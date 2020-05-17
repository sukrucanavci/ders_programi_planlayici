namespace Ders_Programı_Planlayıcı
{
    partial class frmSaat
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.dgwDersSaatleri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersSaatleri)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(401, 13);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(158, 35);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(401, 54);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(158, 35);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.BackColor = System.Drawing.Color.White;
            this.btnTamam.Location = new System.Drawing.Point(402, 331);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(158, 35);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = false;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // dgwDersSaatleri
            // 
            this.dgwDersSaatleri.AllowUserToAddRows = false;
            this.dgwDersSaatleri.AllowUserToDeleteRows = false;
            this.dgwDersSaatleri.AllowUserToResizeColumns = false;
            this.dgwDersSaatleri.AllowUserToResizeRows = false;
            this.dgwDersSaatleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwDersSaatleri.BackgroundColor = System.Drawing.Color.White;
            this.dgwDersSaatleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDersSaatleri.Location = new System.Drawing.Point(12, 13);
            this.dgwDersSaatleri.MultiSelect = false;
            this.dgwDersSaatleri.Name = "dgwDersSaatleri";
            this.dgwDersSaatleri.ReadOnly = true;
            this.dgwDersSaatleri.RowHeadersVisible = false;
            this.dgwDersSaatleri.RowHeadersWidth = 51;
            this.dgwDersSaatleri.RowTemplate.Height = 24;
            this.dgwDersSaatleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwDersSaatleri.Size = new System.Drawing.Size(383, 353);
            this.dgwDersSaatleri.TabIndex = 6;
            // 
            // frmSaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 378);
            this.Controls.Add(this.dgwDersSaatleri);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSaat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Saatleri";
            this.Load += new System.EventHandler(this.frmSaat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDersSaatleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.DataGridView dgwDersSaatleri;
    }
}