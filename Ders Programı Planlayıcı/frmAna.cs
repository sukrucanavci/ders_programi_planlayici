﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmAna : Form
    {
        #region Listeler

        public static List<Sinif> siniflar = new List<Sinif>();
        public static List<Derslik> derslikler = new List<Derslik>();
        public static List<Ogretmen> ogretmenler = new List<Ogretmen>();
        public static List<Ders> dersler = new List<Ders>();
        public static List<AtananDers> atananDersler = new List<AtananDers>();
        public static List<DersBlogu> dersBloklari = new List<DersBlogu>();
        public static List<String> haftaninGunleri = new List<string>(new String[] {
        "Pazartesi",
        "Salı",
        "Çarşamba",
        "Perşembe",
        "Cuma",
        "Cumartesi",
        "Pazar"
        });
        public static List<String> secilenGunler = new List<string>(new String[] {
        "Pazartesi",
        "Salı",
        "Çarşamba",
        "Perşembe",
        "Cuma"
        });
        public static List<Color> renkler = new List<Color>(new Color[]
        {
            Color.Salmon,
            Color.LightSeaGreen,
            Color.Aqua,
            Color.SkyBlue,
            Color.Aquamarine,
            Color.SteelBlue,
            Color.Blue,
            Color.BlueViolet,
            Color.Brown,
            Color.BurlyWood,
            Color.Aqua,
            Color.CadetBlue,
            Color.Lime,
            Color.Coral,
            Color.Crimson,
            Color.DarkGreen,
            Color.Yellow,
            Color.Bisque,
            Color.Lime,
            Color.LimeGreen,
            Color.Linen,
            Color.Magenta,
            Color.MediumAquamarine,
            Color.BurlyWood,
            Color.CadetBlue,
            Color.Chartreuse,
            Color.MediumSeaGreen,
            Color.Coral,
            Color.MediumSpringGreen,
            Color.Cornsilk,
            Color.MediumTurquoise,
            Color.Cyan,
            Color.MintCream,
            Color.MistyRose,
            Color.Moccasin,
            Color.DarkGray,
            Color.NavajoWhite,
            Color.DarkKhaki,
            Color.OldLace,
            Color.DarkOrange,
            Color.Orange,
            Color.OrangeRed,
            Color.Orchid,
            Color.DarkSalmon,
            Color.PaleGoldenrod,
            Color.DarkSeaGreen,
            Color.PaleGreen,
            Color.PaleTurquoise,
            Color.PaleVioletRed,
            Color.DarkTurquoise,
            Color.PapayaWhip,
            Color.PeachPuff,
            Color.DeepPink,
            Color.Peru,
            Color.DeepSkyBlue,
            Color.Pink,
            Color.DimGray,
            Color.Plum,
            Color.PowderBlue,
            Color.FloralWhite,
            Color.Fuchsia,
            Color.Gainsboro,
            Color.SaddleBrown,
            Color.GhostWhite,
            Color.Salmon,
            Color.Gold,
            Color.SandyBrown,
            Color.Goldenrod,
            Color.SeaGreen,
            Color.SeaShell,
            Color.Sienna,
            Color.GreenYellow,
            Color.Silver,
            Color.Honeydew,
            Color.SkyBlue,
            Color.HotPink,
            Color.SlateGray,
            Color.Snow,
            Color.Ivory,
            Color.SpringGreen,
            Color.Khaki,
            Color.SteelBlue,
            Color.Lavender,
            Color.Tan,
            Color.LavenderBlush,
            Color.LawnGreen,
            Color.Thistle,
            Color.LemonChiffon,
            Color.LightBlue,
            Color.Turquoise,
            Color.Violet,
            Color.Cyan,
            Color.Wheat,
            Color.LightGoldenrodYellow,
            Color.White,
            Color.LightGreen,
            Color.WhiteSmoke,
            Color.LightGray,
            Color.Yellow,
            Color.LightPink,
            Color.YellowGreen
        });
        public static List<String> dagilimSekilleri = new List<String>(new String[]
        {
            "1",
            "2",
            "1+1",
            "3",
            "1+1+1",
            "2+1",
            "4",
            "2+2",
            "3+2",
            "2+2+1",
            "3+3",
            "2+2+2",
            "4+3",
            "4+4"
        });

        List<int> gunler = new List<int>();
        List<int> saatler = new List<int>();

        #endregion

        #region Fields and Properties

        public static string server;
        public static string veritabani;
        public static string kullaniciAdi;
        public static string sifre;
        public static bool winAuto;

        public static bool ogleArasiVar = false;
        public static bool ogleArasiBlokDersleriBolebilir = false;
        public static int ogleArasiKacinciDerstenSonra = 0;

        public static int gunSayisi = 0;
        private static int GunlukDersSayisi = 0;
        public static int gunlukDersSayisi
        {
            get { return GunlukDersSayisi; }

            set
            {
                GunlukDersSayisi = value;

                int baslangicsaati = 8;
                if (dtDersSaatleri.Rows.Count < value)
                {
                    for (int saat = dtDersSaatleri.Rows.Count + 1; saat <= value; saat++)
                    {
                        DataRow dr = dtDersSaatleri.NewRow();
                        dr[0] = saat;
                        dr[1] = baslangicsaati + ":00";
                        dr[2] = baslangicsaati + ":45";
                        baslangicsaati++;
                        dtDersSaatleri.Rows.Add(dr);
                    }
                }
                else if (dtDersSaatleri.Rows.Count > value)
                {
                    while (dtDersSaatleri.Rows.Count != value)
                        dtDersSaatleri.Rows.RemoveAt(dtDersSaatleri.Rows.Count - 1);
                }
            }
        }

        #endregion

        #region Ders Bloğu Matrisleri

        /// <summary>
        /// Ders bloklarını sınıfa göre tutan matris
        /// </summary>
        public static DersBlogu[,] dbSinif;
        /// <summary>
        /// Ders bloklarını öğretmene göre tutan matris
        /// </summary>
        public static DersBlogu[,] dbOgretmen;
        /// <summary>
        /// Ders bloklarını dersliğe göre tutan matris
        /// </summary>
        public static DersBlogu[,] dbDerslik;

        #endregion

        public static System.Data.DataTable dtDersSaatleri;
        public static frmParametre frmParametre = new frmParametre();
        public static DersBlogu seciliDB = null;

        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Shown(object sender, EventArgs e)
        {
            for (int i = tabControl1.TabPages.Count; i >= 0; i--)
            {
                tabControl1.SelectedIndex = i;
            }
        }

        private void frmAna_Load(object sender, EventArgs e)
        {  
            tsbOnceKontrol.Text = "Planlama Öncesi\nKontrol";
            tsbPlanlama.Text = "Otomatik Planlamayı\nBaşlat";
            tsbSonraKontrol.Text = "Planlama Sonrası\nKontrol";
            tsbYeni.Text = "Yeni Veritabanı\nOluştur";
            //Ders saatleri
            dtDersSaatleri = new System.Data.DataTable("ders_saatleri");
            dtDersSaatleri.Columns.AddRange(new DataColumn[] 
            {
                new DataColumn("Ders Saati"),
                new DataColumn("Başlangıç"),
                new DataColumn("Bitiş")
            });

            //Parametrelerin girilmesi için frmParametreyi başlattım
            frmParametre.ShowDialog();

            this.WindowState = FormWindowState.Maximized;
        }

        int yerlestirilen = 0;
        int anafonktur = 0;

        /// <summary>
        /// Ana fonksiyon, ön kontrolü ve düzenlemeleri yapar. Daha sonra algoritmayı çalıştırır
        /// </summary>
        void AnaFonk()
        {
            #region Kontrol ve Fabrika Ayarı İşlemleri

            if (!Kontrol()) { return; }

            //doluluk
            foreach (var db in dersBloklari)
            {
                int doluluk = 0;

                for (int i = 0; i < db.atananDers.ders.uygunZamanlar.GetLength(0); i++)
                {
                    for (int j = 0; j < db.atananDers.ders.uygunZamanlar.GetLength(1); j++)
                    {
                        if (db.atananDers.ders.uygunZamanlar[i, j] == false)
                        {
                            doluluk++;
                        }
                    }
                }
                foreach (var derslik in db.atananDers.derslikler)
                {
                    for (int i = 0; i < derslik.uygunZamanlar.GetLength(0); i++)
                    {
                        for (int j = 0; j < derslik.uygunZamanlar.GetLength(1); j++)
                        {
                            if (derslik.uygunZamanlar[i,j] == false)
                            {
                                doluluk++;
                            }
                        }
                    }
                }
                foreach (var ogretmen in db.atananDers.ogretmenler)
                {
                    for (int i = 0; i < ogretmen.uygunZamanlar.GetLength(0); i++)
                    {
                        for (int j = 0; j < ogretmen.uygunZamanlar.GetLength(1); j++)
                        {
                            if (ogretmen.uygunZamanlar[i, j] == false)
                            {
                                doluluk++;
                            }
                        }
                    }
                }
                foreach (var sinif in db.atananDers.siniflar)
                {
                    for (int i = 0; i < sinif.uygunZamanlar.GetLength(0); i++)
                    {
                        for (int j = 0; j < sinif.uygunZamanlar.GetLength(1); j++)
                        {
                            if (sinif.uygunZamanlar[i, j] == false)
                            {
                                doluluk++;
                            }
                        }
                    }
                }

                db.doluluk = doluluk;
            }

            dersBloklari.Sort((x, y) => y.doluluk.CompareTo(x.doluluk));

            gunler.Clear(); for (int gun = 0; gun < gunSayisi; gun++) { gunler.Add(gun); }
            saatler.Clear(); for (int saat = 0; saat < gunlukDersSayisi; saat++) { saatler.Add(saat); }

            int counter = 0;
            foreach (var db in dersBloklari) 
            {
                db.eklendi = false;
                db.gun = -1;
                db.saat = -1;
                db.dksayac = 0;
                foreach (Ogretmen ogretmen in db.atananDers.ogretmenler)
                {
                    ogretmen.oksayac = 0;
                }
                foreach (var kart in db.sinifKartlar)
                {
                    kart.eklendi = false;
                }
                foreach (var kart in db.ogretmenKartlar)
                {
                    kart.eklendi = false;
                }
                foreach (var kart in db.derslikKartlar)
                {
                    kart.eklendi = false;
                }
            }

            #endregion

            while (dersBloklari.Any(db => db.eklendi == false))
            {
                foreach (var db in dersBloklari) { db.eklendi = false; }

                yerlestirilen = 0;
                counter++;
                int sutunAdeti = gunSayisi * gunlukDersSayisi;
                dbSinif = new DersBlogu[siniflar.Count, sutunAdeti];
                dbDerslik = new DersBlogu[derslikler.Count, sutunAdeti];
                dbOgretmen = new DersBlogu[ogretmenler.Count, sutunAdeti];

                for (int i = 0; i < gunSayisi; i++)
                {
                    for (int j = 0; j < gunlukDersSayisi; j++)
                    {
                        foreach (var ogretmen in ogretmenler)
                            ogretmen.bosSaatler[i, j] = ogretmen.uygunZamanlar[i, j];

                        foreach (var derslik in derslikler)
                            derslik.bosSaatler[i, j] = derslik.uygunZamanlar[i, j];

                        foreach (var sinif in siniflar)
                            sinif.bosSaatler[i, j] = sinif.uygunZamanlar[i, j];
                    }
                }

                foreach (var dersBlogu in dersBloklari)
                {
                    Algoritma(dersBlogu, true, true);
                }

                while (dersBloklari.Any(db => db.eklendi == false))
                {
                    counter++;
                    foreach (var eklenemeyenDB in dersBloklari.Where(db => db.eklendi == false))
                    {
                        foreach (var gun in gunler.ToList())
                        {
                            foreach (var saat in saatler.ToList())
                            {
                                if (saat + eklenemeyenDB.uzunluk > gunlukDersSayisi) { continue; }
                                if (eklenemeyenDB.uzunluk > 1) { if (OgleArasiKontrol(eklenemeyenDB, saat)) { continue; } }

                                if (UygunZamanlariKontrolEt(eklenemeyenDB, gun, saat))
                                {
                                    int s = ((gun * saatler.Count) + saat);
                                    DersBlogu hedefDersBlogu = dbSinif[siniflar.IndexOf(eklenemeyenDB.atananDers.siniflar[0]), s];
                                    if (hedefDersBlogu == null) { continue; }
                                    int hgun = hedefDersBlogu.gun;
                                    int hsaat = hedefDersBlogu.saat;
                                    if (Algoritma(hedefDersBlogu, true, true))
                                    {
                                        for (int i = hsaat; i < hsaat + hedefDersBlogu.uzunluk; i++)
                                        {
                                            foreach (var derslik in hedefDersBlogu.atananDers.derslikler)
                                            { derslik.bosSaatler[hgun, i] = true; }

                                            foreach (var ogretmen in hedefDersBlogu.atananDers.ogretmenler)
                                            { ogretmen.bosSaatler[hgun, i] = true; }

                                            foreach (var sinif in hedefDersBlogu.atananDers.siniflar)
                                            { sinif.bosSaatler[hgun, i] = true; }
                                        }

                                        foreach (var sinif in hedefDersBlogu.atananDers.siniflar)
                                        {
                                            for (int i = s; i < s + hedefDersBlogu.uzunluk; i++)
                                            {
                                                dbSinif[siniflar.IndexOf(sinif), i] = null;
                                            }
                                        }
                                        foreach (var ogretmen in hedefDersBlogu.atananDers.ogretmenler)
                                        {
                                            for (int i = s; i < s + hedefDersBlogu.uzunluk; i++)
                                            {
                                                dbOgretmen[ogretmenler.IndexOf(ogretmen), i] = null;
                                            }
                                        }
                                        foreach (var derslik in hedefDersBlogu.atananDers.derslikler)
                                        {
                                            for (int i = s; i < s + hedefDersBlogu.uzunluk; i++)
                                            {
                                                dbDerslik[derslikler.IndexOf(derslik), i] = null;
                                            }
                                        }

                                        Algoritma(eklenemeyenDB, false, false);
                                        yerlestirilen--;
                                        goto digerEklenemeyenBlogaGec;
                                    }
                                }
                            }
                        }

                    digerEklenemeyenBlogaGec:;
                    }
                    if (counter > dersBloklari.Count * 10)
                    {
                        break;
                    }
                }
                if (counter > dersBloklari.Count * 10)
                {
                    anafonktur++;
                    //AnaFonk();
                    return;
                }

            }

            lblBasari.Text = "  " + yerlestirilen + "/" + dersBloklari.Count;
            lblTur.Text = counter.ToString();

            #region TableLayoutPanel İşlemleri

            Thread t1 = new Thread(TLPSinifWorker);
            t1.Start();

            Thread t2 = new Thread(TLPOgretmenWorker);
            t2.Start();

            Thread t3 = new Thread(TLPDerslikWorker);
            t3.Start();

            #endregion

            #region FlowLayoutPanel İşlemleri

            int sutun = gunSayisi * GunlukDersSayisi + 1;
            int w = tlpSiniflar.Width / sutun;
            flpSiniflar.Controls.Clear(); //BUG OLABİLİR
            foreach (var db in dersBloklari)
            {
                if (db.eklendi == false)
                {
                    db.kart1.genislik = w * db.uzunluk;
                    flpSiniflar.Controls.Add(db.kart1);
                    flpOgretmenler.Controls.Add(db.kart2);
                    flpDerslikler.Controls.Add(db.kart3);
                }
            }

            #endregion

            #region ListView İşlemleri

            lvwBasarisizlar.Items.Clear();

            ListViewItem item;
            List<int> guns = new List<int>();

            foreach (var atananDers in atananDersler)
            {
                foreach (var dersBlogu in atananDers.dersBloklari)
                {  
                    foreach (var gun in guns)
                    {
                        if (dersBlogu.gun == gun && dersBlogu.atananDers.ders.kisitlama == 
                            Ders.DagilimKisitlamasi.bloklarTumGunlereDagitilmali)
                        {
                            item = new ListViewItem(new string[] {
                                atananDers.ders.ad, "Ders Kartlarının Günlere Dağılımı:" + atananDers.ders.kisitlama
                            }, 0, Color.Black, Color.White, default);

                            lvwBasarisizlar.Items.Add(item);
                        }
                    }
                    guns.Add(dersBlogu.gun);
                }
                guns.Clear();
            }

            #endregion
        }

        /// <summary>
        /// TableLayoutPanel Sınıf
        /// </summary>
        void TLPSinifWorker()
        {
            tlpSiniflar.Invoke((MethodInvoker)delegate {

                tlpSiniflar.Hide();
                tlpSiniflar.ResumeLayout();

                tlpSiniflar.Controls.Clear();
                tlpSiniflar.ColumnStyles.Clear();
                tlpSiniflar.ColumnCount = 1;
                tlpSiniflar.RowStyles.Clear();
                tlpSiniflar.RowCount = 1;

                int sutun = gunSayisi * GunlukDersSayisi;
                int w = tlpSiniflar.Width / sutun - 2;
                for (int i = 0; i < sutun; i++)
                {
                    tlpSiniflar.ColumnCount++;
                    tlpSiniflar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, w));
                }

                tlpSiniflar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpSiniflar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpSiniflar.RowCount++;

                Label label;

                for (int i = 0; i < gunSayisi; i++)
                {
                    label = new Label()
                    {
                        Margin = new Padding(0),
                        BackColor = Color.White,
                        Text = secilenGunler[i],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(w * gunlukDersSayisi, 30)
                    };
                    tlpSiniflar.Controls.Add(label, (i * gunlukDersSayisi) + 1, 0);
                    tlpSiniflar.SetColumnSpan(label, gunlukDersSayisi);
                    for (int j = 0; j < gunlukDersSayisi; j++)
                    {
                        label = new Label()
                        {
                            Margin = new Padding(0),
                            BackColor = Color.White,
                            Text = (j + 1).ToString(),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Size = new Size(w, 30)
                        };
                        tlpSiniflar.Controls.Add(label, (i * gunlukDersSayisi) + 1 + j, 1);
                    }
                }

                for (int i = 0; i < siniflar.Count; i++)
                {
                    tlpSiniflar.RowCount++;
                    tlpSiniflar.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

                    tlpSiniflar.Controls.Add(new Label()
                    {
                        Margin = new Padding(0),
                        Text = siniflar[i].kod,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Size = new Size(w, 30),
                        //Dock = DockStyle.Fill
                    }, 0, i + 2) ;

                    for (int j = 0; j < sutun; j++)
                    {
                        if (dbSinif[i, j] != null)
                        {
                            foreach (var krt in dbSinif[i, j].sinifKartlar)
                            {
                                krt.frmAna = this;
                                krt.genislik = w;
                            }
                            
                            if (dbSinif[i, j].atananDers.siniflar.Count == 1)
                            {
                                tlpSiniflar.Controls.Add(dbSinif[i, j].kart1, j + 1, i + 2);
                            }
                            else
                            {
                                tlpSiniflar.Controls.Add(dbSinif[i, j].sinifKartlar.Where(kart => kart.eklendi == false).First(), j + 1, i + 2);
                                dbSinif[i, j].sinifKartlar.Where(kart => kart.eklendi == false).First().eklendi = true;
                            }
                            tlpSiniflar.SetColumnSpan(tlpSiniflar.GetControlFromPosition(j + 1, i + 2), dbSinif[i, j].uzunluk);
                        }
                    }
                }
                tlpSiniflar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpSiniflar.RowCount++;
;
                tlpSiniflar.SuspendLayout();
                tlpSiniflar.Show();
            });

        }

        /// <summary>
        /// TableLayoutPanel Öğretmen
        /// </summary>
        void TLPOgretmenWorker()
        {
            tlpOgretmenler.Invoke((MethodInvoker)delegate
            {

                tlpOgretmenler.Hide();
                tlpOgretmenler.ResumeLayout();

                tlpOgretmenler.Controls.Clear();
                tlpOgretmenler.ColumnStyles.Clear();
                tlpOgretmenler.ColumnCount = 1;
                tlpOgretmenler.RowStyles.Clear();
                tlpOgretmenler.RowCount = 1;

                int sutun = gunSayisi * GunlukDersSayisi;
                int w = tlpOgretmenler.Width / sutun - 2;
                for (int i = 0; i < sutun; i++)
                {
                    tlpOgretmenler.ColumnCount++;
                    tlpOgretmenler.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, w));
                }

                tlpOgretmenler.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpOgretmenler.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpOgretmenler.RowCount++;

                Label label;

                for (int i = 0; i < gunSayisi; i++)
                {
                    label = new Label()
                    {
                        Margin = new Padding(0),
                        BackColor = Color.White,
                        Text = secilenGunler[i],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(w * gunlukDersSayisi, 30)
                    };
                    tlpOgretmenler.Controls.Add(label, (i * gunlukDersSayisi) + 1, 0);
                    tlpOgretmenler.SetColumnSpan(label, gunlukDersSayisi);
                    for (int j = 0; j < gunlukDersSayisi; j++)
                    {
                        label = new Label()
                        {
                            Margin = new Padding(0),
                            BackColor = Color.White,
                            Text = (j + 1).ToString(),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Size = new Size(w, 30)
                        };
                        tlpOgretmenler.Controls.Add(label, (i * gunlukDersSayisi) + 1 + j, 1);
                    }
                }

                for (int i = 0; i < ogretmenler.Count; i++)
                {
                    tlpOgretmenler.RowCount++;
                    tlpOgretmenler.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

                    tlpOgretmenler.Controls.Add(new Label()
                    {
                        Margin = new Padding(0),
                        Text = ogretmenler[i].kod,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Size = new Size(w, 30),
                        Dock = DockStyle.Fill
                    }, 0, i + 2);

                    for (int j = 0; j < sutun; j++)
                    {
                        if (dbOgretmen[i, j] != null)
                        {
                            foreach (var krt in dbOgretmen[i, j].ogretmenKartlar)
                            {
                                krt.frmAna = this;
                                krt.genislik = w;
                            }

                            if (dbOgretmen[i, j].atananDers.ogretmenler.Count == 1)
                            {
                                tlpOgretmenler.Controls.Add(dbOgretmen[i, j].kart2, j + 1, i + 2);
                            }
                            else
                            {
                                tlpOgretmenler.Controls.Add(dbOgretmen[i, j].ogretmenKartlar.Where(kart => kart.eklendi == false).First(), j + 1, i + 2);
                                dbOgretmen[i, j].ogretmenKartlar.Where(kart => kart.eklendi == false).First().eklendi = true;
                            }
                            tlpOgretmenler.SetColumnSpan(tlpOgretmenler.GetControlFromPosition(j + 1, i + 2), dbOgretmen[i, j].uzunluk);
                        }
                    }
                }
                tlpOgretmenler.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpOgretmenler.RowCount++;
                ;
                tlpOgretmenler.SuspendLayout();
                tlpOgretmenler.Show();
            });

        }

        /// <summary>
        /// TableLayoutPanel Derslik
        /// </summary>
        void TLPDerslikWorker()
        {
            tlpDerslikler.Invoke((MethodInvoker)delegate
            {
                tlpDerslikler.Hide();
                tlpDerslikler.ResumeLayout();

                tlpDerslikler.Controls.Clear();
                tlpDerslikler.ColumnStyles.Clear();
                tlpDerslikler.ColumnCount = 1;
                tlpDerslikler.RowStyles.Clear();
                tlpDerslikler.RowCount = 1;

                int sutun = gunSayisi * GunlukDersSayisi;
                int w = tlpDerslikler.Width / sutun - 2;
                for (int i = 0; i < sutun; i++)
                {
                    tlpDerslikler.ColumnCount++;
                    tlpDerslikler.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, w));
                }

                tlpDerslikler.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpDerslikler.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpDerslikler.RowCount++;

                Label label;

                for (int i = 0; i < gunSayisi; i++)
                {
                    label = new Label()
                    {
                        Margin = new Padding(0),
                        BackColor = Color.White,
                        Text = secilenGunler[i],
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(w * gunlukDersSayisi, 30)
                    };
                    tlpDerslikler.Controls.Add(label, (i * gunlukDersSayisi) + 1, 0);
                    tlpDerslikler.SetColumnSpan(label, gunlukDersSayisi);
                    for (int j = 0; j < gunlukDersSayisi; j++)
                    {
                        label = new Label()
                        {
                            Margin = new Padding(0),
                            BackColor = Color.White,
                            Text = (j + 1).ToString(),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Size = new Size(w, 30)
                        };
                        tlpDerslikler.Controls.Add(label, (i * gunlukDersSayisi) + 1 + j, 1);
                    }
                }

                for (int i = 0; i < derslikler.Count; i++)
                {
                    tlpDerslikler.RowCount++;
                    tlpDerslikler.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));

                    tlpDerslikler.Controls.Add(new Label()
                    {
                        Margin = new Padding(0),
                        Text = derslikler[i].kod,
                        TextAlign = ContentAlignment.MiddleLeft,
                        Size = new Size(w, 30),
                        Dock = DockStyle.Fill
                    }, 0, i + 2);

                    for (int j = 0; j < sutun; j++)
                    {
                        if (dbDerslik[i, j] != null)
                        {
                            foreach (var krt in dbDerslik[i, j].derslikKartlar)
                            {
                                krt.frmAna = this;
                                krt.genislik = w;
                            }

                            if (dbDerslik[i, j].atananDers.derslikler.Count == 1)
                            {
                                tlpDerslikler.Controls.Add(dbDerslik[i, j].kart3, j + 1, i + 2);
                            }
                            else
                            {
                                tlpDerslikler.Controls.Add(dbDerslik[i, j].derslikKartlar.Where(kart => kart.eklendi == false).First(), j + 1, i + 2);
                                dbDerslik[i, j].derslikKartlar.Where(kart => kart.eklendi == false).First().eklendi = true;
                            }
                            tlpDerslikler.SetColumnSpan(tlpDerslikler.GetControlFromPosition(j + 1, i + 2), dbDerslik[i, j].uzunluk);
                        }
                    }
                }
                tlpDerslikler.RowStyles.Add(new RowStyle(SizeType.Absolute, 20));
                tlpDerslikler.RowCount++;
                ;
                tlpDerslikler.SuspendLayout();
                tlpDerslikler.Show();
            });

        }

        /// <summary>
        /// Atanan dersin yerleştirilen ders bloklarının bulunduğu günlerini kontrol eder, eğer günler çakışırsa true döndürür 
        /// </summary>
        /// <param name="dersBlogu"></param>
        /// <param name="gun"></param>
        /// <returns></returns>
        bool BlokDagilimKisitlamaKontrolu(DersBlogu dersBlogu, int gun)
        {
            if (dersBlogu.atananDers.ders.kisitlama == Ders.DagilimKisitlamasi.bloklarTumGunlereDagitilmali)
            {
                foreach (var db in dersBlogu.atananDers.dersBloklari)
                {
                    foreach (DersBlogu dbOther in db.atananDers.dersBloklari)
                    {
                        if (dbOther.gun == gun)
                        {
                            dersBlogu.dksayac++;
                            if (dersBlogu.dksayac <= 5)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Eğer öğretmenlerden birinin alacağı max ders günü geçilirse true döndürür
        /// </summary>
        /// <param name="dersBlogu"></param>
        /// <param name="gun"></param>
        /// <returns></returns>
        bool OgretmenGunKisitlamaKontrolu(DersBlogu dersBlogu, int gun)
        {
            List<int> gunIndex;

            foreach (Ogretmen ogretmen in dersBlogu.atananDers.ogretmenler)
            {
                if (ogretmen.maxDersGunu*gunlukDersSayisi < ogretmen.tds)
                {
                    break;
                }

                if (ogretmen.maxDersGunu == gunSayisi)
                {
                    break;
                }

                gunIndex = new List<int>();

                for (int i = 0; i < ogretmen.bosSaatler.GetLength(0); i++)
                {
                    for (int j = 0; j < ogretmen.bosSaatler.GetLength(1); j++)
                    {
                        if (ogretmen.bosSaatler[i,j] == false)
                        {
                            if (!gunIndex.Contains(i))
                            {
                                gunIndex.Add(i);
                            }
                            break;
                        }
                    }
                }
                if (!gunIndex.Contains(gun) && gunIndex.Count == ogretmen.maxDersGunu)
                {
                    //return true;
                    ogretmen.oksayac++;
                    if (ogretmen.oksayac <= 500)
                    {
                        return true;
                    }
                }
                if (gunIndex.Count > ogretmen.maxDersGunu)
                {
                    //return true;
                    ogretmen.oksayac++;
                    if (ogretmen.oksayac <= 500)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Algoritma, ders bloklarını verilen kriterlere göre yerleştirir
        /// </summary>
        /// <param name="dersBlogu"></param>
        /// <param name="kisitlalamayiKontrolEt">Ders bloğunun günlere dağılım kontrolü</param>
        bool Algoritma(DersBlogu dersBlogu, bool kisitlalamayiKontrolEt, bool ogretmenMaxGunKontrol)
        {
            Karistir(gunler);
            Karistir(saatler);

            foreach (var gun in gunler)
            {
                if (BlokDagilimKisitlamaKontrolu(dersBlogu, gun) && kisitlalamayiKontrolEt)
                {
                    continue;
                }
                if (OgretmenGunKisitlamaKontrolu(dersBlogu, gun) && ogretmenMaxGunKontrol)
                {
                    continue;
                }

                foreach (var saat in saatler)
                {
                    if (saat + dersBlogu.uzunluk> gunlukDersSayisi) { continue; }
                    if (dersBlogu.uzunluk > 1) { if (OgleArasiKontrol(dersBlogu, saat)) { continue; } }
                    if (!BosZamanlariKontrolEt(dersBlogu, gun, saat)) { continue; }

                    int s = ((gun * saatler.Count) + saat);
                    foreach (var sinif in dersBlogu.atananDers.siniflar)
                    {
                        dbSinif[siniflar.IndexOf(sinif), s] = dersBlogu;
                    }
                    foreach (var ogretmen in dersBlogu.atananDers.ogretmenler)
                    {
                        dbOgretmen[ogretmenler.IndexOf(ogretmen), s] = dersBlogu;
                    }
                    foreach (var derslik in dersBlogu.atananDers.derslikler)
                    {
                        dbDerslik[derslikler.IndexOf(derslik), s] = dersBlogu;
                    }

                    dersBlogu.eklendi = true;
                    dersBlogu.gun = gun;
                    dersBlogu.saat = saat;

                    for (int i = saat; i < saat + dersBlogu.uzunluk; i++)
                    {
                        foreach (var derslik in dersBlogu.atananDers.derslikler)
                        { derslik.bosSaatler[gun, i] = false; }

                        foreach (var ogretmen in dersBlogu.atananDers.ogretmenler)
                        { ogretmen.bosSaatler[gun, i] = false; }

                        foreach (var sinif in dersBlogu.atananDers.siniflar)
                        { sinif.bosSaatler[gun, i] = false; }
                    }
                    yerlestirilen++;
                    return true;
                }
            }
            return false;
        }

        Random rnd = new Random();

        /// <summary>
        /// Verilen listeyi karıştırır
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">List nesnesi</param>
        void Karistir<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        /// <summary>
        /// Dersin, öğretmenlerin, dersliklerin ve sınıfların boş zamanlarını kontrol eder. Eğer uygunsa true döndürür
        /// </summary>
        /// <param name="dersBlogu">Mevcut dersin bir bloğu</param>
        /// <param name="gun">Kontrol edilecek gün</param>
        /// <param name="saat">Kontrol edilecek saat</param>
        /// <returns></returns>
        public bool BosZamanlariKontrolEt(DersBlogu dersBlogu, int gun, int saat)
        {
            for (int i = saat; i < saat + dersBlogu.uzunluk; i++)
            {
                if (!dersBlogu.atananDers.ders.uygunZamanlar[gun, i])
                {
                    return false;
                }
                foreach (Derslik derslik in dersBlogu.atananDers.derslikler)
                {
                    if (!derslik.bosSaatler[gun, i])
                    {
                        return false;
                    }
                }
                foreach (Ogretmen ogretmen in dersBlogu.atananDers.ogretmenler)
                {
                    if (!ogretmen.bosSaatler[gun, i])
                    {
                        return false;
                    }
                }
                foreach (Sinif sinif in dersBlogu.atananDers.siniflar)
                {
                    if (!sinif.bosSaatler[gun, i])
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        /// <summary>
        /// Dersin, öğretmenlerin, dersliklerin ve sınıfların uygun zamanlarını kontrol eder. Eğer uygunsa true döndürür
        /// </summary>
        /// <param name="dersBlogu">Mevcut dersin bir bloğu</param>
        /// <param name="gun">Kontrol edilecek gün</param>
        /// <param name="saat">Kontrol edilecek saat</param>
        /// <returns></returns>
        bool UygunZamanlariKontrolEt(DersBlogu dersBlogu, int gun, int saat)
        {
            for (int i = saat; i < saat + dersBlogu.uzunluk; i++)
            {
                if (!dersBlogu.atananDers.ders.uygunZamanlar[gun, i])
                {
                    return false;
                }
                foreach (Derslik derslik in dersBlogu.atananDers.derslikler)
                {
                    if (!derslik.uygunZamanlar[gun, i])
                    {
                        return false;
                    }
                }
                foreach (Ogretmen ogretmen in dersBlogu.atananDers.ogretmenler)
                {
                    if (!ogretmen.uygunZamanlar[gun, i])
                    {
                        return false;
                    }
                }
                foreach (Sinif sinif in dersBlogu.atananDers.siniflar)
                {
                    if (!sinif.uygunZamanlar[gun, i])
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        /// <summary>
        /// Ders bloğu öğle vaktinde bölünmüyorsa true, bölünüyorsa false değeri döndürür
        /// </summary>
        /// <param name="dersBlogu">Ders Bloğu</param>
        /// <param name="saat">Dersin başlayacağı saat</param>
        /// <returns></returns>
        bool OgleArasiKontrol(DersBlogu dersBlogu, int saat)
        {
            if (ogleArasiVar && !ogleArasiBlokDersleriBolebilir)
            {
                for (int s = saat; s < saat + dersBlogu.uzunluk - 1 ; s++)
                {
                    if (s == ogleArasiKacinciDerstenSonra)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Ön kontrolleri gerçekleştirir. Eğer algoritmanın çalışmasına engel bir durum yoksa true, varsa false döndürür
        /// </summary>
        /// <returns>asd</returns>
        bool Kontrol()
        {
            foreach (var sinif in siniflar)
            {
                int uygunSaatSayisi = 0;
                for (int i = 0; i < sinif.uygunZamanlar.GetLength(0); i++)
                {
                    for (int j = 0; j < sinif.uygunZamanlar.GetLength(1); j++)
                    {
                        if (sinif.uygunZamanlar[i, j] == true)
                        {
                            uygunSaatSayisi++;
                        }
                    }
                }
                if (sinif.tds > uygunSaatSayisi)
                {
                    MessageBox.Show(sinif.ad + " sınıfının " + uygunSaatSayisi
                        + " saat uygun zamanı var ama toplam " + sinif.tds + " saatlik ders atanmış!");
                    return false;
                }
            }

            foreach (var derslik in derslikler)
            {
                int uygunSaatSayisi = 0;
                for (int i = 0; i < derslik.uygunZamanlar.GetLength(0); i++)
                {
                    for (int j = 0; j < derslik.uygunZamanlar.GetLength(1); j++)
                    {
                        if (derslik.uygunZamanlar[i, j] == true)
                        {
                            uygunSaatSayisi++;
                        }
                    }
                }
                if (derslik.tds > uygunSaatSayisi)
                {
                    MessageBox.Show(derslik.ad + " dersliğinin " + uygunSaatSayisi
                        + " saat uygun zamanı var ama toplam " + derslik.tds + " saatlik ders atanmış!");
                    return false;
                }
            }

            foreach (var ogretmen in ogretmenler)
            {
                int uygunSaatSayisi = 0;
                for (int i = 0; i < ogretmen.uygunZamanlar.GetLength(0); i++)
                {
                    for (int j = 0; j < ogretmen.uygunZamanlar.GetLength(1); j++)
                    {
                        if (ogretmen.uygunZamanlar[i, j] == true)
                        {
                            uygunSaatSayisi++;
                        }
                    }
                }
                if (ogretmen.tds > uygunSaatSayisi)
                {
                    MessageBox.Show(ogretmen.ad + " " + ogretmen.soyad + " adlı öğretmenin " + uygunSaatSayisi
                        + " saat uygun zamanı var ama toplam " + ogretmen.tds + " saatlik ders atanmış!");
                    return false;
                }
            }

            return true;
        }


        #region Üst Paneldeki kontrol nesnelerinin işlemleri

        frmVeriler frmVeriler;

        private void tsbOnizle_Click(object sender, EventArgs e)
        {
            frmDersProgramiCiktisi fdpc = new frmDersProgramiCiktisi();
            fdpc.ShowDialog();
        }

        private void tsbKaydet_Click(object sender, EventArgs e)
        {
            string girilenVeritabaniAdi = Interaction.InputBox("Veritabanı Adı", "Veritabanına Kaydet", "", Screen.PrimaryScreen.Bounds.Width / 2 - 250, Screen.PrimaryScreen.Bounds.Height / 2 - 100);
            if (girilenVeritabaniAdi.Length < 3)
            {
                return;
            }
            SqlConnection baglanti = new SqlConnection();

            if (winAuto)
            {
                baglanti.ConnectionString = @"Server=" + server + ";Database=" + girilenVeritabaniAdi + ";Integrated Security=true";
            }
            else
            {
                baglanti.ConnectionString = @"Server=" + server + ";Database=" + girilenVeritabaniAdi + ";User Id=" + kullaniciAdi + ";Password=" + sifre;
            }

            baglanti.Open();
            if (baglanti.State != ConnectionState.Open)
            {
                return;
            }
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;

            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(baglanti))
            {
                bulkCopy.DestinationTableName = "dbo.ders_saatleri";
                try
                {

                    cmd.CommandText = "delete from ders_saatleri";
                    cmd.ExecuteNonQuery();
                    bulkCopy.WriteToServer(dtDersSaatleri);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            #region Delete

            cmd.CommandText = "delete from parametreler";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from ad_siniflar";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from ad_ogretmenler";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from ad_derslikler";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from atanan_dersler";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from siniflar";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from ogretmenler";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from derslikler";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete from dersler";
            cmd.ExecuteNonQuery();

            #endregion

            cmd.CommandText = "insert into parametreler values(" + gunSayisi + "," + gunlukDersSayisi + ")";
            cmd.ExecuteNonQuery();

            foreach (Sinif sinif in siniflar)
            {
                cmd.CommandText = "insert into siniflar values(@sinif_kodu,@ad,@zaman)";
                cmd.Parameters.AddWithValue("@sinif_kodu", sinif.kod);
                cmd.Parameters.AddWithValue("@ad", sinif.ad);
                string zaman = "";
                for (int i = 0; i < gunSayisi; i++)
                {
                    for (int j = 0; j < gunlukDersSayisi; j++)
                    {
                        if (sinif.uygunZamanlar[i, j] == false)
                        {
                            zaman += "0";
                        }
                        else
                        {
                            zaman += "1";
                        }
                    }
                }
                cmd.Parameters.AddWithValue("@zaman", zaman);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            foreach (Ogretmen ogretmen in ogretmenler)
            {
                cmd.CommandText = "insert into ogretmenler values(@ogretmen_kodu,@ad,@soyad,@zaman)";
                cmd.Parameters.AddWithValue("@ogretmen_kodu", ogretmen.kod);
                cmd.Parameters.AddWithValue("@ad", ogretmen.ad);
                cmd.Parameters.AddWithValue("@soyad", ogretmen.soyad);
                string zaman = "";
                for (int i = 0; i < gunSayisi; i++)
                {
                    for (int j = 0; j < gunlukDersSayisi; j++)
                    {
                        if (ogretmen.uygunZamanlar[i, j] == false)
                        {
                            zaman += "0";
                        }
                        else
                        {
                            zaman += "1";
                        }
                    }
                }
                cmd.Parameters.AddWithValue("@zaman", zaman);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            foreach (Derslik derslik in derslikler)
            {
                cmd.CommandText = "insert into derslikler values(@derslik_kodu,@ad,@zaman)";
                cmd.Parameters.AddWithValue("@derslik_kodu", derslik.kod);
                cmd.Parameters.AddWithValue("@ad", derslik.ad);
                string zaman = "";
                for (int i = 0; i < gunSayisi; i++)
                {
                    for (int j = 0; j < gunlukDersSayisi; j++)
                    {
                        if (derslik.uygunZamanlar[i, j] == false)
                        {
                            zaman += "0";
                        }
                        else
                        {
                            zaman += "1";
                        }
                    }
                }
                cmd.Parameters.AddWithValue("@zaman", zaman);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            foreach (Ders ders in dersler)
            {
                cmd.CommandText = "insert into dersler values(@ders_kodu,@ad,@dagilim_sekli,@zaman)";
                cmd.Parameters.AddWithValue("@ders_kodu", ders.kod);
                cmd.Parameters.AddWithValue("@ad", ders.ad);
                cmd.Parameters.AddWithValue("@dagilim_sekli", ders.dagilimSekli);
                string zaman = "";
                for (int i = 0; i < gunSayisi; i++)
                {
                    for (int j = 0; j < gunlukDersSayisi; j++)
                    {
                        if (ders.uygunZamanlar[i, j] == false)
                        {
                            zaman += "0";
                        }
                        else
                        {
                            zaman += "1";
                        }
                    }
                }
                cmd.Parameters.AddWithValue("@zaman", zaman);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }

            foreach (AtananDers ad in atananDersler)
            {
                cmd.CommandText = "insert into atanan_dersler(ders_kodu, dagilim_sekli) values(@ders_kodu,@dagilim_sekli)";
                cmd.Parameters.AddWithValue("@ders_kodu", ad.ders.kod);
                cmd.Parameters.AddWithValue("@dagilim_sekli", ad.dagilimSekli);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                cmd.CommandText = "select max(ad_ID) from atanan_dersler";
                int ad_ID = Convert.ToInt16(cmd.ExecuteScalar());

                foreach (Sinif sinif in ad.siniflar)
                {
                    cmd.CommandText = "insert into ad_siniflar values(@ad_ID, @sinif_kodu)";
                    cmd.Parameters.AddWithValue("@ad_ID", ad_ID);
                    cmd.Parameters.AddWithValue("@sinif_kodu", sinif.kod);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                foreach (Ogretmen ogretmen in ad.ogretmenler)
                {
                    cmd.CommandText = "insert into ad_ogretmenler values(@ad_ID, @ogretmen_kodu)";
                    cmd.Parameters.AddWithValue("@ad_ID", ad_ID);
                    cmd.Parameters.AddWithValue("@ogretmen_kodu", ogretmen.kod);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

                foreach (Derslik derslik in ad.derslikler)
                {
                    cmd.CommandText = "insert into ad_derslikler values(@ad_ID, @derslik_kodu)";
                    cmd.Parameters.AddWithValue("@ad_ID", ad_ID);
                    cmd.Parameters.AddWithValue("@derslik_kodu", derslik.kod);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }

            MessageBox.Show("Veritabanındaki değişiklikler tamamlandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsbYeni_Click(object sender, EventArgs e)
        {

            using (frmYeniDBSunucuGirisi frmSunucuGirisi = new frmYeniDBSunucuGirisi())
            {
                frmSunucuGirisi.ShowDialog();
            }
        }

        private void tsbDersler_Click(object sender, EventArgs e)
        {
            frmVeriler = new frmVeriler(frmVeriler.Islem.Ders);
            frmVeriler.ShowDialog();
        }

        private void tsbSiniflar_Click(object sender, EventArgs e)
        {
            frmVeriler = new frmVeriler(frmVeriler.Islem.Sinif);
            frmVeriler.ShowDialog();
        }

        private void tsbDerslikler_Click(object sender, EventArgs e)
        {
            frmVeriler = new frmVeriler(frmVeriler.Islem.Derslik);
            frmVeriler.ShowDialog();
        }

        private void tsbOgretmenler_Click(object sender, EventArgs e)
        {
            frmVeriler = new frmVeriler(frmVeriler.Islem.Ogretmen);
            frmVeriler.ShowDialog();
        }

        private void tsbVeritabani_Click(object sender, EventArgs e)
        {
            frmParametre.ShowDialog();
        }

        private void tsbKontrol_Click(object sender, EventArgs e)
        {
            if (Kontrol())
            {
                MessageBox.Show("Kontrol başarılı");
            }
            else
            {
                MessageBox.Show("Kontrol başarısız");
            }
        }

        private void tsbPlanlama_Click(object sender, EventArgs e)
        {
            //Hide();
            while (true)
            {
                AnaFonk();
                if (!dersBloklari.Any(db => db.eklendi == false))
                {
                    break;
                }
            }
            lblAnaTur.Text = anafonktur.ToString();
            anafonktur = 0;
            //Show();
        }

        private void tsbSonraKontrol_Click(object sender, EventArgs e)
        {
            lvwBasarisizlar.Dock = DockStyle.Fill;
            if (lvwBasarisizlar.Visible)
            {
                lvwBasarisizlar.Visible = false;
            }
            else
            {
                lvwBasarisizlar.Visible = true;
            }
        }


        #endregion

        private void tlpSiniflar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && tlpSiniflar.Cursor != Cursors.Arrow)
            {
                LabelleriBeyazlat();
            }
            else if (e.Button == MouseButtons.Left && tlpSiniflar.Cursor != Cursors.Arrow)
            {
                var ctl = tlpSiniflar.GetChildAtPoint(e.Location);

                if (ctl is null)
                {
                    tlpSiniflar.ResumeLayout();
                    TableLayoutPanelCellPosition tlpCol = new TableLayoutPanelCellPosition();
                    TableLayoutPanelCellPosition tlpRow = new TableLayoutPanelCellPosition();

                    for (int i = 25; i < tlpSiniflar.Width; i++)
                    {
                        try
                        {
                            tlpCol = tlpSiniflar.GetCellPosition(tlpSiniflar.GetChildAtPoint(new System.Drawing.Point(e.X, 35)));
                        }
                        catch (Exception)
                        {
                            
                        }
                        if (tlpCol != null)
                        {
                            break;
                        }
                    }
                    for (int j = 1; j < tlpSiniflar.Height; j++)
                    {
                        try
                        {
                            tlpRow = tlpSiniflar.GetCellPosition(tlpSiniflar.GetChildAtPoint(new System.Drawing.Point(5, e.Y)));
                        }
                        catch (Exception)
                        {
                            
                        }
                        if (tlpRow != null)
                        {
                            break;
                        }
                    }

                    try
                    {
                        if (tlpSiniflar.GetControlFromPosition(tlpCol.Column, 1) != null && tlpSiniflar.GetControlFromPosition(0, tlpRow.Row) != null)
                        {
                            if (tlpSiniflar.GetControlFromPosition(tlpCol.Column, 1).BackColor == Color.Lime &&
                                tlpSiniflar.GetControlFromPosition(0, tlpRow.Row).BackColor == Color.Lime)
                            {
                                int k = 0;
                                for (int i = 0; i < siniflar.Count; i++)
                                {
                                    if (tlpSiniflar.GetControlFromPosition(0, i + 2).BackColor == Color.Lime)
                                    {
                                        for (; k < seciliDB.sinifKartlar.Count;)
                                        {
                                            tlpSiniflar.Controls.Add(seciliDB.sinifKartlar[k], tlpCol.Column, i + 2);
                                            k++;
                                            break;
                                        }
                                    }
                                }

                                foreach (var kart in seciliDB.sinifKartlar)
                                {
                                    kart.Show();
                                }

                                int gun = (tlpCol.Column - 1) / 8;
                                int saat = (tlpCol.Column - 1) % 8;

                                for (int i = saat; i < saat + seciliDB.uzunluk; i++)
                                {
                                    foreach (var derslik in seciliDB.atananDers.derslikler)
                                    { derslik.bosSaatler[gun, i] = false; }

                                    foreach (var ogretmen in seciliDB.atananDers.ogretmenler)
                                    { ogretmen.bosSaatler[gun, i] = false; }

                                    foreach (var sinif in seciliDB.atananDers.siniflar)
                                    { sinif.bosSaatler[gun, i] = false; }
                                }

                                seciliDB.gun = gun;
                                seciliDB.saat = saat;

                                LabelleriBeyazlat();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //seciliDB.kartlar[0].Margin = new Padding(0);
                    tlpSiniflar.SuspendLayout();
                }
            }


        }

        public void LabelleriBeyazlat()
        {
            seciliDB = null;
            tlpSiniflar.Cursor = Cursors.Arrow;

            for (int i = 0; i < siniflar.Count; i++)
            {
                tlpSiniflar.GetControlFromPosition(0, i + 2).BackColor = Color.White;
            }

            for (int j = 0; j < gunSayisi * gunlukDersSayisi; j++)
            {
                tlpSiniflar.GetControlFromPosition(j + 1, 1).BackColor = Color.White;
            }
        }


    }
}
