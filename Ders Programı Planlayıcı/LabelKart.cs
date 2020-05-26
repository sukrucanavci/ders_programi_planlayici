using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public class LabelKart:Label
    {
        DersBlogu db;
        public frmAna frmAna;
        public bool eklendi = false;

        public int genislik
        {
            set
            {
                Size = new Size(value * db.uzunluk, 30);
            }
        }

        public LabelKart(DersBlogu dersBlogu)
        {
            frmAna = (frmAna)Application.OpenForms["frmAna"];
            db = dersBlogu;

            Size = new Size(Width * dersBlogu.uzunluk, 30);
            Margin = new Padding(0);
            Dock = DockStyle.Fill;
            //BorderStyle = BorderStyle.FixedSingle;
            Text = db.atananDers.ders.kod;

            Label lab = new Label()
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Text = db.atananDers.ders.kod,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            Controls.Add(lab);

            lab.MouseClick += new MouseEventHandler(Kart_MouseClick);
            lab.MouseHover += new EventHandler(Kart_MouseHover);
            lab.MouseLeave += new EventHandler(Kart_MouseLeave);
            Paint += new PaintEventHandler(Kart_Paint);
        }

        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        public static Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }

        void Kart_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                frmAna.LabelleriBeyazlat();
                return;
            }

            if (this.Parent == frmAna.tlpSiniflar)
            {
                frmAna.LabelleriBeyazlat();
                frmAna.seciliDB = db;

                foreach (var kart in db.sinifKartlar)
                {
                    frmAna.flpSiniflar.Controls.Add(kart);
                    kart.Hide();
                }

                ///// EK

                foreach (var kart in db.ogretmenKartlar)
                {
                    frmAna.flpOgretmenler.Controls.Add(kart);
                    kart.Dock = DockStyle.None;
                    kart.Hide();
                }

                //db.ogretmenKartlar[0].Show();
                //db.ogretmenKartlar[0].Margin = new Padding(1);


                foreach (var kart in db.derslikKartlar)
                {
                    frmAna.flpDerslikler.Controls.Add(kart);
                    kart.Dock = DockStyle.None;
                    kart.Hide();
                }

                //db.derslikKartlar[0].Show();
                //db.derslikKartlar[0].Margin = new Padding(1);

                /////

                Dock = DockStyle.None;
                this.Show();


                this.Margin = new Padding(1);

                Bitmap bmp = new Bitmap(30, 30);
                using (Graphics gfx = Graphics.FromImage(bmp))
                using (SolidBrush brush = new SolidBrush(db.atananDers.ogretmenler[0].renk))
                {
                    gfx.FillRectangle(brush, 0, 0, 30, 30);
                    if (Text.Length > 3)
                    {
                        RectangleF rectf = new RectangleF(0, 0, 30, 30);
                        gfx.DrawString(Text, Font, Brushes.Black, rectf);
                    }
                    else
                    {
                        StringFormat sf = new StringFormat();
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Center;
                        PointF pf = new PointF(15, 15);
                        gfx.DrawString(Text, Font, Brushes.Black, pf, sf);
                    }
                }
                frmAna.tlpSiniflar.Cursor = CreateCursor(bmp, 5, 5);

                
                for (int i = db.saat; i < db.saat + db.uzunluk; i++)
                {
                    foreach (var derslik in db.atananDers.derslikler)
                    { derslik.bosSaatler[db.gun, i] = true; }

                    foreach (var ogretmen in db.atananDers.ogretmenler)
                    { ogretmen.bosSaatler[db.gun, i] = true; }

                    foreach (var sinif in db.atananDers.siniflar)
                    { sinif.bosSaatler[db.gun, i] = true; }
                }

                int s = ((db.gun * frmAna.gunlukDersSayisi) + db.saat);
                foreach (var sinif in db.atananDers.siniflar)
                {
                    for (int i = s; i < s + db.uzunluk; i++)
                        frmAna.dbSinif[frmAna.siniflar.IndexOf(sinif), i] = null;
                }
                ////EK
                foreach (var ogretmen in db.atananDers.ogretmenler)
                {
                    for (int i = s; i < s + db.uzunluk; i++)
                        frmAna.dbOgretmen[frmAna.ogretmenler.IndexOf(ogretmen), i] = null;
                }
                foreach (var derslik in db.atananDers.derslikler)
                {
                    for (int i = s; i < s + db.uzunluk; i++)
                        frmAna.dbDerslik[frmAna.derslikler.IndexOf(derslik), i] = null;
                }
                ////

                //Yeşillendirme
                for (int i = 0; i < frmAna.gunSayisi; i++)
                {
                    for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                    {
                        if (j + db.uzunluk > frmAna.gunlukDersSayisi) { continue; }

                        if (frmAna.BosZamanlariKontrolEt(db, i, j))
                        {
                            foreach (var sinif in db.atananDers.siniflar)
                            {
                                frmAna.tlpSiniflar.GetControlFromPosition(0, frmAna.siniflar.IndexOf(sinif) + 2).BackColor = Color.Lime;
                                frmAna.tlpSiniflar.GetControlFromPosition(i*frmAna.gunlukDersSayisi+j+1, 1).BackColor = Color.Lime;
                            }
                        }
                    }
                }
            }
            else if (this.Parent == frmAna.flpSiniflar)
            {
                frmAna.seciliDB = db;

                Bitmap bmp = new Bitmap(30, 30);
                using (Graphics gfx = Graphics.FromImage(bmp))
                using (SolidBrush brush = new SolidBrush(db.atananDers.ogretmenler[0].renk))
                {
                    gfx.FillRectangle(brush, 0, 0, 30, 30);
                    if (Text.Length > 3)
                    {
                        RectangleF rectf = new RectangleF(0, 0, 30, 30);
                        gfx.DrawString(Text, Font, Brushes.Black, rectf);
                    }
                    else
                    {
                        StringFormat sf = new StringFormat();
                        sf.LineAlignment = StringAlignment.Center;
                        sf.Alignment = StringAlignment.Center;
                        PointF pf = new PointF(15, 15);
                        gfx.DrawString(Text, Font, Brushes.Black, pf, sf);
                    }
                }
                frmAna.tlpSiniflar.Cursor = CreateCursor(bmp, 5, 5);

                //yeşil yapma olayı
                for (int i = 0; i < frmAna.gunSayisi; i++)
                {
                    for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                    {
                        if (j + db.uzunluk > frmAna.gunlukDersSayisi) { continue; }

                        if (frmAna.BosZamanlariKontrolEt(db, i, j))
                        {
                            foreach (var sinif in db.atananDers.siniflar)
                            {
                                frmAna.tlpSiniflar.GetControlFromPosition(0, frmAna.siniflar.IndexOf(sinif) + 2).BackColor = Color.Lime;
                                frmAna.tlpSiniflar.GetControlFromPosition(i * frmAna.gunlukDersSayisi + j + 1, 1).BackColor = Color.Lime;
                            }
                        }
                    }
                }
            }

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

            if (db.atananDers.derslikler.Count == 1)
            {
                frmAna.lblDerslik.Text = db.atananDers.derslikler[0].ad;
            }
            else
            {
                foreach (var derslik in db.atananDers.derslikler)
                {
                    frmAna.lblDerslik.Text += derslik.kod + " ";
                }
            }

            if (db.atananDers.ogretmenler.Count == 1)
            {
                frmAna.lblOgretmen.Text = db.atananDers.ogretmenler[0].ad + " " + db.atananDers.ogretmenler[0].soyad;
            }
            else
            {
                foreach (var ogretmen in db.atananDers.ogretmenler)
                {
                    frmAna.lblOgretmen.Text += ogretmen.kod + " ";
                }
            }

            if (db.atananDers.siniflar.Count == 1)
            {
                frmAna.lblSinif.Text = db.atananDers.siniflar[0].ad;
            }
            else
            {
                foreach (var sinif in db.atananDers.siniflar)
                {
                    frmAna.lblSinif.Text += sinif.kod + " ";
                }
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
