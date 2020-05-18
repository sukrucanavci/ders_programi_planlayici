using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmDersAtama : Form
    {
        void VerileriYukle()
        {
            foreach (var sinif in frmAna.siniflar)
                lstSiniflar.Items.Add(sinif.ad);

            foreach (var ogretmen in frmAna.ogretmenler)
                lstOgretmenler.Items.Add(ogretmen.ad + " " + ogretmen.soyad);

            foreach (var ders in frmAna.dersler)
                cmbDersler.Items.Add(ders.ad);

            foreach (var derslik in frmAna.derslikler)
                lstDerslikler.Items.Add(derslik.ad);

            foreach (var dagilimSekli in frmAna.dagilimSekilleri)
                cmbDagilim.Items.Add(dagilimSekli);
        }


        public frmDersAtama(AtananDers atananDers)
        {
            InitializeComponent();
            VerileriYukle();

            foreach (var sinif in atananDers.siniflar)
                lstSiniflar.SelectedItems.Add(sinif.ad);

            foreach (var ogretmen in atananDers.ogretmenler)
                lstOgretmenler.SelectedItems.Add(ogretmen.ad + " " + ogretmen.soyad);

            foreach (var derslik in atananDers.derslikler)
                lstDerslikler.SelectedItems.Add(derslik.ad);

            cmbDersler.SelectedItem = atananDers.ders.ad;
            cmbDagilim.Text = atananDers.dagilimSekli;

            btnTamam.Click += new EventHandler(Guncelle);
            void Guncelle(object sender, EventArgs e)
            {
                int oncekiUzunluk = atananDers.tds;
                atananDers.siniflar.Clear();
                atananDers.ogretmenler.Clear();
                atananDers.derslikler.Clear();

                foreach (var item in lstSiniflar.SelectedItems)
                {
                    foreach (var sinif in frmAna.siniflar)
                    {
                        if (item.ToString() == sinif.ad)
                        {
                            atananDers.siniflar.Add(sinif);
                            break;
                        }
                    }
                }

                foreach (var item in lstOgretmenler.SelectedItems)
                {
                    foreach (var ogretmen in frmAna.ogretmenler)
                    {
                        if (item.ToString() == ogretmen.ad + " " + ogretmen.soyad)
                        {
                            atananDers.ogretmenler.Add(ogretmen);
                            break;
                        }
                    }
                }

                foreach (var item in lstDerslikler.SelectedItems)
                {
                    foreach (var derslik in frmAna.derslikler)
                    {
                        if (item.ToString() == derslik.ad)
                        {
                            atananDers.derslikler.Add(derslik);
                            break;
                        }
                    }
                }

                atananDers.dagilimSekli = cmbDagilim.Text;
                atananDers.ders = frmAna.dersler.Where(ders => ders.ad == cmbDersler.Text).First();
                
                Close();
            }
        }

        public frmDersAtama(Ders ders)
        {
            InitializeComponent();
            VerileriYukle();
            cmbDersler.Text = ders.ad;
            cmbDagilim.Text = ders.dagilimSekli;

            btnTamam.Click += new EventHandler(Olustur);
        }

        public frmDersAtama(Sinif sinif)
        {
            InitializeComponent();
            VerileriYukle();
            lstSiniflar.SelectedItem = sinif.ad;

            btnTamam.Click += new EventHandler(Olustur);
        }

        public frmDersAtama(Derslik derslik)
        {
            InitializeComponent();
            VerileriYukle();
            lstDerslikler.SelectedItem = derslik.ad;

            btnTamam.Click += new EventHandler(Olustur);
        }

        public frmDersAtama(Ogretmen ogretmen)
        {
            InitializeComponent();
            VerileriYukle();
            lstOgretmenler.SelectedItem = ogretmen.ad + " " + ogretmen.soyad;

            btnTamam.Click += new EventHandler(Olustur);
        }


        void Olustur(object sender, EventArgs e)
        {
            AtananDers atananDers;

            if (lstSiniflar.SelectedItems.Count < 1 || lstOgretmenler.SelectedItems.Count < 1 ||
                cmbDersler.Text == "" || lstDerslikler.SelectedItems.Count < 1 || cmbDagilim.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurmadan ders atayamazsınız!");
                return;
            }

            Ders ders = null;
            List<Ogretmen> ogretmenler = new List<Ogretmen>();
            List<Sinif> siniflar = new List<Sinif>();
            List<Derslik> derslikler = new List<Derslik>();
            int atananDersUzunlugu = int.Parse(cmbDagilim.Text);//BUG

            foreach (var item in lstOgretmenler.SelectedItems)
                foreach (var ogrtmn in frmAna.ogretmenler)
                    if (item.ToString() == ogrtmn.ad + " " + ogrtmn.soyad) 
                    { 
                        ogretmenler.Add(ogrtmn);
                        ogrtmn.tds += atananDersUzunlugu;
                        break; 
                    }

            foreach (var item in lstSiniflar.SelectedItems)
                foreach (var snf in frmAna.siniflar)
                    if (item.ToString() == snf.ad) 
                    { 
                        siniflar.Add(snf);
                        snf.tds += atananDersUzunlugu;
                        break; 
                    }

            foreach (var drs in frmAna.dersler)
                if (cmbDersler.Text == drs.ad) {
                    ders = drs;
                    drs.tds += atananDersUzunlugu;
                    break; 
                }

            foreach (var item in lstDerslikler.SelectedItems)
                foreach (var drslk in frmAna.derslikler)
                    if (item.ToString() == drslk.ad) {
                        derslikler.Add(drslk);
                        drslk.tds += atananDersUzunlugu;
                        break; 
                    }

            atananDers = new AtananDers(ders, ogretmenler, siniflar, derslikler, cmbDagilim.Text);
            Close();
        }

    }
}
