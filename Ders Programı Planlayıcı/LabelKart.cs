using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public class LabelKart:Label
    {
        DersBlogu db;
        public frmAna frmAna;

        public int genislik
        {
            set
            {
                this.Width = value;
            }
        }

        public LabelKart(DersBlogu dersBlogu)
        {
            frmAna = (frmAna)Application.OpenForms["frmAna"];
            db = dersBlogu;
            Size = new Size(200 * dersBlogu.uzunluk, 30);
            Margin = new Padding(0);
            BorderStyle = BorderStyle.FixedSingle;

            Label tb = new Label()
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Text = db.atananDers.ders.kod,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            Controls.Add(tb);

            tb.MouseHover += new EventHandler(Kart_MouseHover);
            tb.MouseLeave += new EventHandler(Kart_MouseLeave);
            Paint += new PaintEventHandler(Kart_Paint);
        }

        void Kart_Paint(object sender, PaintEventArgs e)
        {
            int count = db.atananDers.ogretmenler.Count;
            int width = Width / count;

            if (count == 1)
            {
                LinearGradientBrush brush = new LinearGradientBrush(
                    new Rectangle(0, 0, Width, Height), Color.White,
                    db.atananDers.ogretmenler[0].renk, LinearGradientMode.Vertical);

                e.Graphics.FillRectangle(brush, 0, 0, Width, Height);
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    var brush = new SolidBrush(db.atananDers.ogretmenler[i].renk);
                    e.Graphics.FillRectangle(brush, width * i, 0, width, Height);
                }
            }
        }

        void Kart_MouseHover(object sender, EventArgs e)
        {
            frmAna.lblDers.Text = db.atananDers.ders.ad;
            foreach (var derslik in db.atananDers.derslikler)
            {
                frmAna.lblDerslik.Text += derslik.kod + " ";
            }
            foreach (var ogretmen in db.atananDers.ogretmenler)
            {
                frmAna.lblOgretmen.Text += ogretmen.kod + " ";
            }
            foreach (var sinif in db.atananDers.siniflar)
            {
                frmAna.lblSinif.Text += sinif.kod + " ";
            }

            frmAna.lblEtiket.Controls.Add(new LabelKart(db));
            frmAna.lblEtiket.Controls[0].Dock = DockStyle.Fill;
        }

        void Kart_MouseLeave(object sender, EventArgs e)
        {
            frmAna.lblEtiket.Controls.Clear();
            frmAna.lblDers.Text = "";
            frmAna.lblDerslik.Text = "";
            frmAna.lblOgretmen.Text = "";
            frmAna.lblSinif.Text = "";
        }
    }
}
