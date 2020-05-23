using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmParametre : Form
    {
        public frmParametre()
        {
            InitializeComponent();

            #region Görsel Ayarlar

            tabSihirbaz.Appearance = TabAppearance.FlatButtons;
            tabSihirbaz.ItemSize = new Size(0, 1);
            tabSihirbaz.SizeMode = TabSizeMode.Fixed;

            #endregion
        }

        public static bool veriCekildi = false;

        private void frmParametre_Load(object sender, EventArgs e)
        {
            cmbGunSayisi.SelectedIndex = 4;
            cmbGunlukDersSayisi.SelectedIndex = 7;
            cmbOgleArasiZamani.SelectedIndex = 3;
        }

        #region Parametre İşlemleri

        private void cmbGunSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenGunSayisi = cmbGunSayisi.SelectedIndex + 1;

            if (frmAna.gunSayisi > secilenGunSayisi)
            {
                frmAna.secilenGunler.RemoveRange(secilenGunSayisi, frmAna.gunSayisi - secilenGunSayisi);
            }
            else if (frmAna.gunSayisi < secilenGunSayisi)
            {
                frmAna.secilenGunler.AddRange(frmAna.haftaninGunleri.GetRange(frmAna.gunSayisi, secilenGunSayisi - frmAna.gunSayisi));
            }

            frmAna.gunSayisi = secilenGunSayisi;
        }

        private void cmbGunlukDersSayisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmAna.gunlukDersSayisi = cmbGunlukDersSayisi.SelectedIndex + 1;

            cmbOgleArasiZamani.Items.Clear();
            for (int saat = 1; saat < frmAna.gunlukDersSayisi; saat++)
                cmbOgleArasiZamani.Items.Add(saat);
        }

        private void chkOgleArasi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOgleArasi.Checked)
            {
                frmAna.ogleArasiVar = true;
                cmbOgleArasiZamani.SelectedIndex = 0;
            }
            else
            {
                frmAna.ogleArasiVar = false; ;
                frmAna.ogleArasiBlokDersleriBolebilir = false;
                chkDerslerOgleArasindaBolunebilir.Checked = false;
            }

            cmbOgleArasiZamani.Enabled = chkOgleArasi.Checked ? true : false;
            cmbOgleArasiZamani.Visible = chkOgleArasi.Checked ? true : false;
            lblKacinciDerstenSonra.Visible = chkOgleArasi.Checked ? true : false;
            chkDerslerOgleArasindaBolunebilir.Visible = chkOgleArasi.Checked ? true : false;
        }

        private void cmbOgleArasiZamani_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmAna.ogleArasiKacinciDerstenSonra = cmbOgleArasiZamani.SelectedIndex;
        }

        private void chkDerslerOgleArasindaBolunebilir_CheckedChanged(object sender, EventArgs e)
        {
            frmAna.ogleArasiBlokDersleriBolebilir = chkDerslerOgleArasindaBolunebilir.Checked ? true : false;
        }

        private void btnDersSaatleriniDuzenle_Click(object sender, EventArgs e)
        {
            frmSaat frmSaat = new frmSaat();
            frmSaat.ShowDialog();
        }

        private void btnHaftaninGunleriniGuncelle_Click(object sender, EventArgs e)
        {
            frmGunler frmGunler = new frmGunler();
            frmGunler.ShowDialog();
        }

        #endregion

        #region Veritabanı

        private void btnBaglanVerileriCek_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();

            if (rdoWinAuto.Checked)
            {
                baglanti.ConnectionString = @"Server=" + txtServerAdresi.Text + ";Database=" + txtVeritabaniAdi.Text + ";Integrated Security=true;MultipleActiveResultSets=True";
            }
            else
            {
                baglanti.ConnectionString = @"Server=" + txtServerAdresi.Text + ";Database=" +
                    txtVeritabaniAdi.Text + ";User Id=" + txtKullaniciAdi.Text + ";Password=" + txtSifre.Text + ";MultipleActiveResultSets=True";
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;
            try
            {
                baglanti.Open();
            }
            catch (Exception)
            {
                return;
            }

            //

            frmAna.server = txtServerAdresi.Text;
            frmAna.veritabani = txtVeritabaniAdi.Text;
            frmAna.kullaniciAdi = txtKullaniciAdi.Text;
            frmAna.sifre = txtSifre.Text;
            frmAna.winAuto = rdoWinAuto.Checked;

            //



            cmd.CommandText = "SELECT * FROM ders_saatleri";
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = cmd;
            frmAna.dtDersSaatleri.Clear();
            frmAna.dtDersSaatleri.Columns.Clear();
            sda.Fill(frmAna.dtDersSaatleri);
            frmAna.gunlukDersSayisi = frmAna.dtDersSaatleri.Rows.Count;
            cmbGunlukDersSayisi.SelectedIndex = frmAna.gunlukDersSayisi - 1;

            cmd.CommandText = "select max(gun_sayisi) from parametreler";
            frmAna.gunSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            cmbGunSayisi.Text = frmAna.gunSayisi.ToString();

            cmd.CommandText = "select max(gunluk_ders_sayisi) from parametreler";
            frmAna.gunlukDersSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            cmbGunlukDersSayisi.Text = frmAna.gunlukDersSayisi.ToString();

            cmd.CommandText = "SELECT * FROM dersler";
            SqlDataReader dr = cmd.ExecuteReader();
            Ders ders;
            while (dr.Read())
            {
                string ad = dr["ad"].ToString().Trim();
                string kod = dr["ders_kodu"].ToString().Trim();
                string dagilim = dr["dagilim_sekli"].ToString().Trim();
                string zaman = dr["zaman"].ToString().Trim();
                ders = new Ders(ad, kod, dagilim);
                if (zaman != "")
                {
                    for (int i = 0; i < frmAna.gunSayisi; i++)
                        for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                            if (zaman[i * frmAna.gunlukDersSayisi + j] == '0')
                                ders.uygunZamanlar[i, j] = false;
                }
                frmAna.dersler.Add(ders);
            }
            dr.Close();
            
            cmd.CommandText = "SELECT * FROM siniflar";
            dr = cmd.ExecuteReader();
            Sinif sinif;
            while (dr.Read())
            {
                string ad = dr["ad"].ToString().Trim();
                string kod = dr["sinif_kodu"].ToString().Trim();
                string zaman = dr["zaman"].ToString().Trim();
                sinif = new Sinif(ad, kod);
                if (zaman != "")
                {
                    for (int i = 0; i < frmAna.gunSayisi; i++)
                        for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                            if (zaman[i * frmAna.gunlukDersSayisi + j] == '0')
                                sinif.uygunZamanlar[i, j] = false;
                }
                frmAna.siniflar.Add(sinif);
            }
            dr.Close();

            cmd.CommandText = "SELECT * FROM derslikler";
            dr = cmd.ExecuteReader();
            Derslik derslik;
            while (dr.Read())
            {
                string ad = dr["ad"].ToString().Trim();
                string kod = dr["derslik_kodu"].ToString().Trim();
                string zaman = dr["zaman"].ToString().Trim();
                derslik = new Derslik(ad, kod);
                if (zaman != "")
                {
                    for (int i = 0; i < frmAna.gunSayisi; i++)
                        for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                            if (zaman[i * frmAna.gunlukDersSayisi + j] == '0')
                                derslik.uygunZamanlar[i, j] = false;
                }
                frmAna.derslikler.Add(derslik);
            }
            dr.Close();

            cmd.CommandText = "SELECT * FROM ogretmenler";
            dr = cmd.ExecuteReader();
            Ogretmen ogretmen;
            int r = 0;
            while (dr.Read())
            {
                string ad = dr["ad"].ToString().Trim();
                string soyad = dr["soyad"].ToString().Trim();
                string kod = dr["ogretmen_kodu"].ToString().Trim();
                string zaman = dr["zaman"].ToString().Trim();
                Color renk = frmAna.renkler[r++];
                
                ogretmen = new Ogretmen(ad, soyad, kod, renk);
                if (zaman != "")
                {
                    for (int i = 0; i < frmAna.gunSayisi; i++)
                        for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                            if (zaman[i * frmAna.gunlukDersSayisi + j] == '0')
                                ogretmen.uygunZamanlar[i, j] = false;

                }
                frmAna.ogretmenler.Add(ogretmen);
            }
            dr.Close();

            cmd.CommandText = "SELECT * FROM atanan_dersler";
            dr = cmd.ExecuteReader();
            AtananDers atananDers;
            List<Ogretmen> ogretmenler;
            List<Sinif> siniflar;
            List<Derslik> derslikler;
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.Connection = baglanti;
            SqlDataReader sqlDr;

            while (dr.Read())
            {
                string ad_ID = dr["ad_ID"].ToString().Trim();
                string dersKodu = dr["ders_kodu"].ToString().Trim();
                Ders drs = frmAna.dersler.Where(d => d.kod == dersKodu).First();
                ogretmenler = new List<Ogretmen>();
                siniflar = new List<Sinif>();
                derslikler = new List<Derslik>();
                string dagilim = dr["dagilim_sekli"].ToString().Trim();

                sqlCmd.CommandText = "SELECT * FROM ad_ogretmenler WHERE ad_ID=" + ad_ID;
                sqlDr = sqlCmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    string ogretmen_kodu = sqlDr["ogretmen_kodu"].ToString().Trim();
                    ogretmenler.Add(frmAna.ogretmenler.Where(ogrtmn => ogrtmn.kod == ogretmen_kodu).First());
                }
                sqlDr.Close();

                sqlCmd.CommandText = "SELECT * FROM ad_siniflar WHERE ad_ID=" + ad_ID;
                sqlDr = sqlCmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    string sinif_kodu = sqlDr["sinif_kodu"].ToString().Trim();
                    siniflar.Add(frmAna.siniflar.Where(snf => snf.kod == sinif_kodu).First());
                }
                sqlDr.Close();

                sqlCmd.CommandText = "SELECT * FROM ad_derslikler WHERE ad_ID=" + ad_ID;
                sqlDr = sqlCmd.ExecuteReader();
                while (sqlDr.Read())
                {
                    string derslikKodu = sqlDr["derslik_kodu"].ToString().Trim();
                    derslikler.Add(frmAna.derslikler.Where(drslk => drslk.kod == derslikKodu).First());
                }
                sqlDr.Close();

                atananDers = new AtananDers(drs, ogretmenler, siniflar, derslikler, dagilim);
            }
            dr.Close();

            baglanti.Close();
            veriCekildi = true;
            MessageBox.Show("İşlem tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbGunSayisi.Enabled = false;
            cmbGunlukDersSayisi.Enabled = false;
        }

        #endregion

        #region Butonlar

        private void btnTamam_Click(object sender, EventArgs e)
        {
            switch (tabSihirbaz.SelectedIndex)
            {
                case 0:
                    tabSihirbaz.SelectedIndex++;
                    btnTamam.Text = "Tamam";
                    btnGeriDön.Visible = true;
                    break;
                case 1:
                    if (!veriCekildi)
                    {
                        DialogResult ds = MessageBox.Show("Veritabanından veri çekilmeden devam edilsin mi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (ds == DialogResult.No)
                        {
                            return;
                        }
                    }
                    Close();
                    break;
                default:
                    break;
            }
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
        {
            if (tabSihirbaz.SelectedIndex == 1)
            {
                tabSihirbaz.SelectedIndex = 0;
                btnGeriDön.Visible = false;
            }
        }

        private void rdoSqlServerAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSqlServerAuto.Checked == true)
            {
                lblKullaniciAdi.Enabled = true;
                lblSifre.Enabled = true;
                txtKullaniciAdi.Enabled = true;
                txtSifre.Enabled = true;
            }
            else
            {
                lblKullaniciAdi.Enabled = false;
                lblSifre.Enabled = false;
                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
            }
        }

        #endregion
    }
}
