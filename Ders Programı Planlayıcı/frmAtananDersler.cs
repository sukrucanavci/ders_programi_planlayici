using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmAtananDersler : Form
    {
        Hashtable hashTable = new Hashtable();

        public frmAtananDersler(Ders ders)
        {
            InitializeComponent();
            lblAd.Text = ders.ad;
            lblKod.Text = ders.kod;
            lblImage.Image = Properties.Resources.ders64px; 

            Listele();
            void Listele()
            {
                dgwAtananDersler.Rows.Clear();
                hashTable.Clear();

                int sayac = 0;
                foreach (var atananDers in frmAna.atananDersler)
                {
                    if (atananDers.ders != ders) { continue; }

                    String dvOgretmenler = "";
                    foreach (var ogrtmn in atananDers.ogretmenler)
                        dvOgretmenler += ogrtmn.ad + " " + ogrtmn.soyad + " ";

                    String dvSiniflar = "";
                    foreach (var snf in atananDers.siniflar)
                        dvSiniflar += snf.ad + " ";

                    String dvDerslikler = "";
                    foreach (var drslk in atananDers.derslikler)
                        dvDerslikler += drslk.ad + " ";

                    dgwAtananDersler.Rows.Add(ders.kod, ders.ad, dvOgretmenler, dvSiniflar, atananDers.dagilimSekli, dvDerslikler);
                    dgwAtananDersler.Rows[sayac].Cells[0].Style.BackColor = frmAna.dersBloklari.Where(db => db.atananDers == atananDers).First().atananDers.ogretmenler[0].renk;
                    sayac++;

                    hashTable.Add(dgwAtananDersler.Rows[dgwAtananDersler.Rows.Count-1], atananDers);
                }
            }

            btnYeniDers.Click += new EventHandler(YeniDersAta);
            void YeniDersAta(object sender, EventArgs e)
            {
                frmDersAtama frmDersAtama = new frmDersAtama(ders);
                frmDersAtama.ShowDialog();
                Listele();
            }

            btnGuncelle.Click += new EventHandler(Guncelle);
            void Guncelle(object sender, EventArgs e)
            {
                if (dgwAtananDersler.SelectedRows.Count < 1) { return; }
                frmDersAtama frmDersAtama = new frmDersAtama((AtananDers)hashTable[dgwAtananDersler.SelectedRows[0]]);
                frmDersAtama.ShowDialog();
                Listele();
            }
        }

        public frmAtananDersler(Sinif sinif)
        {
            InitializeComponent();
            lblAd.Text = sinif.ad;
            lblKod.Text = sinif.kod;
            lblImage.Image = Properties.Resources.sinif64px;

            Listele();
            void Listele()
            {
                dgwAtananDersler.Rows.Clear();
                hashTable.Clear();

                int sayac = 0;
                foreach (var atananDers in frmAna.atananDersler)
                {
                    if (!atananDers.siniflar.Any(s => s.kod == sinif.kod)) { continue; }

                    String dvOgretmenler = "";
                    foreach (var ogrtmn in atananDers.ogretmenler)
                        dvOgretmenler += ogrtmn.ad + " " + ogrtmn.soyad + " ";

                    String dvSiniflar = "";
                    foreach (var snf in atananDers.siniflar)
                        dvSiniflar += snf.ad + " ";

                    String dvDerslikler = "";
                    foreach (var drslk in atananDers.derslikler)
                        dvDerslikler += drslk.ad + " ";

                    dgwAtananDersler.Rows.Add(atananDers.ders.kod, atananDers.ders.ad, dvOgretmenler, dvSiniflar, atananDers.dagilimSekli, dvDerslikler);
                    dgwAtananDersler.Rows[sayac].Cells[0].Style.BackColor = frmAna.dersBloklari.Where(db => db.atananDers == atananDers).First().atananDers.ogretmenler[0].renk; sayac++;

                    hashTable.Add(dgwAtananDersler.Rows[dgwAtananDersler.Rows.Count - 1], atananDers);
                }
            }

            btnYeniDers.Click += new EventHandler(YeniDersAta);
            void YeniDersAta(object sender, EventArgs e)
            {
                frmDersAtama frmDersAtama = new frmDersAtama(sinif);
                frmDersAtama.ShowDialog();
                Listele();
            }

            btnGuncelle.Click += new EventHandler(Guncelle);
            void Guncelle(object sender, EventArgs e)
            {
                if (dgwAtananDersler.SelectedRows.Count < 1) { return; }
                frmDersAtama frmDersAtama = new frmDersAtama((AtananDers)hashTable[dgwAtananDersler.SelectedRows[0]]);
                frmDersAtama.ShowDialog();
                Listele();
            }
        }

        public frmAtananDersler(Derslik derslik)
        {
            InitializeComponent();
            lblAd.Text = derslik.ad;
            lblKod.Text = derslik.kod;
            lblImage.Image = Properties.Resources.derslik64px;

            Listele();
            void Listele()
            {
                dgwAtananDersler.Rows.Clear();
                hashTable.Clear();

                int sayac = 0;
                foreach (var atananDers in frmAna.atananDersler)
                {
                    if (!atananDers.derslikler.Any(drslk => drslk.kod == derslik.kod)) { continue; }

                    String dvOgretmenler = "";
                    foreach (var ogrtmn in atananDers.ogretmenler)
                        dvOgretmenler += ogrtmn.ad + " " + ogrtmn.soyad + " ";

                    String dvSiniflar = "";
                    foreach (var snf in atananDers.siniflar)
                        dvSiniflar += snf.ad + " ";

                    String dvDerslikler = "";
                    foreach (var drslik in atananDers.derslikler)
                        dvDerslikler += drslik.ad + " ";

                    dgwAtananDersler.Rows.Add(atananDers.ders.kod, atananDers.ders.ad, dvOgretmenler, dvSiniflar, atananDers.dagilimSekli, dvDerslikler);
                    dgwAtananDersler.Rows[sayac].Cells[0].Style.BackColor = frmAna.dersBloklari.Where(db => db.atananDers == atananDers).First().atananDers.ogretmenler[0].renk; sayac++;
                   
                    hashTable.Add(dgwAtananDersler.Rows[dgwAtananDersler.Rows.Count - 1], atananDers);
                }
            }

            btnYeniDers.Click += new EventHandler(YeniDersAta);
            void YeniDersAta(object sender, EventArgs e)
            {
                frmDersAtama frmDersAtama = new frmDersAtama(derslik);
                frmDersAtama.ShowDialog();
                Listele();
            }

            btnGuncelle.Click += new EventHandler(Guncelle);
            void Guncelle(object sender, EventArgs e)
            {
                if (dgwAtananDersler.SelectedRows.Count < 1) { return; }
                frmDersAtama frmDersAtama = new frmDersAtama((AtananDers)hashTable[dgwAtananDersler.SelectedRows[0]]);
                frmDersAtama.ShowDialog();
                Listele();
            }
        }

        public frmAtananDersler(Ogretmen ogretmen)
        {
            InitializeComponent();
            lblAd.Text = ogretmen.ad + " " + ogretmen.soyad;
            lblKod.Text = ogretmen.kod;
            lblImage.Image = Properties.Resources.ogretmen64px;

            Listele();
            void Listele()
            {
                dgwAtananDersler.Rows.Clear();
                hashTable.Clear();

                int sayac = 0;
                foreach (var atananDers in frmAna.atananDersler)
                {
                    if (!atananDers.ogretmenler.Any(o => o.kod == ogretmen.kod)) { continue; }

                    String dvOgretmenler = "";
                    foreach (var ogrtmn in atananDers.ogretmenler)
                        dvOgretmenler += ogrtmn.ad + " " + ogrtmn.soyad + " ";

                    String dvSiniflar = "";
                    foreach (var snf in atananDers.siniflar)
                        dvSiniflar += snf.ad + " ";

                    String dvDerslikler = "";
                    foreach (var drslk in atananDers.derslikler)
                        dvDerslikler += drslk.ad + " ";

                    dgwAtananDersler.Rows.Add(atananDers.ders.kod, atananDers.ders.ad, dvOgretmenler, dvSiniflar, atananDers.dagilimSekli, dvDerslikler);
                    dgwAtananDersler.Rows[sayac].Cells[0].Style.BackColor = frmAna.dersBloklari.Where(db => db.atananDers == atananDers).First().atananDers.ogretmenler[0].renk;
                    sayac++;

                    hashTable.Add(dgwAtananDersler.Rows[dgwAtananDersler.Rows.Count - 1], atananDers);
                }
            }

            btnYeniDers.Click += new EventHandler(YeniDersAta);
            void YeniDersAta(object sender, EventArgs e)
            {
                frmDersAtama frmDersAtama = new frmDersAtama(ogretmen);
                frmDersAtama.ShowDialog();
                Listele();
            }

            btnGuncelle.Click += new EventHandler(Guncelle);
            void Guncelle(object sender, EventArgs e)
            {
                if (dgwAtananDersler.SelectedRows.Count < 1) { return; }
                frmDersAtama frmDersAtama = new frmDersAtama((AtananDers)hashTable[dgwAtananDersler.SelectedRows[0]]);
                frmDersAtama.ShowDialog();
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgwAtananDersler.SelectedRows.Count < 1) { return; }

            AtananDers atananDers = (AtananDers)hashTable[dgwAtananDersler.SelectedRows[0]];

            frmAna.atananDersler.Remove(atananDers);
            hashTable.Remove(dgwAtananDersler.SelectedRows[0]);
            dgwAtananDersler.Rows.RemoveAt(dgwAtananDersler.SelectedRows[0].Index);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
