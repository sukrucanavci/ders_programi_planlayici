using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmKisitlamaDers : Form
    {
        Ders ders;
        List<string> aciklamalar = new List<string>(new string[] { 
        "Ders bloklar aynı günde olabilir",
        "Ders blokları günlere ayrı ayrı dağılmalı",
        "İki ders bloğu arasında en az 1 gün ara verilmeli",
        "İki ders bloğu arasında en az 2 gün ara verilmeli"
        });
        public frmKisitlamaDers(Ders ders)
        {
            InitializeComponent();
            this.Text += ders.ad;
            this.ders = ders;
            chkSanalDers.Checked = ders.sanalDers;

            trbDagilimKisitlamasi.Value = (int)ders.kisitlama;
            lblKisitlama.Text = aciklamalar[(int)ders.kisitlama];
        }

        private void trbDagilimKisitlamasi_Scroll(object sender, EventArgs e)
        {
            ders.kisitlama = (Ders.DagilimKisitlamasi)trbDagilimKisitlamasi.Value;

            switch (ders.kisitlama)
            {
                case Ders.DagilimKisitlamasi.tumBloklarAyniGundeOlabilir:
                    lblKisitlama.Text = aciklamalar[0];
                    break;
                case Ders.DagilimKisitlamasi.bloklarTumGunlereDagitilmali:
                    lblKisitlama.Text = aciklamalar[1];
                    break;
                case Ders.DagilimKisitlamasi.ikiBlokArasindaEnAz1GunAraVerilmeli:
                    lblKisitlama.Text = aciklamalar[2];
                    break;
                case Ders.DagilimKisitlamasi.ikiBlokArasindaEnAz2GunAraVerilmeli:
                    lblKisitlama.Text = aciklamalar[3];
                    break;
                default:
                    break;
            }
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tüm derslere bu dağılım ayarını uygulamak istiyor musunuz?", "Tümüne Uygula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) { return; } 

            foreach (var item in frmAna.dersler)
            {
                item.kisitlama = (Ders.DagilimKisitlamasi)trbDagilimKisitlamasi.Value;
            }
        }

        private void chkSanalDers_CheckedChanged(object sender, EventArgs e)
        {
            ders.sanalDers = chkSanalDers.Checked;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
