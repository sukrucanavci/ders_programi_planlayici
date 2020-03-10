using System.Collections.Generic;

namespace Ders_Programı_Planlayıcı
{
    public class Sinif
    {
        public string ad;
        public string kod;
        public int tds;
        
        public bool[,] uygunZamanlar = new bool[frmAna.gunSayisi, frmAna.gunlukDersSayisi];
        public bool[,] bosSaatler = new bool[frmAna.gunSayisi, frmAna.gunlukDersSayisi];

        /// <summary>
        /// Sınıf, Bölüm
        /// </summary>
        /// <param name="ad">Sınıfın adı</param>
        /// <param name="kod">Sınıfın kısa kodu</param>
        /// <param name="renk">Sınıfın tabloda gözükecek rengi</param>
        /// <param name="ogretmen">Sınıftan sorumlu öğretmen</param>
        public Sinif(string ad, string kod)
        {
            this.ad = ad;
            this.kod = kod;

            for (int i = 0; i < frmAna.gunSayisi; i++)
                for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                { uygunZamanlar[i, j] = true; bosSaatler[i, j] = true; }
        }
    }
}
