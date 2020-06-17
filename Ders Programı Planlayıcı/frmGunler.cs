using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmGunler : Form
    {
        public frmGunler()
        {
            InitializeComponent();
        }

        private void frmGunler_Load(object sender, EventArgs e)
        {
            ListViewItem lvwItem;
            for (int i = 0; i < frmAna.secilenGunler.Count; i++)
            {
                lvwItem = new ListViewItem((i + 1).ToString());
                lvwItem.SubItems.Add(frmAna.secilenGunler[i]);
                lvwGunler.Items.Add(lvwItem);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lvwGunler.SelectedItems.Count != 0)
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
                    Text = lvwGunler.SelectedItems[0].SubItems[1].Text,
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
                    lvwGunler.SelectedItems[0].SubItems[1].Text = t.Text;
                    frmAna.secilenGunler[lvwGunler.SelectedItems[0].Index] = t.Text;
                    frmGuncelle.Close();
                }

                frmGuncelle.Controls.AddRange(new Control[] { t, b });
                frmGuncelle.ShowDialog();
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
