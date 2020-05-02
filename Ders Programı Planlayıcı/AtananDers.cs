using System;
using System.Collections.Generic;

namespace Ders_Programı_Planlayıcı
{
    public class AtananDers
    {
        public List<Ogretmen> ogretmenler = null;
        public Ders ders;
        public List<Sinif> siniflar = new List<Sinif>();
        public List<Derslik> derslikler = new List<Derslik>();
        public List<DersBlogu> dersBloklari = new List<DersBlogu>();
        

        private string DagilimSekli;
        public string dagilimSekli
        {
            get
            {
                return DagilimSekli;
            }
            set
            {
                DagilimSekli = value;

                List<int> saatler = new List<int>();
                if (DagilimSekli.Contains("*"))
                {
                    int[] p = Array.ConvertAll(DagilimSekli.Split('*'), int.Parse);
                    for (int i = 0; i < p[1]; i++)
                    {
                        saatler.Add(p[0]);
                    }
                }
                else
                {
                    saatler.AddRange(Array.ConvertAll(DagilimSekli.Split('+'), int.Parse));
                }

                int otds = tds; //Önceki toplam ders saati
                tds = 0;
                foreach (var saat in saatler)
                {
                    tds += saat;
                }

                foreach (var ogretmen in ogretmenler)
                {
                    ogretmen.tds += tds - otds;
                }
                foreach (var sinif in siniflar)
                {
                    sinif.tds += tds - otds;
                }
                foreach (var derslik in derslikler)
                {
                    derslik.tds += tds - otds;
                }

                dersBloklari.Clear();
                //Varsa önceden oluşturulan eski ders bloklarını temizle
                for (int i = 0; i < frmAna.dersBloklari.Count; i++)
                {
                    if (frmAna.dersBloklari[i].atananDers == this)
                    {
                        frmAna.dersBloklari.Remove(frmAna.dersBloklari[i]);
                        
                    }
                }

                //Yeni ders bloklarını oluştur
                DersBlogu dersBlogu;
                foreach (var saat in saatler)
                {
                    dersBlogu = new DersBlogu(this, saat);
                    dersBloklari.Add(dersBlogu);
                }
            }
        }

        public int tds;

        /// <summary>
        /// Atanacak ders
        /// </summary>
        /// <param name="ogretmenler">Derse girecek öğretmenler</param>
        /// <param name="ders">Dersin adı/param>
        /// <param name="siniflar">Derse girecek sınıflar</param>
        /// <param name="dagilimSekli">Dersin dağılım şekli</param>
        /// <param name="derslik">Dersin işleneceği derslik</param>
        public AtananDers(Ders ders, List<Ogretmen> ogretmenler, List<Sinif> siniflar, List<Derslik> derslikler, string dagilimSekli)
        {
            this.ogretmenler = ogretmenler;
            this.ders = ders;
            this.siniflar = siniflar;
            this.derslikler = derslikler;
            this.dagilimSekli = dagilimSekli;

            frmAna.atananDersler.Add(this);
        }

    }
}
