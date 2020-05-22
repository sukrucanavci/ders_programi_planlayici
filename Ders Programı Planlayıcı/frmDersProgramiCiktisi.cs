using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmDersProgramiCiktisi : Form
    {
        public frmDersProgramiCiktisi()
        {
            InitializeComponent();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = true;
            Word.Document doc;
            object objMissing = System.Reflection.Missing.Value;
            object dokumanSonu = "\\endofdoc";
            doc = wordApp.Documents.Add(ref objMissing);

            for (int i = 0; i < frmAna.dbSinif.GetLength(0); i++)
            {
                int sayac = 0;

                #region Üst başlık ve açıklama paragrafı

                Word.Paragraph p1 = doc.Content.Paragraphs.Add(ref objMissing);
                p1.Range.Text = txtBaslik.Text;
                p1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                p1.Format.SpaceAfter = 12; //Punto cinsinden
                p1.Range.InsertParagraphAfter();

                object hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p2 = doc.Content.Paragraphs.Add(ref hedef);
                string sinifAdi = frmAna.siniflar[i].ad;
                p2.Range.Text = sinifAdi + " SINIFI";
                p2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                p2.Format.SpaceAfter = 12;
                p2.Range.InsertParagraphAfter();

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p3 = doc.Content.Paragraphs.Add(ref hedef);
                p3.Range.Text = "\t" + txtAciklama.Text;
                p3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                p3.Format.SpaceAfter = 0;
                p3.Range.InsertParagraphAfter();

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p4 = doc.Content.Paragraphs.Add(ref hedef);
                p4.Range.Text = "\t" + txtOgrencilereMesaj.Text;
                p4.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                p4.Format.SpaceAfter = 12;
                p4.Range.InsertParagraphAfter();

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p5 = doc.Content.Paragraphs.Add(ref hedef);
                string isim = txtSorumlu.Text;
                p5.Range.Text = isim;
                p5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                p5.Format.SpaceAfter = 0;
                p5.Range.InsertParagraphAfter();

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p6 = doc.Content.Paragraphs.Add(ref hedef);
                string unvan = txtUnvan.Text;
                p6.Range.Text = unvan;
                p6.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                p6.Format.SpaceAfter = 12;
                p6.Range.InsertParagraphAfter();

                #endregion

                #region Ders programı tablosu

                Word.Range wordRange = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Table tablo = doc.Tables.Add(wordRange, frmAna.gunSayisi + 1, frmAna.gunlukDersSayisi + 1, ref objMissing, ref objMissing);
                tablo.Range.ParagraphFormat.SpaceAfter = 0;
                tablo.Range.Font.Size = 8;
                tablo.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                tablo.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;


                for (int s = 0; s < frmAna.gunlukDersSayisi; s++)
                {
                    string sutun = (s + 1).ToString() + "\n";
                    sutun += frmAna.dtDersSaatleri.Rows[s][1].ToString() + "\n" + frmAna.dtDersSaatleri.Rows[s][2].ToString();
                    tablo.Cell(1, s + 2).Range.Text = sutun;
                }

                for (int g = 0; g < frmAna.gunSayisi; g++)
                {
                    tablo.Cell(g + 2, 1).Range.Text = frmAna.secilenGunler[g];
                }

                for (int g = 0; g < frmAna.gunSayisi; g++)
                {

                    for (int s = 0; s < frmAna.gunlukDersSayisi;)
                    {
                        if (frmAna.dbSinif[i, sayac] == null)
                        {
                            sayac++;
                            tablo.Cell(g + 2, s + 2).Range.Text = "\n\n";
                            s++;
                            continue;
                        }

                        int uzunluk = frmAna.dbSinif[i, sayac].uzunluk;

                        for (int u = 0; u < uzunluk; u++)
                        {
                            string text = frmAna.dbSinif[i, sayac].atananDers.ders.kod + "\n";
                            foreach (Ogretmen ogretmen in frmAna.dbSinif[i, sayac].atananDers.ogretmenler)
                            {
                                text += ogretmen.kod + " ";
                            }
                            text += "\n";
                            foreach (Derslik derslik in frmAna.dbSinif[i, sayac].atananDers.derslikler)
                            {
                                text += derslik.kod + " ";
                            }

                            tablo.Cell(g + 2, s + 2).Range.Text = text;
                            s++;
                        }
                        sayac += uzunluk;
                    }
                }




                #endregion

                #region Ders Adı - Toplam Ders Saati - Öğretmen Adı Tablosu

                //int dersSayisi = 0;

                SortedList<string, int> dersler = new SortedList<string, int>();

                foreach (AtananDers ad in frmAna.atananDersler)
                {
                    if (ad.siniflar.Contains(frmAna.siniflar[i]))
                    {
                        if (dersler.ContainsKey(ad.ders.ad))
                        {
                            dersler[ad.ders.ad] += ad.tds;
                        }
                        else
                        {
                            dersler.Add(ad.ders.ad, ad.tds);
                        }
                        //dersSayisi++;
                    }
                }

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph bosluk = doc.Content.Paragraphs.Add(ref hedef);
                bosluk.Range.Text = "";
                bosluk.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                bosluk.Format.SpaceAfter = 12;
                bosluk.Range.InsertParagraphAfter();

                Word.Range wordRange2 = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Table tablo2 = doc.Tables.Add(wordRange2, dersler.Count + 1, 3, ref objMissing, ref objMissing);
                tablo2.Range.ParagraphFormat.SpaceAfter = 0;
                tablo2.Range.Font.Size = 8;
                tablo2.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                tablo2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                tablo2.Cell(1, 1).Range.Text = "Dersin Adı";
                tablo2.Cell(1, 2).Range.Text = "Toplam Ders Saati";
                tablo2.Cell(1, 3).Range.Text = "Öğretmenin Adı";

                for (int d = 0; d < dersler.Count; d++)
                {
                    tablo2.Cell(d + 2, 1).Range.Text = dersler.Keys[d];
                    tablo2.Cell(d + 2, 2).Range.Text = dersler.Values[d].ToString();
                    string ogretmenler = "";

                    foreach (AtananDers ad in frmAna.atananDersler)
                    {
                        if (ad.ders.ad == dersler.Keys[d] && ad.siniflar.Contains(frmAna.siniflar[i]))
                        {
                            foreach (Ogretmen ogretmen in ad.ogretmenler)
                            {
                                ogretmenler += ogretmen.ad + " " + ogretmen.soyad + "\n";
                            }
                            break;
                        }
                    }
                    ogretmenler = ogretmenler.Substring(0, ogretmenler.Length - 1);
                    tablo2.Cell(d + 2, 3).Range.Text = ogretmenler;
                }


                #endregion

                doc.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);

            }

            for (int i = 0; i < frmAna.dbOgretmen.GetLength(0); i++)
            {
                int sayac = 0;

                #region Üst başlık ve açıklama paragrafı

                Word.Paragraph p1 = doc.Content.Paragraphs.Add(ref objMissing);
                p1.Range.Text = "HAFTALIK DERS PROGRAMI";
                p1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                p1.Format.SpaceAfter = 12; //Punto cinsinden
                p1.Range.InsertParagraphAfter();

                object hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p2 = doc.Content.Paragraphs.Add(ref hedef);
                string ogretmenAdSoyad = frmAna.ogretmenler[i].ad + " " + frmAna.ogretmenler[i].soyad;
                p2.Range.Text = "Sayın " + ogretmenAdSoyad;
                p2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                p2.Format.SpaceAfter = 12;
                p2.Range.InsertParagraphAfter();

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p3 = doc.Content.Paragraphs.Add(ref hedef);
                p3.Range.Text = "\t" + txtAciklama.Text;
                p3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                p3.Format.SpaceAfter = 0;
                p3.Range.InsertParagraphAfter();

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p4 = doc.Content.Paragraphs.Add(ref hedef);
                p4.Range.Text = "\t" + txtOgretmenlereMesaj.Text;
                p4.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                p4.Format.SpaceAfter = 12;
                p4.Range.InsertParagraphAfter();

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p5 = doc.Content.Paragraphs.Add(ref hedef);
                string isim = txtSorumlu.Text;
                p5.Range.Text = isim;
                p5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                p5.Format.SpaceAfter = 0;
                p5.Range.InsertParagraphAfter();

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph p6 = doc.Content.Paragraphs.Add(ref hedef);
                string unvan = txtUnvan.Text;
                p6.Range.Text = unvan;
                p6.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
                p6.Format.SpaceAfter = 12;
                p6.Range.InsertParagraphAfter();

                #endregion

                #region Ders programı tablosu

                Word.Range wordRange = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Table tablo = doc.Tables.Add(wordRange, frmAna.gunSayisi + 1, frmAna.gunlukDersSayisi + 1, ref objMissing, ref objMissing);
                tablo.Range.ParagraphFormat.SpaceAfter = 0;
                tablo.Range.Font.Size = 8;
                tablo.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                tablo.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;


                for (int s = 0; s < frmAna.gunlukDersSayisi; s++)
                {
                    string sutun = (s + 1).ToString() + "\n";
                    sutun += frmAna.dtDersSaatleri.Rows[s][1].ToString() + "\n" + frmAna.dtDersSaatleri.Rows[s][2].ToString();
                    tablo.Cell(1, s + 2).Range.Text = sutun;
                }
                for (int g = 0; g < frmAna.gunSayisi; g++)
                {
                    tablo.Cell(g + 2, 1).Range.Text = frmAna.secilenGunler[g];
                }

                for (int g = 0; g < frmAna.gunSayisi; g++)
                {

                    for (int s = 0; s < frmAna.gunlukDersSayisi;)
                    {
                        if (frmAna.dbOgretmen[i, sayac] == null)
                        {
                            sayac++;
                            tablo.Cell(g + 2, s + 2).Range.Text = "\n\n";
                            s++;
                            continue;
                        }

                        int uzunluk = frmAna.dbOgretmen[i, sayac].uzunluk;

                        for (int u = 0; u < uzunluk; u++)
                        {
                            string text = frmAna.dbOgretmen[i, sayac].atananDers.ders.kod + "\n";
                            foreach (Sinif sinif in frmAna.dbOgretmen[i, sayac].atananDers.siniflar)
                            {
                                text += sinif.kod + " ";
                            }
                            text += "\n";
                            foreach (Derslik derslik in frmAna.dbOgretmen[i, sayac].atananDers.derslikler)
                            {
                                text += derslik.kod + " ";
                            }

                            tablo.Cell(g + 2, s + 2).Range.Text = text;
                            s++;
                        }
                        sayac += uzunluk;
                    }
                }




                #endregion

                #region Ders Adı - Toplam Ders Saati - Sınıf Adı Tablosu

                //int dersSayisi = 0;

                SortedList<string, int> dersler = new SortedList<string, int>();

                foreach (AtananDers ad in frmAna.atananDersler)
                {
                    if (ad.ogretmenler.Contains(frmAna.ogretmenler[i]))
                    {
                        if (dersler.ContainsKey(ad.ders.ad))
                        {
                            dersler[ad.ders.ad] += ad.tds;
                        }
                        else
                        {
                            dersler.Add(ad.ders.ad, ad.tds);
                        }
                        //dersSayisi++;
                    }
                }

                hedef = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Paragraph bosluk = doc.Content.Paragraphs.Add(ref hedef);
                bosluk.Range.Text = "";
                bosluk.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                bosluk.Format.SpaceAfter = 12;
                bosluk.Range.InsertParagraphAfter();

                Word.Range wordRange2 = doc.Bookmarks.get_Item(ref dokumanSonu).Range;
                Word.Table tablo2 = doc.Tables.Add(wordRange2, dersler.Count + 1, 3, ref objMissing, ref objMissing);
                tablo2.Range.ParagraphFormat.SpaceAfter = 0;
                tablo2.Range.Font.Size = 8;
                tablo2.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
                tablo2.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

                tablo2.Cell(1, 1).Range.Text = "Dersin Adı";
                tablo2.Cell(1, 2).Range.Text = "Toplam Ders Saati";
                tablo2.Cell(1, 3).Range.Text = "Sınıf Adı";

                for (int d = 0; d < dersler.Count; d++)
                {
                    tablo2.Cell(d + 2, 1).Range.Text = dersler.Keys[d];
                    tablo2.Cell(d + 2, 2).Range.Text = dersler.Values[d].ToString();
                    string siniflar = "";

                    foreach (AtananDers ad in frmAna.atananDersler)
                    {
                        if (ad.ders.ad == dersler.Keys[d])
                        {
                            if (ad.ogretmenler.Contains(frmAna.ogretmenler[i]))
                            {
                                foreach (Sinif sinif in ad.siniflar)
                                {
                                    siniflar += sinif.ad + "\n";
                                }
                                break;
                            }
                        }
                    }
                    //siniflar = siniflar.Substring(0, siniflar.Length - 1);
                    tablo2.Cell(d + 2, 3).Range.Text = siniflar;
                }


                #endregion

                doc.Words.Last.InsertBreak(Word.WdBreakType.wdPageBreak);
            }

            Close();
        }
    }
}
