using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmSaat : Form
    {
        public frmSaat()
        {
            InitializeComponent();
        }

        private void frmSaat_Load(object sender, EventArgs e)
        {
            dgwDersSaatleri.DataSource = frmAna.dtDersSaatleri;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            Form frmGuncelle = new Form()
            {
                Text = "Güncelle",
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                StartPosition = FormStartPosition.CenterScreen,
                Size = new Size(280, 73),
            };

            TextBox t = new TextBox()
            {
                Text = dgwDersSaatleri.SelectedCells[0].Value.ToString(),
                Size = new Size(150, 30),
                Location = new Point(5, 5)
            };

            Button b = new Button()
            {
                Text = "Tamam",
                Size = new Size(100, 22),
                Location = new Point(t.Right + 3, t.Top)
            };

            b.Click += new EventHandler(Guncelle);

            void Guncelle(object sndr, EventArgs a)
            {
                dgwDersSaatleri.SelectedCells[0].Value = t.Text;
                frmGuncelle.Close();
            }

            frmGuncelle.Controls.AddRange(new Control[] { t, b });
            frmGuncelle.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
