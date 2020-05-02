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
        public LabelKart kart;
        public List<LabelKart> kartlar = new List<LabelKart>();

        /// <summary>
        /// Dağılım kısıtlaması sayacı
        /// </summary>
        public int dksayac = 0;

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
                kart = new LabelKart(this);
                kartlar.Add(kart);
            }
            frmAna.dersBloklari.Add(this);
        }
    }
}
