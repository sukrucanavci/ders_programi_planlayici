using System.Collections.Generic;

namespace Ders_Programı_Planlayıcı
{
    public class Derslik
    {
        public string ad;
        public string kod;
        public int tds = 0; //Toplam ders saati

        public bool[,] uygunZamanlar = new bool[frmAna.gunSayisi, frmAna.gunlukDersSayisi];
        public bool[,] bosSaatler = new bool[frmAna.gunSayisi, frmAna.gunlukDersSayisi];

        /// <summary>
        /// Ders işlenen yerler
        /// </summary>
        /// <param name="ad">Dersliğin Adı</param>
        /// <param name="kod">Derliğin Kısa Kodu</param>
        /// <param name="siniflar">Dersliğin ait olduğu sınıflar</param>
        public Derslik(string ad, string kod)
        {
            this.ad = ad;
            this.kod = kod;

            for (int i = 0; i < frmAna.gunSayisi; i++)
                for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                { uygunZamanlar[i, j] = true; bosSaatler[i, j] = true; }
        }

    }
}
