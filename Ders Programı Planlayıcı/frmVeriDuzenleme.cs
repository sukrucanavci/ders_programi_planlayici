using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmVeriDuzenleme : Form
    {
        public frmVeriDuzenleme(frmVeriler.Islem islem)
        {
            InitializeComponent();

            Ders ders;
            Sinif sinif;
            Derslik derslik;
            Ogretmen ogretmen;

            switch (islem)
            {
                case frmVeriler.Islem.Ders:
                    Text = "Ders";
                    lblDagilim.Visible = true;
                    cmbDagilim.Visible = true;

                    btnTamam.Click += new EventHandler(DersOlustur);
                    void DersOlustur(object sender, EventArgs e)
                    {
                        txtAd.Text.Trim(); txtKod.Text.Trim(); cmbDagilim.Text.Trim();

                        if (txtAd.Text == "" || txtKod.Text == "")
                        { MessageBox.Show("Ders adı veya kısa kodu boş bırakılamaz!"); return; };

                        if (frmAna.dersler.Any(s => s.ad == txtAd.Text) || frmAna.dersler.Any(s => s.kod == txtKod.Text))
                        { MessageBox.Show("Benzer isme veya koda sahip ders mevcut!"); return; }

                        ders = new Ders(txtAd.Text, txtKod.Text, cmbDagilim.Text);
                        frmAna.dersler.Add(ders);
                        Close();
                    }
                    
                    break;

                case frmVeriler.Islem.Sinif:
                    Text = "Sınıf";

                    btnTamam.Click += new EventHandler(SinifOlustur);

                    void SinifOlustur(object sender, EventArgs e)
                    {
                        txtAd.Text.Trim(); txtKod.Text.Trim();

                        if (txtAd.Text == "" || txtKod.Text == "")
                        { MessageBox.Show("Sınıf adı veya kısa kodu boş bırakılamaz!"); return; };

                        if (frmAna.siniflar.Any(s => s.ad == txtAd.Text) || frmAna.siniflar.Any(s => s.kod == txtKod.Text))
                        { MessageBox.Show("Benzer isme veya koda sahip sınıf mevcut!"); return; }

                        sinif = new Sinif(txtAd.Text, txtKod.Text);
                        frmAna.siniflar.Add(sinif);
                        this.Close();
                    }
                    
                    break;

                case frmVeriler.Islem.Derslik:
                    Text = "Derslik";

                    btnTamam.Click += new EventHandler(DerslikOlustur);

                    void DerslikOlustur(object sender, EventArgs e)
                    {
                        txtAd.Text.Trim(); txtKod.Text.Trim();

                        if (txtAd.Text == "" || txtKod.Text == "")
                        { MessageBox.Show("Derslik adı veya kısa kodu boş bırakılamaz!"); return; };

                        if (frmAna.derslikler.Any(s => s.ad == txtAd.Text) || frmAna.derslikler.Any(s => s.kod == txtKod.Text))
                        { MessageBox.Show("Benzer isme veya koda sahip derslik mevcut!"); return; }

                        derslik = new Derslik(txtAd.Text, txtKod.Text);
                        frmAna.derslikler.Add(derslik);
                        this.Close();
                    }
                    
                    break;

                case frmVeriler.Islem.Ogretmen:
                    Text = "Öğretmen";
                    lblSoyad.Visible = true;
                    txtSoyad.Visible = true;
                    grpRenk.Visible = true;

                    btnTamam.Click += new EventHandler(OgretmenOlustur);

                    void OgretmenOlustur(object sender, EventArgs e)
                    {
                        txtAd.Text.Trim(); txtKod.Text.Trim();

                        if (txtAd.Text == "" || txtSoyad.Text == "" || txtKod.Text == "")
                        { MessageBox.Show("Öğretmen adı, soyadı veya kısa kodu boş bırakılamaz!"); return; };

                        if ((frmAna.ogretmenler.Any(s => s.ad == txtAd.Text) && frmAna.ogretmenler.Any(s => s.soyad == txtSoyad.Text)) || frmAna.ogretmenler.Any(s => s.kod == txtKod.Text))
                        { MessageBox.Show("Benzer ad ve soyada veya koda sahip öğretmen mevcut!"); return; }

                        ogretmen = new Ogretmen(txtAd.Text, txtSoyad.Text, txtKod.Text, lblRenk.BackColor);
                        frmAna.ogretmenler.Add(ogretmen);
                        this.Close();
                    }
                    
                    break;
                default:
                    break;
            }
        }

        public frmVeriDuzenleme(Ders ders)
        {
            InitializeComponent();
            Text = "Ders";
            cmbDagilim.Visible = true;
            lblDagilim.Visible = true;

            txtAd.Text = ders.ad;
            txtKod.Text = ders.kod;
            cmbDagilim.Text = ders.dagilimSekli;

            btnTamam.Click += new EventHandler(Uygula);

            void Uygula(object sender, EventArgs e)
            {
                txtAd.Text.Trim(); txtKod.Text.Trim(); cmbDagilim.Text.Trim();

                if (txtAd.Text == "" || txtKod.Text == "")
                { MessageBox.Show("Ders adı veya kısa kodu boş bırakılamaz!"); return; };

                if (frmAna.dersler.Where(d => d.kod != ders.kod).Any(s => s.ad == txtAd.Text) ||
                    frmAna.dersler.Where(d => d.kod != ders.kod).Any(s => s.kod == txtKod.Text))
                { MessageBox.Show("Benzer isme veya koda sahip ders mevcut!"); return; }

                ders.ad = txtAd.Text; ders.kod = txtKod.Text; ders.dagilimSekli = cmbDagilim.Text;
                this.Close();
            }
        }

        public frmVeriDuzenleme(Sinif sinif)
        {
            InitializeComponent();
            Text = "Sınıf";

            txtAd.Text = sinif.ad;
            txtKod.Text = sinif.kod;

            btnTamam.Click += new EventHandler(Uygula);

            void Uygula(object sender, EventArgs e){
                txtAd.Text.Trim(); txtKod.Text.Trim();

                if (txtAd.Text == "" || txtKod.Text == "")
                { MessageBox.Show("Sınıf adı veya kısa kodu boş bırakılamaz!"); return; };

                if (frmAna.siniflar.Where(s => s.kod != sinif.kod).Any(s => s.ad == txtAd.Text) ||
                    frmAna.siniflar.Where(s => s.kod != sinif.kod).Any(s => s.kod == txtKod.Text))
                { MessageBox.Show("Benzer isme veya koda sahip sınıf mevcut!"); return; }

                sinif.ad = txtAd.Text; sinif.kod = txtKod.Text;
                Close();
            }
        }

        public frmVeriDuzenleme(Derslik derslik)
        {
            InitializeComponent();
            Text = "Derslik";

            txtAd.Text = derslik.ad;
            txtKod.Text = derslik.kod;

            btnTamam.Click += new EventHandler(Uygula);

            void Uygula(object sender, EventArgs e)
            {
                txtAd.Text.Trim(); txtKod.Text.Trim();

                if (txtAd.Text == "" || txtKod.Text == "")
                { MessageBox.Show("Derslik adı veya kısa kodu boş bırakılamaz!"); return; };

                if (frmAna.derslikler.Where(d => d.kod != derslik.kod).Any(s => s.ad == txtAd.Text) ||
                    frmAna.derslikler.Where(d => d.kod != derslik.kod).Any(s => s.kod == txtKod.Text))
                { MessageBox.Show("Benzer isme veya koda sahip derslik mevcut!"); return; }

                derslik.ad = txtAd.Text; derslik.kod = txtKod.Text;
                Close();
            }
        }

        public frmVeriDuzenleme(Ogretmen ogretmen)
        {
            InitializeComponent();
            Text = "Öğretmen";
            lblSoyad.Visible = true;
            txtSoyad.Visible = true;
            grpRenk.Visible = true;

            txtAd.Text = ogretmen.ad;
            txtSoyad.Text = ogretmen.soyad;
            txtKod.Text = ogretmen.kod;
            lblRenk.BackColor = ogretmen.renk;

            btnTamam.Click += new EventHandler(Uygula);

            void Uygula(object sender, EventArgs e)
            {
                txtAd.Text.Trim(); txtKod.Text.Trim();

                if (txtAd.Text == "" || txtSoyad.Text == "" || txtKod.Text == "")
                { MessageBox.Show("Öğretmen adı, soyadı veya kısa kodu boş bırakılamaz!"); return; };

                if (frmAna.ogretmenler.Where(o => o.kod != ogretmen.kod).Any(s => s.ad == txtAd.Text && s.soyad != ogretmen.soyad)
                    || frmAna.ogretmenler.Where(o => o.kod != ogretmen.kod).Any(s => s.kod == txtKod.Text))
                { MessageBox.Show("Benzer ad ve soyada veya koda sahip öğretmen mevcut!"); return; }

                ogretmen.ad = txtAd.Text; ogretmen.soyad = txtSoyad.Text; ogretmen.kod = txtKod.Text; ogretmen.renk = lblRenk.BackColor;
                Close();
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = lblRenk.BackColor;
            cd.ShowDialog();
            lblRenk.BackColor = cd.Color;
        }
    }
}
