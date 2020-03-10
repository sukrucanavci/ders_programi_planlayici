using System.Collections.Generic;
using System.Drawing;

namespace Ders_Programı_Planlayıcı
{
    public class Ogretmen
    {
        public string ad;
        public string soyad;
        public string kod;
        public Color renk;
        public int tds; //Toplam Ders Saati
        public int maxDersGunu = frmAna.gunSayisi;

        public bool[,] uygunZamanlar;
        public bool[,] bosSaatler;

        public Ogretmen(string ad, string soyad, string kod, Color renk)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.kod = kod;
            this.renk = renk;

            uygunZamanlar = new bool[frmAna.gunSayisi, frmAna.gunlukDersSayisi];
            bosSaatler = new bool[frmAna.gunSayisi, frmAna.gunlukDersSayisi];

            for (int i = 0; i < frmAna.gunSayisi; i++)
                for (int j = 0; j < frmAna.gunlukDersSayisi; j++)
                { uygunZamanlar[i, j] = true; bosSaatler[i, j] = true; }
        }

    }
}
