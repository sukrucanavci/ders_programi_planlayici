namespace Ders_Programı_Planlayıcı
{
    public class DersBlogu
    {
        public AtananDers atananDers;

        public bool eklendi;

        public int gun;
        public int saat;
        public int uzunluk;
        public int doluluk;
        public LabelKart kart;

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
            kart = new LabelKart(this);
            frmAna.dersBloklari.Add(this);
        }
    }
}
