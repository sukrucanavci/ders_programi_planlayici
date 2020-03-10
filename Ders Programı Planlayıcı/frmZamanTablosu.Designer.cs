namespace Ders_Programı_Planlayıcı
{
    partial class frmZamanTablosu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblUygun = new System.Windows.Forms.Label();
            this.lblUygunOlmayan = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.dgwZaman = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwZaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUygun
            // 
            this.lblUygun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUygun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUygun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUygun.Location = new System.Drawing.Point(76, 468);
            this.lblUygun.Name = "lblUygun";
            this.lblUygun.Size = new System.Drawing.Size(96, 50);
            this.lblUygun.TabIndex = 1;
            this.lblUygun.Text = "Uygun";
            this.lblUygun.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUygunOlmayan
            // 
            this.lblUygunOlmayan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUygunOlmayan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUygunOlmayan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUygunOlmayan.Location = new System.Drawing.Point(242, 468);
            this.lblUygunOlmayan.Name = "lblUygunOlmayan";
            this.lblUygunOlmayan.Size = new System.Drawing.Size(165, 50);
            this.lblUygunOlmayan.TabIndex = 2;
            this.lblUygunOlmayan.Text = "Uygun Olmayan";
            this.lblUygunOlmayan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTamam
            // 
            this.btnTamam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTamam.Location = new System.Drawing.Point(467, 475);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(220, 49);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // dgwZaman
            // 
            this.dgwZaman.AllowUserToAddRows = false;
            this.dgwZaman.AllowUserToDeleteRows = false;
            this.dgwZaman.AllowUserToResizeColumns = false;
            this.dgwZaman.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwZaman.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwZaman.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwZaman.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwZaman.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgwZaman.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwZaman.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwZaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwZaman.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgwZaman.GridColor = System.Drawing.Color.Black;
            this.dgwZaman.Location = new System.Drawing.Point(13, 12);
            this.dgwZaman.MultiSelect = false;
            this.dgwZaman.Name = "dgwZaman";
            this.dgwZaman.ReadOnly = true;
            this.dgwZaman.RowHeadersWidth = 100;
            this.dgwZaman.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwZaman.RowTemplate.Height = 100;
            this.dgwZaman.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgwZaman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwZaman.Size = new System.Drawing.Size(674, 450);
            this.dgwZaman.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ders_Programı_Planlayıcı.Properties.Resources.evet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 468);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Ders_Programı_Planlayıcı.Properties.Resources.hayir;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(178, 468);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmZamanTablosu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 539);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgwZaman);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.lblUygunOlmayan);
            this.Controls.Add(this.lblUygun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmZamanTablosu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaman Tablosu - ";
            ((System.ComponentModel.ISupportInitialize)(this.dgwZaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUygun;
        private System.Windows.Forms.Label lblUygunOlmayan;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.DataGridView dgwZaman;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}