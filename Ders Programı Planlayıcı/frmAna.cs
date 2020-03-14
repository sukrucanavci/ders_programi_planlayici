﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmAna : Form
    {
        #region Enums

        public enum Gunler
        {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
        }

        #endregion


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
            Color.AntiqueWhite,
            Color.LightSalmon,
            Color.LightSeaGreen,
            Color.Aqua,
            Color.LightSkyBlue,
            Color.Aquamarine,
            Color.LightSteelBlue,
            Color.Beige,
            Color.LightYellow,
            Color.Bisque,
            Color.Lime,
            Color.LimeGreen,
            Color.Linen,
            Color.Blue,
            Color.Magenta,
            Color.BlueViolet,
            Color.Brown,
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
            Color.Olive,
            Color.OliveDrab,
            Color.DarkOrange,
            Color.Orange,
            Color.OrangeRed,
            Color.Orchid,
            Color.DarkSalmon,
            Color.PaleGoldenrod,
            Color.DarkSeaGreen,
            Color.PaleGreen,
            Color.PaleTurquoise,
            Color.DarkSlateGray,
            Color.PaleVioletRed,
            Color.DarkTurquoise,
            Color.PapayaWhip,
            Color.DarkViolet,
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
            Color.LightCyan,
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

        public static bool ogleArasiVar = false;
        public static bool ogleArasiBlokDersleriBolebilir = true;
        public static int ogleArasiKacinciDerstenSonra = 4;

        public static int gunSayisi = 5;
        private static int GunlukDersSayisi = 8;
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
        DersBlogu[,] dbSinif;
        /// <summary>
        /// Ders bloklarını öğretmene göre tutan matris
        /// </summary>
        DersBlogu[,] dbOgretmen;
        /// <summary>
        /// Ders bloklarını dersliğe göre tutan matris
        /// </summary>
        DersBlogu[,] dbDerslik;

        #endregion


        public static DataTable dtDersSaatleri;
        frmParametre frmParametre = new frmParametre();

        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            #region Datagridview görsel ayarlar

            dgwDerslikDP.EnableHeadersVisualStyles = false;
            dgwOgretmenDP.EnableHeadersVisualStyles = false;
            dgwSinifDP.EnableHeadersVisualStyles = false;
            dgwGunler0.EnableHeadersVisualStyles = false;
            dgwGunler1.EnableHeadersVisualStyles = false;
            dgwGunler2.EnableHeadersVisualStyles = false;

            dgwGunler0.Height = dgwGunler0.ColumnHeadersHeight;
            dgwGunler1.Height = dgwGunler0.Height;
            dgwGunler2.Height = dgwGunler0.Height;

            #endregion
            
            //Ders saatleri
            dtDersSaatleri = new DataTable("ders_saatleri");
            dtDersSaatleri.Columns.AddRange(new DataColumn[] 
            {
                new DataColumn("Ders Saati"),
                new DataColumn("Başlangıç"),
                new DataColumn("Bitiş")
            });

            //Parametrelerin girilmesi için frmParametreyi başlattım
            frmParametre.ShowDialog();

            this.WindowState = FormWindowState.Maximized;

            //Gün sayısı kadar sütun oluşturup datagridviewlere ekledim
            DataGridViewColumn column;
            for (int i = 0; i < secilenGunler.Count; i++)
            {
                column = new DataGridViewColumn();

                if (i % 2 == 1) { column.HeaderCell.Style.BackColor = Color.White; }
                else { column.HeaderCell.Style.BackColor = Color.LightGray; }

                column.HeaderText = secilenGunler[i].ToString();
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgwGunler0.Columns.Add(column);
                dgwGunler1.Columns.Add(dgwGunler0.Columns[i].Clone() as DataGridViewColumn);
                dgwGunler2.Columns.Add(dgwGunler0.Columns[i].Clone() as DataGridViewColumn);
            }

            //Haftalık max ders saati kadar sütun oluşturup alt sütunları oluşturdum
            for (int i = 0; i < gunSayisi; i++)
            {
                for (int j = 0; j < gunlukDersSayisi; j++)
                {
                    column = new DataGridViewColumn();

                    if (i % 2 == 0) { column.HeaderCell.Style.BackColor = Color.LightGray; }
                    else { column.HeaderCell.Style.BackColor = Color.White; }

                    column.HeaderText = (j+1).ToString();
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    dgwSinifDP.Columns.Add(column);
                    dgwOgretmenDP.Columns.Add(dgwSinifDP.Columns[j].Clone() as DataGridViewColumn);
                    dgwDerslikDP.Columns.Add(dgwSinifDP.Columns[j].Clone() as DataGridViewColumn);
                }
            }

            #region TableLayoutPanel

            tlpSiniflar.ResumeLayout();
            tlpSiniflar.Hide();


            tlpSiniflar.SuspendLayout();
            tlpSiniflar.Show();
            #endregion
        }

        int yerlestirilen = 0;
        int anafonktur = 0;

        /// <summary>
        /// Ana fonksiyon, ön kontrolü ve düzenlemeleri yapar. Daha sonra algoritmayı çalıştırır
        /// </summary>
        void AnaFonk()
        {
            #region İlk

            //Algoritmayı engelleyecek bir durumun olup olmadığını kontrol edilir, başarısızsa algoritma çalıştırılmaz
            if (!Kontrol()) { return; }

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

            //dersBloklari.Sort((x, y) => y.uzunluk.CompareTo(x.uzunluk));
            dersBloklari.Sort((x, y) => y.doluluk.CompareTo(x.doluluk));
            //Karistir(dersBloklari);

            gunler.Clear(); for (int gun = 0; gun < gunSayisi; gun++) { gunler.Add(gun); }
            saatler.Clear(); for (int saat = 0; saat < gunlukDersSayisi; saat++) { saatler.Add(saat); }

            int counter = 0;
            foreach (var db in dersBloklari) { db.eklendi = false; }

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
                    Algoritma(dersBlogu);
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
                                    if (Algoritma(hedefDersBlogu))
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

                                        Algoritma(eklenemeyenDB);
                                        yerlestirilen--;
                                        goto digerEklenemeyenBlogaGec;
                                    }
                                }
                            }
                        }
                    digerEklenemeyenBlogaGec:;
                    }
                    if (counter > 654)
                    {
                        break;
                    }
                }
                if (counter>654)
                {
                    anafonktur++;
                    AnaFonk();
                    return;
                }

            }

            //dgwOgretmenDP.Visible = false;
            //dgwSinifDP.Visible = false;
            //dgwDerslikDP.Visible = false;

            lblBasari.Text = "  " + yerlestirilen + "/" + dersBloklari.Count;
            lblTur.Text = counter.ToString();

            #endregion

            #region FlowLayoutPanel İşlemleri

            flpDersEtiketleri.Controls.Clear();
            foreach (var db in dersBloklari)
            {
                if (db.eklendi == false)
                {
                    //MessageBox.Show(db.atananDers.siniflar[0].ad + " " + db.atananDers.ogretmenler[0].ad);
                    flpDersEtiketleri.Controls.Add(db.kart);
                    flpDersEtiketleri.Controls.Add(new Label() { Size = new Size(0, 26) });
                }
            }
            flpDersEtiketleri.Controls.Add(new Label());
            //flpDersEtiketleri.Controls.RemoveAt(flpDersEtiketleri.Controls.Count - 1);

            #endregion

            #region DataGridView İşlemleri

            dgwSinifDP.Rows.Clear();
            dgwOgretmenDP.Rows.Clear();
            dgwDerslikDP.Rows.Clear();

            DataGridViewRow row;
            DataGridViewCell cell;

            for (int i = 0; i < derslikler.Count; i++)
            {
                row = new DataGridViewRow();
                row.HeaderCell.Value = derslikler[i].kod;
                row.Height = 35;

                int sutunAdeti = gunSayisi * gunlukDersSayisi;
                for (int j = 0; j < sutunAdeti;)
                {
                    if (dbDerslik[i, j] != null)
                    {
                        int sutunSabiti = j;
                        for (int sayac = 0; sayac < dbDerslik[i, sutunSabiti].uzunluk; sayac++)
                        {
                            cell = new DataGridViewTextBoxCell();
                            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            if (sayac == 0)
                            {
                                foreach (var snf in dbDerslik[i, sutunSabiti].atananDers.siniflar)
                                {
                                    cell.Value += snf.kod + " ";
                                }
                            }
                            if (dbDerslik[i, sutunSabiti].atananDers.ogretmenler.Count == 1)
                            {
                                cell.Style.BackColor = dbDerslik[i, sutunSabiti].atananDers.ogretmenler[0].renk;
                            }
                            else
                            {
                                int r = 0; int g = 0; int b = 0;
                                foreach (var ogretmen in dbDerslik[i, sutunSabiti].atananDers.ogretmenler)
                                {
                                    r += ogretmen.renk.R;
                                    g += ogretmen.renk.G;
                                    b += ogretmen.renk.B;
                                }
                                int ogretmenSayisi = dbDerslik[i, sutunSabiti].atananDers.ogretmenler.Count;
                                r = r / ogretmenSayisi;
                                g = g / ogretmenSayisi;
                                b = b / ogretmenSayisi;

                                cell.Style.BackColor = Color.FromArgb(r, g, b);
                            }
                            row.Cells.Add(cell);
                            j++;
                        }
                    }
                    else
                    {
                        cell = new DataGridViewTextBoxCell();
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        int bölüm = j / gunlukDersSayisi;
                        int kalan = j % gunlukDersSayisi;
                        if (!derslikler[i].uygunZamanlar[bölüm, kalan])
                        {
                            cell.Value = "X";
                            cell.Style.BackColor = Color.DarkGray;
                        }
                        row.Cells.Add(cell);
                        j++;
                    }
                }

                dgwDerslikDP.Rows.Add(row);
            }

            for (int i = 0; i < ogretmenler.Count; i++)
            {
                row = new DataGridViewRow();
                row.HeaderCell.Value = ogretmenler[i].kod;
                row.Height = 35;

                for (int j = 0; j < gunSayisi * gunlukDersSayisi;)
                {
                    if (dbOgretmen[i, j] != null)
                    {
                        int sutunSabiti = j;
                        for (int sayac = 0; sayac < dbOgretmen[i, sutunSabiti].uzunluk; sayac++)
                        {
                            cell = new DataGridViewTextBoxCell();
                            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            if (sayac == 0)
                            {
                                foreach (var snf in dbOgretmen[i, sutunSabiti].atananDers.siniflar)
                                {
                                    cell.Value += snf.kod + " ";
                                }
                            }
                            if (dbOgretmen[i, sutunSabiti].atananDers.ogretmenler.Count == 1)
                            {
                                cell.Style.BackColor = dbOgretmen[i, sutunSabiti].atananDers.ogretmenler[0].renk;
                            }
                            else
                            {
                                int r = 0; int g = 0; int b = 0;
                                foreach (var ogretmen in dbOgretmen[i, sutunSabiti].atananDers.ogretmenler)
                                {
                                    r += ogretmen.renk.R;
                                    g += ogretmen.renk.G;
                                    b += ogretmen.renk.B;
                                }
                                int ogretmenSayisi = dbOgretmen[i, sutunSabiti].atananDers.ogretmenler.Count;
                                r = r / ogretmenSayisi;
                                g = g / ogretmenSayisi;
                                b = b / ogretmenSayisi;

                                cell.Style.BackColor = Color.FromArgb(r, g, b);
                            }
                            row.Cells.Add(cell);
                            j++;
                        }
                    }
                    else
                    {
                        cell = new DataGridViewTextBoxCell();
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        int bölüm = j / gunlukDersSayisi;
                        int kalan = j % gunlukDersSayisi;
                        if (!ogretmenler[i].uygunZamanlar[bölüm, kalan])
                        {
                            cell.Value = "X";
                            cell.Style.BackColor = Color.DarkGray;
                        }
                        row.Cells.Add(cell);
                        j++;
                    }
                }

                dgwOgretmenDP.Rows.Add(row);
            }

            for (int i = 0; i < siniflar.Count; i++)
            {
                row = new DataGridViewRow();
                row.HeaderCell.Value = siniflar[i].kod;
                row.Height = 35;

                for (int j = 0; j < gunSayisi * gunlukDersSayisi;)
                {
                    if (dbSinif[i, j] != null)
                    {
                        int sutunSabiti = j;
                        for (int sayac = 0; sayac < dbSinif[i, sutunSabiti].uzunluk; sayac++)
                        {
                            cell = new DataGridViewTextBoxCell();
                            cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            if (sayac == 0)
                            {
                                cell.Value = dbSinif[i, sutunSabiti].atananDers.ders.kod;
                            }
                            if (dbSinif[i, sutunSabiti].atananDers.ogretmenler.Count == 1)
                            {
                                cell.Style.BackColor = dbSinif[i, sutunSabiti].atananDers.ogretmenler[0].renk;
                            }
                            else
                            {
                                int r = 0; int g = 0; int b = 0;
                                foreach (var ogretmen in dbSinif[i, sutunSabiti].atananDers.ogretmenler)
                                {
                                    r += ogretmen.renk.R;
                                    g += ogretmen.renk.G;
                                    b += ogretmen.renk.B;
                                }
                                int ogretmenSayisi = dbSinif[i, sutunSabiti].atananDers.ogretmenler.Count;
                                r = r / ogretmenSayisi;
                                g = g / ogretmenSayisi;
                                b = b / ogretmenSayisi;

                                cell.Style.BackColor = Color.FromArgb(r, g, b);
                            }
                            row.Cells.Add(cell);
                            j++;
                        }
                    }
                    else
                    {
                        cell = new DataGridViewTextBoxCell();
                        cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        int bölüm = j / gunlukDersSayisi;
                        int kalan = j % gunlukDersSayisi;
                        if (!siniflar[i].uygunZamanlar[bölüm, kalan])
                        {
                            cell.Value = "X";
                            cell.Style.BackColor = Color.DarkGray;
                        }
                        row.Cells.Add(cell);
                        j++;
                    }
                }

                dgwSinifDP.Rows.Add(row);
            }

            #endregion

            #region TableLayoutPanel İşlemleri

            tlpSiniflar.Hide();
            tlpSiniflar.ResumeLayout();

            tlpSiniflar.Controls.Clear();
            tlpSiniflar.ColumnStyles.Clear();
            tlpSiniflar.ColumnCount = 1;
            tlpSiniflar.RowStyles.Clear();
            tlpSiniflar.RowCount = 1;

            int sutun = gunSayisi * GunlukDersSayisi + 1;
            int w = tlpSiniflar.Width / sutun;
            for (int i = 0; i < sutun; i++)
            {
                tlpSiniflar.ColumnCount++;
                tlpSiniflar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, w));
            }

            tlpSiniflar.RowStyles.Add(new RowStyle(SizeType.AutoSize, 35));
            tlpSiniflar.RowStyles.Add(new RowStyle(SizeType.AutoSize, 35));
            //tlpSiniflar.RowStyles.Add(new RowStyle(SizeType.AutoSize, 35));
            tlpSiniflar.RowCount++;

            Label label;
            for (int i = 0; i < gunSayisi; i++)
            {
                label = new Label()
                {
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
                        BackColor = Color.White,
                        Text = (j + 1).ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    tlpSiniflar.Controls.Add(label, (i * gunlukDersSayisi) + 1 + j, 1);
                }
            }


            //int sutun = gunSayisi * GunlukDersSayisi + 1;

            for (int i = 0; i < siniflar.Count; i++)
            {
                tlpSiniflar.RowCount++;
                tlpSiniflar.RowStyles.Add(new RowStyle(SizeType.AutoSize, 35));
                for (int j = 0; j < sutun-1; j++)
                {
                    if (dbSinif[i, j] != null)
                    {
                        if (j == 0)
                        {
                            tlpSiniflar.Controls.Add(new Label()
                            {
                                Text = siniflar[i].kod,
                                TextAlign = ContentAlignment.MiddleLeft,
                                Size = new Size(50,20)
                            }, 0, i+2);
                        }
                        
                        tlpSiniflar.Controls.Add(dbSinif[i, j].kart, j+1, i+2);
                        tlpSiniflar.SetColumnSpan(dbSinif[i, j].kart, dbSinif[i, j].uzunluk);
                        
                    }
                }
            }

            tlpSiniflar.SuspendLayout();
            tlpSiniflar.Show();

            #endregion

        }



        /// <summary>
        /// Algoritma, ders bloklarını verilen kriterlere göre yerleştirir
        /// </summary>
        /// <param name="dersBlogu"></param>
        bool Algoritma(DersBlogu dersBlogu)
        {
            //Thread.Sleep(1);
            Karistir(gunler);
            Karistir(saatler);

            foreach (var gun in gunler)
            {
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

                    //dersBlogu.atananDers.ders.tds += dersBlogu.uzunluk;
                    dersBlogu.eklendi = true;
                    dersBlogu.gun = gun;
                    dersBlogu.saat = saat;

                    //boş saatleri doldurma
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

        /// <summary>
        /// Verilen listeyi karıştırır
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">List nesnesi</param>
        void Karistir<T>(IList<T> list)
        {
            Random rnd = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            //RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            //int n = list.Count;
            //while (n > 1)
            //{
            //    byte[] box = new byte[1];
            //    do provider.GetBytes(box);
            //    while (!(box[0] < n * (Byte.MaxValue / n)));
            //    int k = (box[0] % n);
            //    n--;
            //    T value = list[k];
            //    list[k] = list[n];
            //    list[n] = value;
            //}
        }

        /// <summary>
        /// Dersin, öğretmenlerin, dersliklerin ve sınıfların boş zamanlarını kontrol eder. Eğer uygunsa true döndürür
        /// </summary>
        /// <param name="dersBlogu">Mevcut dersin bir bloğu</param>
        /// <param name="gun">Kontrol edilecek gün</param>
        /// <param name="saat">Kontrol edilecek saat</param>
        /// <returns></returns>
        bool BosZamanlariKontrolEt(DersBlogu dersBlogu, int gun, int saat)
        {
            for (int i = saat; i < saat + dersBlogu.uzunluk; i++)
            {
                if (dersBlogu.atananDers.ders.uygunZamanlar[gun, i] == true &&
                    !dersBlogu.atananDers.derslikler.Any(d => d.bosSaatler[gun, i] == false) &&
                    !dersBlogu.atananDers.ogretmenler.Any(d => d.bosSaatler[gun, i] == false) &&
                    !dersBlogu.atananDers.siniflar.Any(d => d.bosSaatler[gun, i] == false))
                    continue;
                else
                    return false;
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
                if (dersBlogu.atananDers.ders.uygunZamanlar[gun, i] == true &&
                    !dersBlogu.atananDers.derslikler.Any(d => d.uygunZamanlar[gun, i] == false) &&
                    !dersBlogu.atananDers.ogretmenler.Any(d => d.uygunZamanlar[gun, i] == false) &&
                    !dersBlogu.atananDers.siniflar.Any(d => d.uygunZamanlar[gun, i] == false))
                    continue;
                else
                    return false;
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
                for (int s = saat; s < saat + dersBlogu.uzunluk; s++)
                    if (s == ogleArasiKacinciDerstenSonra + 1)
                        return true;

            return false;
        }

        /// <summary>
        /// Ön kontrolleri gerçekleştirir. Eğer algoritmanın çalışmasına engel bir durum yoksa true, varsa false döndürür
        /// </summary>
        /// <returns>asd</returns>
        bool Kontrol()
        {
            bool donusDegeri = true;

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
                    donusDegeri = false;
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
                    donusDegeri = false;
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
                    donusDegeri = false;
                }
            }

            return donusDegeri;
        }


        #region Üst Paneldeki kontrol nesnelerinin işlemleri

        frmVeriler frmVeriler;
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
            AnaFonk();
            lblAnaTur.Text = anafonktur.ToString();
            anafonktur = 0;
            //Show();
        }

        #endregion



        /// <summary>
        /// Derslik görünümünde bulunan datagridview nesnesindeki hücrelere tıklandığında formun sağ altında ders bloğu ile ilgili kısa bilgiler verir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwDerslikDP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblEtiket.Controls.Clear();
            if (e.RowIndex == -1 || e.ColumnIndex == -1) { return; };
            if (dbDerslik[e.RowIndex, e.ColumnIndex] == null)
            {
                lblDers.Text = "";
                lblSinif.Text = "";
                lblOgretmen.Text = "";
                lblDerslik.Text = "";
                return;
            };
            lblDerslik.Text = "";
            lblSinif.Text = "";
            lblOgretmen.Text = "";

            lblDers.Text = dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.ders.kod + " - " +
                dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.ders.ad;

            foreach (var snf in dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.siniflar)
                lblSinif.Text += snf.kod + " ";

            if (dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler.Count > 1)
                foreach (var ogr in dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler)
                    lblOgretmen.Text += ogr.kod + " ";
            else
                lblOgretmen.Text += dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].kod + " - " +
                    dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].ad + " " +
                    dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].soyad;

            foreach (var drslk in dbDerslik[e.RowIndex, e.ColumnIndex].atananDers.derslikler)
                lblDerslik.Text += drslk.kod + " ";

            var etiket = dbDerslik[e.RowIndex, e.ColumnIndex].kart;
            etiket.Dock = DockStyle.Fill;
            lblEtiket.Controls.Add(etiket);
        }

        /// <summary>
        /// Öğretmen görünümünde bulunan datagridview nesnesindeki hücrelere tıklandığında formun sağ altında ders bloğu ile ilgili kısa bilgiler verir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwOgretmenDP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblEtiket.Controls.Clear();
            if (e.RowIndex == -1 || e.ColumnIndex == -1) { return; };
            if (dbOgretmen[e.RowIndex, e.ColumnIndex] == null)
            {
                lblDers.Text = "";
                lblSinif.Text = "";
                lblOgretmen.Text = "";
                lblDerslik.Text = "";
                return;
            };
            lblSinif.Text = "";
            lblOgretmen.Text = "";
            lblDerslik.Text = "";

            lblDers.Text = dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.ders.kod + " - " +
                dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.ders.ad;

            foreach (var snf in dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.siniflar)
                lblSinif.Text += snf.kod + " ";

            if (dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler.Count > 1)
                foreach (var ogr in dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler)
                    lblOgretmen.Text += ogr.kod + " ";
            else
                lblOgretmen.Text += dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].kod + " - " +
                    dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].ad + " " +
                    dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].soyad;

            foreach (var drslk in dbOgretmen[e.RowIndex, e.ColumnIndex].atananDers.derslikler)
                lblDerslik.Text += drslk.kod + " ";

            var etiket = dbOgretmen[e.RowIndex, e.ColumnIndex].kart;
            etiket.Dock = DockStyle.Fill;
            lblEtiket.Controls.Add(etiket);
        }

        /// <summary>
        /// Sınıf görünümünde bulunan datagridview nesnesindeki hücrelere tıklandığında formun sağ altında ders bloğu ile ilgili kısa bilgiler verir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwSinifDP_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblEtiket.Controls.Clear();

            if (e.RowIndex == -1 || e.ColumnIndex == -1) { return; };

            if (dbSinif[e.RowIndex, e.ColumnIndex] == null)
            {
                lblDers.Text = "";
                lblSinif.Text = "";
                lblOgretmen.Text = "";
                lblDerslik.Text = "";
                return;
            };
            lblDerslik.Text = "";
            lblSinif.Text = "";
            lblOgretmen.Text = "";

            lblDers.Text = dbSinif[e.RowIndex, e.ColumnIndex].atananDers.ders.kod + " - " +
                dbSinif[e.RowIndex, e.ColumnIndex].atananDers.ders.ad;

            foreach (var snf in dbSinif[e.RowIndex, e.ColumnIndex].atananDers.siniflar)
                lblSinif.Text += snf.kod + " ";

            if (dbSinif[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler.Count > 1)
                foreach (var ogr in dbSinif[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler)
                    lblOgretmen.Text += ogr.kod + " ";
            else
                lblOgretmen.Text += dbSinif[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].kod + " - " +
                    dbSinif[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].ad + " " +
                    dbSinif[e.RowIndex, e.ColumnIndex].atananDers.ogretmenler[0].soyad;

            foreach (var drslk in dbSinif[e.RowIndex, e.ColumnIndex].atananDers.derslikler)
                lblDerslik.Text += drslk.kod + " ";
            var etiket = dbSinif[e.RowIndex, e.ColumnIndex].kart;
            etiket.Dock = DockStyle.Fill;
            lblEtiket.Controls.Add(etiket);
        }

        private void flpDersEtiketleri_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}
