using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmVeriler : Form
    {
        public frmVeriler(Islem islem)
        {
            InitializeComponent();

            lvwDersler.Dock = DockStyle.Fill;
            lvwSiniflar.Dock = DockStyle.Fill;
            lvwDerslikler.Dock = DockStyle.Fill;
            lvwOgretmenler.Dock = DockStyle.Fill;

            VerileriYenile();

            switch (islem)
            {
                case Islem.Ders:
                    btnDersler.Select();
                    btnDersler_Click(default, new EventArgs());
                    break;
                case Islem.Sinif:
                    btnSiniflar.Select();
                    btnSiniflar_Click(default, new EventArgs());
                    break;
                case Islem.Derslik:
                    btnDerslikler.Select();
                    btnDerslikler_Click(default, new EventArgs());
                    break;
                case Islem.Ogretmen:
                    btnOgretmenler.Select();
                    btnOgretmenler_Click(default, new EventArgs());
                    break;
                default:
                    break;
            }
        }

        public enum Islem
        {
            Ders,
            Sinif,
            Derslik,
            Ogretmen
        }

        Islem islem;

        frmVeriDuzenleme frmVeriDuzenleme;

        void VerileriYenile()
        {
            lvwDersler.Items.Clear(); lvwSiniflar.Items.Clear(); lvwDerslikler.Items.Clear(); lvwOgretmenler.Items.Clear();

            ListViewItem item;

            for (int i = 0; i < frmAna.dersler.Count; i++)
            {
                Color renk = Color.WhiteSmoke;
                if (i % 2 == 0) { renk = Color.White; }

                item = new ListViewItem(new string[] {
                    frmAna.dersler[i].ad, frmAna.dersler[i].kod, frmAna.dersler[i].tds.ToString(), frmAna.dersler[i].dagilimSekli
                }, 0, Color.Black, renk, default);

                lvwDersler.Items.Add(item);
            }

            for (int i = 0; i < frmAna.siniflar.Count; i++)
            {
                Color renk = Color.WhiteSmoke;
                if (i % 2 == 0) { renk = Color.White; }

                item = new ListViewItem(new string[] {
                    frmAna.siniflar[i].ad, frmAna.siniflar[i].kod, frmAna.siniflar[i].tds.ToString()
                }, 1, Color.Black, renk, default);

                lvwSiniflar.Items.Add(item);
            }

            for (int i = 0; i < frmAna.derslikler.Count; i++)
            {
                Color renk = Color.WhiteSmoke;
                if (i % 2 == 0) { renk = Color.White; }

                item = new ListViewItem(new string[] {
                    frmAna.derslikler[i].ad, frmAna.derslikler[i].kod, frmAna.derslikler[i].tds.ToString()
                }, 2, Color.Black, renk, default);

                lvwDerslikler.Items.Add(item);
            }


            for (int i = 0; i < frmAna.ogretmenler.Count; i++)
            {
                Color renk = Color.WhiteSmoke;
                if (i % 2 == 0) { renk = Color.White; }

                item = new ListViewItem(new string[] {
                    frmAna.ogretmenler[i].ad, frmAna.ogretmenler[i].soyad, frmAna.ogretmenler[i].kod, frmAna.ogretmenler[i].tds.ToString()
                }, 3, Color.Black, renk, default);

                lvwOgretmenler.Items.Add(item);
            }

        }

        #region pnlSol

        private void btnDersler_Click(object sender, EventArgs e)
        {
            islem = Islem.Ders;
            lblListeAdi.Text = "Tanımlı Dersler";

            lvwDersler.Visible = true; lvwSiniflar.Visible = false;
            lvwDerslikler.Visible = false; lvwOgretmenler.Visible = false;
        }

        private void btnSiniflar_Click(object sender, EventArgs e)
        {
            islem = Islem.Sinif;
            lblListeAdi.Text = "Tanımlı Sınıflar";

            lvwDersler.Visible = false; lvwSiniflar.Visible = true;
            lvwDerslikler.Visible = false; lvwOgretmenler.Visible = false;
        }

        private void btnDerslikler_Click(object sender, EventArgs e)
        {
            islem = Islem.Derslik;
            lblListeAdi.Text = "Tanımlı Derslikler";

            lvwDersler.Visible = false; lvwSiniflar.Visible = false;
            lvwDerslikler.Visible = true; lvwOgretmenler.Visible = false;
        }

        private void btnOgretmenler_Click(object sender, EventArgs e)
        {
            islem = Islem.Ogretmen;
            lblListeAdi.Text = "Tanımlı Öğretmenler";

            lvwDersler.Visible = false; lvwSiniflar.Visible = false;
            lvwDerslikler.Visible = false; lvwOgretmenler.Visible = true;
        }

        #endregion

        #region pnlSag

        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmVeriDuzenleme = new frmVeriDuzenleme(islem);
            frmVeriDuzenleme.ShowDialog();
            VerileriYenile();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string kod;
            switch (islem)
            {
                case Islem.Ders:
                    if (lvwDersler.SelectedItems.Count < 1) { return; }
                    kod = lvwDersler.SelectedItems[0].SubItems[1].Text;
                    frmVeriDuzenleme = new frmVeriDuzenleme(frmAna.dersler.Where(ders => ders.kod == kod).First());
                    frmVeriDuzenleme.ShowDialog();
                    break;

                case Islem.Sinif:
                    if (lvwSiniflar.SelectedItems.Count < 1) { return; }
                    kod = lvwSiniflar.SelectedItems[0].SubItems[1].Text;
                    frmVeriDuzenleme = new frmVeriDuzenleme(frmAna.siniflar.Where(sinif => sinif.kod == kod).First());
                    frmVeriDuzenleme.ShowDialog();
                    break;

                case Islem.Derslik:
                    if (lvwDerslikler.SelectedItems.Count < 1) { return; }
                    kod = lvwDerslikler.SelectedItems[0].SubItems[1].Text;
                    frmVeriDuzenleme = new frmVeriDuzenleme(frmAna.derslikler.Where(derslik => derslik.kod == kod).First());
                    frmVeriDuzenleme.ShowDialog();
                    break;

                case Islem.Ogretmen:
                    if (lvwOgretmenler.SelectedItems.Count < 1) { return; }
                    kod = lvwOgretmenler.SelectedItems[0].SubItems[2].Text;
                    frmVeriDuzenleme = new frmVeriDuzenleme(frmAna.ogretmenler.Where(ogretmen => ogretmen.kod == kod).First());
                    frmVeriDuzenleme.ShowDialog();
                    break;
                default:
                    break;
            }
            VerileriYenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string kod;
            switch (islem)
            {
                case Islem.Ders:
                    if (lvwDersler.SelectedItems.Count < 1) { return; }
                    kod = lvwDersler.SelectedItems[0].SubItems[1].Text;
                    foreach (DersBlogu db in frmAna.dersBloklari.ToList())
                    {
                        if (db.atananDers.ders.kod == kod)
                        {
                            frmAna.dersBloklari.Remove(db);
                        }
                    }
                    foreach (AtananDers ad in frmAna.atananDersler.ToList())
                    {
                        if (ad.ders.kod == kod)
                        {
                            foreach (var item in ad.derslikler)
                            {
                                item.tds -= ad.tds;
                            }
                            foreach (var item in ad.siniflar)
                            {
                                item.tds -= ad.tds;
                            }
                            foreach (var item in ad.ogretmenler)
                            {
                                item.tds -= ad.tds;
                            }
                            frmAna.atananDersler.Remove(ad);
                        }
                    }
                    foreach (Ders ders in frmAna.dersler.ToList())
                    {
                        if (ders.kod == kod)
                        {
                            frmAna.dersler.Remove(ders);
                        }
                    }
                    break;

                case Islem.Sinif:
                    if (lvwSiniflar.SelectedItems.Count < 1) { return; }
                    kod = lvwSiniflar.SelectedItems[0].SubItems[1].Text;
                    foreach (AtananDers ad in frmAna.atananDersler.ToList())
                    {
                        foreach (Sinif sinif in ad.siniflar.ToList())
                        {
                            if (sinif.kod == kod)
                            {
                                ad.ders.tds -= ad.tds;
                                foreach (var item in ad.derslikler)
                                {
                                    item.tds -= ad.tds;
                                }
                                foreach (var item in ad.ogretmenler)
                                {
                                    item.tds -= ad.tds;
                                }
                                foreach (DersBlogu db in frmAna.dersBloklari.ToList())
                                {
                                    if (db.atananDers == ad)
                                    {
                                        frmAna.dersBloklari.Remove(db);
                                    }
                                }
                                frmAna.atananDersler.Remove(ad);
                                frmAna.siniflar.Remove(sinif);
                                break;
                            }
                        }
                    }
                    foreach (var item in frmAna.siniflar.ToList())
                    {
                        if (item.kod == kod)
                        {
                            frmAna.siniflar.Remove(item);
                        }
                    }
                    break;

                case Islem.Derslik:
                    if (lvwDerslikler.SelectedItems.Count < 1) { return; }
                    kod = lvwDerslikler.SelectedItems[0].SubItems[1].Text;
                    foreach (AtananDers ad in frmAna.atananDersler.ToList())
                    {
                        foreach (Derslik derslik in ad.derslikler.ToList())
                        {
                            if (derslik.kod == kod)
                            {
                                ad.ders.tds -= ad.tds;
                                foreach (var item in ad.siniflar)
                                {
                                    item.tds -= ad.tds;
                                }
                                foreach (var item in ad.ogretmenler)
                                {
                                    item.tds -= ad.tds;
                                }
                                foreach (DersBlogu db in frmAna.dersBloklari.ToList())
                                {
                                    if (db.atananDers == ad)
                                    {
                                        frmAna.dersBloklari.Remove(db);
                                    }
                                }
                                frmAna.atananDersler.Remove(ad);
                                break;
                            }
                        }
                    }
                    foreach (var item in frmAna.derslikler.ToList())
                    {
                        if (item.kod == kod)
                        {
                            frmAna.derslikler.Remove(item);
                        }
                    }
                    break;

                case Islem.Ogretmen:
                    if (lvwOgretmenler.SelectedItems.Count < 1) { return; }
                    kod = lvwOgretmenler.SelectedItems[0].SubItems[2].Text;
                    foreach (AtananDers ad in frmAna.atananDersler.ToList())
                    {
                        foreach (Ogretmen ogretmen in ad.ogretmenler.ToList())
                        {
                            if (ogretmen.kod == kod)
                            {
                                ad.ders.tds -= ad.tds;
                                foreach (var item in ad.derslikler)
                                {
                                    item.tds -= ad.tds;
                                }
                                foreach (var item in ad.siniflar)
                                {
                                    item.tds -= ad.tds;
                                }
                                foreach (DersBlogu db in frmAna.dersBloklari.ToList())
                                {
                                    if (db.atananDers == ad)
                                    {
                                        frmAna.dersBloklari.Remove(db);
                                    }
                                }
                                frmAna.atananDersler.Remove(ad);
                                
                                break;
                            }
                        }
                    }
                    foreach (var item in frmAna.ogretmenler.ToList())
                    {
                        if (item.kod == kod)
                        {
                            frmAna.ogretmenler.Remove(item);
                        }
                    }
                    break;
                default:
                    break;
            }
            VerileriYenile();
        }

        private void btnDersAtamasi_Click(object sender, EventArgs e)
        {
            frmAtananDersler frmAtananDersler;

            switch (islem)
            {
                case Islem.Ders:
                    if (lvwDersler.SelectedItems.Count < 1) { return; }
                    Ders secilenDers = frmAna.dersler.Where(drs => drs.kod == lvwDersler.SelectedItems[0].SubItems[1].Text).First();
                    frmAtananDersler = new frmAtananDersler(secilenDers); frmAtananDersler.ShowDialog();
                    break;

                case Islem.Sinif:
                    if (lvwSiniflar.SelectedItems.Count < 1) { return; }
                    Sinif secilenSinif = frmAna.siniflar.Where(snf => snf.kod == lvwSiniflar.SelectedItems[0].SubItems[1].Text).First();
                    frmAtananDersler = new frmAtananDersler(secilenSinif); frmAtananDersler.ShowDialog();
                    break;

                case Islem.Derslik:
                    if (lvwDerslikler.SelectedItems.Count < 1) { return; }
                    Derslik secilenDerslik = frmAna.derslikler.Where(drslik => drslik.kod == lvwDerslikler.SelectedItems[0].SubItems[1].Text).First();
                    frmAtananDersler = new frmAtananDersler(secilenDerslik); frmAtananDersler.ShowDialog();
                    break;

                case Islem.Ogretmen:
                    if (lvwOgretmenler.SelectedItems.Count < 1) { return; }
                    Ogretmen secilenOgretmen = frmAna.ogretmenler.Where(ogr => ogr.kod == lvwOgretmenler.SelectedItems[0].SubItems[2].Text).First();
                    frmAtananDersler = new frmAtananDersler(secilenOgretmen); frmAtananDersler.ShowDialog();
                    break;

                default: break;
            }
            VerileriYenile();
        }

        private void btnZamanTablosu_Click(object sender, EventArgs e)
        {
            frmZamanTablosu frmZamanTablosu;

            switch (islem)
            {
                case Islem.Ders:
                    if (lvwDersler.SelectedItems.Count < 1) { return; }
                    Ders secilenDers = frmAna.dersler.Where(drs => drs.kod == lvwDersler.SelectedItems[0].SubItems[1].Text).First();
                    frmZamanTablosu = new frmZamanTablosu(secilenDers.ad, secilenDers.uygunZamanlar); frmZamanTablosu.ShowDialog();
                    //secilenDers.uygunZamanlar = frmZamanTablosu.zamanMatrisi;
                    break;

                case Islem.Sinif:
                    if (lvwSiniflar.SelectedItems.Count < 1) { return; }
                    Sinif secilenSinif = frmAna.siniflar.Where(snf => snf.kod == lvwSiniflar.SelectedItems[0].SubItems[1].Text).First();
                    frmZamanTablosu = new frmZamanTablosu(secilenSinif.ad, secilenSinif.uygunZamanlar); frmZamanTablosu.ShowDialog();
                    //secilenSinif.uygunZamanlar = frmZamanTablosu.zamanMatrisi;
                    break;

                case Islem.Derslik:
                    if (lvwDerslikler.SelectedItems.Count < 1) { return; }
                    Derslik secilenDerslik = frmAna.derslikler.Where(drslik => drslik.kod == lvwDerslikler.SelectedItems[0].SubItems[1].Text).First();
                    frmZamanTablosu = new frmZamanTablosu(secilenDerslik.ad, secilenDerslik.uygunZamanlar); frmZamanTablosu.ShowDialog();
                    //secilenDerslik.uygunZamanlar = frmZamanTablosu.zamanMatrisi;
                    break;

                case Islem.Ogretmen:
                    if (lvwOgretmenler.SelectedItems.Count < 1) { return; }
                    Ogretmen secilenOgretmen = frmAna.ogretmenler.Where(ogr => ogr.kod == lvwOgretmenler.SelectedItems[0].SubItems[2].Text).First();
                    frmZamanTablosu = new frmZamanTablosu(secilenOgretmen.ad + " " + secilenOgretmen.soyad, secilenOgretmen.uygunZamanlar); frmZamanTablosu.ShowDialog();
                    //secilenOgretmen.uygunZamanlar = frmZamanTablosu.zamanMatrisi;
                    break;

                default: break;
            }
        }

        private void btnKısıtlamalar_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case Islem.Ders:
                    if (lvwDersler.SelectedItems.Count < 1) { return; }
                    Ders secilenDers = frmAna.dersler.Where(drs => drs.kod == lvwDersler.SelectedItems[0].SubItems[1].Text).First();
                    frmKisitlamaDers frmKD = new frmKisitlamaDers(secilenDers); frmKD.ShowDialog();
                    break;
                case Islem.Ogretmen:
                    if (lvwOgretmenler.SelectedItems.Count < 1) { return; }
                    Ogretmen secilenOgretmen = frmAna.ogretmenler.Where(ogr => ogr.kod == lvwOgretmenler.SelectedItems[0].SubItems[2].Text).First();
                    frmKisitlamaOgretmen frmKO = new frmKisitlamaOgretmen(secilenOgretmen); frmKO.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        #endregion pnlSag

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
