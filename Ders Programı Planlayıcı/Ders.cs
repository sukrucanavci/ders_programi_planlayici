using System.Collections.Generic;

namespace Ders_Programı_Planlayıcı
{
    public class Ders
    {
        public enum DagilimKisitlamasi
        {
            tumBloklarAyniGundeOlabilir,
            bloklarTumGunlereDagitilmali,
            ikiBlokArasindaEnAz1GunAraVerilmeli,
            ikiBlokArasindaEnAz2GunAraVerilmeli
        }

        public string ad;
        public string kod;
        public string dagilimSekli;
        public int tds = 0; //Toplam ders saati
        public bool sanalDers = false;
        public DagilimKisitlamasi kisitlama;

        public bool[,] uygunZamanlar = new bool[frmAna.gunSayisi, frmAna.gunlukDersSayisi];

        
        /// <summary>
        /// Ders oluşturmak için gereken class
        /// </summary>
        /// <param name="ad">Dersin adı</param>
        /// <param name="kod">Dersin kısa kodu</param>
        /// <param name="renk">Dersin tabloda gösterileceği rengi</param>
        /// <param name="derslikler">Dersin işlenmesi gereken derslikler</param>
        /// <param name="dagilimSekli">Dersin varsayılan dağılım şekli, ders ataması yapılırken değiştirilebilir</param>
        public Ders(string ad, string kod, string dagilimSekli = "")
        {
            this.ad = ad;
            this.kod = kod;
            this.dagilimSekli = dagilimSekli;

            kisitlama = DagilimKisitlamasi.bloklarTumGunlereDagitilmali;

            for (int i = 0; i < frmAna.gunSayisi; i++)
                for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                    uygunZamanlar[i, j] = true;
        }
    }
}
