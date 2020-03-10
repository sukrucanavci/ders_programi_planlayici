namespace Ders_Programı_Planlayıcı
{
    partial class frmKisitlamaOgretmen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTumuneUygula = new System.Windows.Forms.Button();
            this.nudMaxDersGunu = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOgretmenAdSoyad = new System.Windows.Forms.Label();
            this.lblTDS = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDersGunu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretmen Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Ders Saati";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnTumuneUygula);
            this.groupBox1.Controls.Add(this.nudMaxDersGunu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(13, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 154);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ders Günlerinin Sayısını Sınırla";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(9, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(283, 75);
            this.label12.TabIndex = 3;
            this.label12.Text = "Bu öğretmenin ders verebileceği günleri sınırlayabilirsiniz. Eğer mümkünse bu kıs" +
    "ıtlama uygulanır.";
            // 
            // btnTumuneUygula
            // 
            this.btnTumuneUygula.Location = new System.Drawing.Point(291, 36);
            this.btnTumuneUygula.Name = "btnTumuneUygula";
            this.btnTumuneUygula.Size = new System.Drawing.Size(227, 35);
            this.btnTumuneUygula.TabIndex = 2;
            this.btnTumuneUygula.Text = "Tüm Öğretmenlere Uygula";
            this.btnTumuneUygula.UseVisualStyleBackColor = true;
            this.btnTumuneUygula.Click += new System.EventHandler(this.btnTumuneUygula_Click);
            // 
            // nudMaxDersGunu
            // 
            this.nudMaxDersGunu.Location = new System.Drawing.Point(177, 36);
            this.nudMaxDersGunu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDersGunu.Name = "nudMaxDersGunu";
            this.nudMaxDersGunu.Size = new System.Drawing.Size(71, 22);
            this.nudMaxDersGunu.TabIndex = 1;
            this.nudMaxDersGunu.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxDersGunu.ValueChanged += new System.EventHandler(this.nudMaxDersGunu_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kısıtlama: Ders Günü";
            // 
            // lblOgretmenAdSoyad
            // 
            this.lblOgretmenAdSoyad.AutoSize = true;
            this.lblOgretmenAdSoyad.Location = new System.Drawing.Point(163, 13);
            this.lblOgretmenAdSoyad.Name = "lblOgretmenAdSoyad";
            this.lblOgretmenAdSoyad.Size = new System.Drawing.Size(142, 17);
            this.lblOgretmenAdSoyad.TabIndex = 3;
            this.lblOgretmenAdSoyad.Text = "lblOgretmenAdSoyad";
            // 
            // lblTDS
            // 
            this.lblTDS.AutoSize = true;
            this.lblTDS.Location = new System.Drawing.Point(163, 40);
            this.lblTDS.Name = "lblTDS";
            this.lblTDS.Size = new System.Drawing.Size(50, 17);
            this.lblTDS.TabIndex = 4;
            this.lblTDS.Text = "lblTDS";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(366, 240);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(179, 40);
            this.btnTamam.TabIndex = 5;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // frmKisitlamaOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 292);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.lblTDS);
            this.Controls.Add(this.lblOgretmenAdSoyad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKisitlamaOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kısıtlama - ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDersGunu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTumuneUygula;
        private System.Windows.Forms.NumericUpDown nudMaxDersGunu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOgretmenAdSoyad;
        private System.Windows.Forms.Label lblTDS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTamam;
    }
}