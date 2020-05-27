using System.Collections.Generic;

namespace Ders_Programı_Planlayıcı
{
    public class DersBlogu
    {
        public AtananDers atananDers;

        public bool eklendi;

        public int gun = -1;
        public int saat = -1;
        public int uzunluk;
        public int doluluk;

        public LabelKart kart1;
        public LabelKart kart2;
        public LabelKart kart3;

        public List<LabelKart> sinifKartlar = new List<LabelKart>();
        public List<LabelKart> ogretmenKartlar = new List<LabelKart>();
        public List<LabelKart> derslikKartlar = new List<LabelKart>();

        /// <summary>
        /// Kart dağılım kısıtlaması sayacı
        /// </summary>
        public int dksayac = 0;


        public bool yerlestirilemez = false;

        /// <summary>
        /// Tablolara yerleştirilecek ders kartları
        /// </summary>
        /// <param name="uzunluk">Ders kartının saat uzunluğu</param>
        public DersBlogu(AtananDers atananDers, int uzunluk)
        {
            this.atananDers = atananDers;
            this.uzunluk = uzunluk;

            for (int i = 0; i < atananDers.siniflar.Count; i++)
            {
                kart1 = new LabelKart(this);
                sinifKartlar.Add(kart1);
            }

            for (int i = 0; i < atananDers.ogretmenler.Count; i++)
            {
                kart2 = new LabelKart(this);
                ogretmenKartlar.Add(kart2);
            }

            for (int i = 0; i < atananDers.derslikler.Count; i++)
            {
                kart3 = new LabelKart(this);
                derslikKartlar.Add(kart3);
            }

            frmAna.dersBloklari.Add(this);
        }
    }
}
