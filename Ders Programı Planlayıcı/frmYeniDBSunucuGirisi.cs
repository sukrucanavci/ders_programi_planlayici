using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmYeniDBSunucuGirisi : Form
    {
        public frmYeniDBSunucuGirisi()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if (txtGun.TextLength <= 0 || txtGunlukDers.TextLength <= 0)
            {
                MessageBox.Show("Veritabanının oluşturulabilmesi için tüm boşlukları doldurunuz!");
                return;
            }

            //Haftalık Ders Saati
            int hds = Convert.ToInt32(txtGun.Text) * Convert.ToInt32(txtGunlukDers);

            SqlConnection baglanti = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = baglanti;

            if (rdoWinAuto.Checked)
            {
                baglanti.ConnectionString = "Server = "+ txtServerAdresi.Text +"; database = "+ txtUstVT.Text +"; integrated security = true";
            }
            else
            {
                baglanti.ConnectionString = @"Server=" + txtServerAdresi.Text + ";Database=" +
                    txtUstVT.Text + ";User Id=" + txtKullaniciAdi.Text + ";Password=" + txtSifre.Text;
            }

            try
            {
                baglanti.Open();
                cmd.CommandText = "CREATE DATABASE " + txtVeritabaniAdi.Text;
                cmd.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            //
            frmAna.server = txtServerAdresi.Text;
            frmAna.kullaniciAdi = txtKullaniciAdi.Text;
            frmAna.veritabani = txtVeritabaniAdi.Text;
            frmAna.sifre = txtSifre.Text;
            frmAna.winAuto = rdoWinAuto.Checked;
            //

            try
            {
                baglanti.ConnectionString = "Server = localhost; database = " + txtVeritabaniAdi.Text + "; integrated security = true";
                baglanti.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            cmd.CommandText = "CREATE TABLE parametreler ("+txtGun.Text+" int NOT NULL,"+txtGunlukDers.Text+" int NOT NULL )";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE ad_derslikler (ad_ID int NOT NULL,derslik_kodu nvarchar(10) NOT NULL )";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE ad_ogretmenler (ad_ID int NOT NULL,ogretmen_kodu nvarchar(10) NOT NULL )";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE ad_siniflar (ad_ID int NOT NULL,sinif_kodu nvarchar(10) NOT NULL )";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE atanan_dersler (ad_ID int IDENTITY(1, 1) NOT NULL, ders_kodu  nvarchar(10) NOT NULL, " +
                "dagilim_sekli nvarchar(50) NOT NULL, CONSTRAINT[PK_atanan_dersler] PRIMARY KEY CLUSTERED ([ad_ID] ASC))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE ders_saatleri(ders_saati int NOT NULL, baslangic time(7) NULL,bitis time(7) NULL)";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE dersler (ders_kodu nvarchar(10) NOT NULL, ad nvarchar(50) NOT NULL," +
                "dagilim_sekli nvarchar(50) NULL,zaman nvarchar("+ hds + ") NULL,CONSTRAINT[PK_dersler] PRIMARY KEY CLUSTERED(ders_kodu ASC))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE derslikler(derslik_kodu nvarchar(10) NOT NULL,ad nvarchar(50) NOT NULL," +
                "zaman nvarchar(" + hds + ") NULL,CONSTRAINT[PK_derslikler] PRIMARY KEY CLUSTERED(derslik_kodu ASC))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE ogretmenler(ogretmen_kodu nvarchar(10) NOT NULL,ad nvarchar(50) NOT NULL," +
                "soyad nvarchar(50) NOT NULL,zaman nvarchar(" + hds + ") NULL,CONSTRAINT[PK_ogretmenler] PRIMARY KEY CLUSTERED(ogretmen_kodu ASC))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "CREATE TABLE siniflar(sinif_kodu nvarchar(10) NOT NULL,ad nvarchar(50) NOT NULL,zaman nvarchar(" + hds + ") NULL," +
                "CONSTRAINT[PK_siniflar] PRIMARY KEY CLUSTERED(sinif_kodu ASC))";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "ALTER TABLE [dbo].[ad_derslikler]  WITH CHECK ADD  CONSTRAINT [FK_ad_derslikler_atanan_dersler] FOREIGN KEY([ad_ID])REFERENCES[dbo].[atanan_dersler]([ad_ID]);" +
                "ALTER TABLE[dbo].[ad_derslikler] CHECK CONSTRAINT[FK_ad_derslikler_atanan_dersler];" +
                "ALTER TABLE[dbo].[ad_derslikler]  WITH CHECK ADD CONSTRAINT[FK_ad_derslikler_derslikler] FOREIGN KEY([derslik_kodu])REFERENCES[dbo].[derslikler]([derslik_kodu]);" +
                "ALTER TABLE[dbo].[ad_derslikler] CHECK CONSTRAINT[FK_ad_derslikler_derslikler];" +
                "ALTER TABLE[dbo].[ad_ogretmenler]  WITH CHECK ADD CONSTRAINT[FK_ad_ogretmenler_atanan_dersler] FOREIGN KEY([ad_ID])REFERENCES[dbo].[atanan_dersler]([ad_ID]);" +
                "ALTER TABLE[dbo].[ad_ogretmenler] CHECK CONSTRAINT[FK_ad_ogretmenler_atanan_dersler];" +
                "ALTER TABLE[dbo].[ad_ogretmenler]  WITH CHECK ADD CONSTRAINT[FK_ad_ogretmenler_ogretmenler] FOREIGN KEY([ogretmen_kodu])REFERENCES[dbo].[ogretmenler]([ogretmen_kodu]);" +
                "ALTER TABLE[dbo].[ad_ogretmenler] CHECK CONSTRAINT[FK_ad_ogretmenler_ogretmenler];" +
                "ALTER TABLE[dbo].[ad_siniflar]  WITH CHECK ADD CONSTRAINT[FK_ad_siniflar_atanan_dersler] FOREIGN KEY([ad_ID])REFERENCES[dbo].[atanan_dersler]([ad_ID]);" +
                "ALTER TABLE[dbo].[ad_siniflar] CHECK CONSTRAINT[FK_ad_siniflar_atanan_dersler];" +
                "ALTER TABLE[dbo].[ad_siniflar]  WITH CHECK ADD CONSTRAINT[FK_ad_siniflar_siniflar] FOREIGN KEY([sinif_kodu])REFERENCES[dbo].[siniflar]([sinif_kodu]);" +
                "ALTER TABLE[dbo].[ad_siniflar] CHECK CONSTRAINT[FK_ad_siniflar_siniflar];" +
                "ALTER TABLE[dbo].[atanan_dersler]  WITH CHECK ADD CONSTRAINT[FK_atanan_dersler_dersler] FOREIGN KEY([ders_kodu])REFERENCES[dbo].[dersler]([ders_kodu]);" +
                "ALTER TABLE[dbo].[atanan_dersler] CHECK CONSTRAINT[FK_atanan_dersler_dersler];";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Veritabanı başarılı bir şekilde oluşturuldu.");
            Close();
        }

        private void rdoSqlServerAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSqlServerAuto.Checked == true)
            {
                lblKullaniciAdi.Enabled = true;
                lblSifre.Enabled = true;
                txtKullaniciAdi.Enabled = true;
                txtSifre.Enabled = true;
                frmAna.frmParametre.rdoSqlServerAuto.Checked = true;
            }
            else
            {
                lblKullaniciAdi.Enabled = false;
                lblSifre.Enabled = false;
                txtKullaniciAdi.Enabled = false;
                txtSifre.Enabled = false;
                frmAna.frmParametre.rdoWinAuto.Checked = true;
            }
        }
    }
}
