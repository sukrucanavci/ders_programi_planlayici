using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmDersProgramiCiktisi : Form
    {
        public frmDersProgramiCiktisi()
        {
            InitializeComponent();
            Olustur();
        }

        void Olustur()
        {
            Word.Application wordApp = new Word.Application();
            wordApp.Visible = true;
            Word.Document objDoc;
            object objMissing = System.Reflection.Missing.Value;
            object dokumanSonu = "\\endofdoc";

            //wordApp.Selection.Font.Size = 12;
            //wordApp.Selection.Font.Name = "Arial";

            #region Üst kısım

            objDoc = wordApp.Documents.Add(ref objMissing);
            Word.Paragraph p1 = objDoc.Content.Paragraphs.Add(ref objMissing);
            p1.Range.Text = "HAFTALIK DERS PROGRAMI";
            p1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p1.Format.SpaceAfter = 12; //Punto cinsinden
            p1.Range.InsertParagraphAfter();

            object hedef = objDoc.Bookmarks.get_Item(ref dokumanSonu).Range;
            Word.Paragraph p2 = objDoc.Content.Paragraphs.Add(ref hedef);
            string sinifAdi = " ";
            p2.Range.Text = sinifAdi + " SINIFI";
            p2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            p2.Format.SpaceAfter = 12;
            p2.Range.InsertParagraphAfter();

            hedef = objDoc.Bookmarks.get_Item(ref dokumanSonu).Range;
            Word.Paragraph p3 = objDoc.Content.Paragraphs.Add(ref hedef);
            string sezonYili = "\t2019/2020 ";
            string baslangicTarihi = "";
            p3.Range.Text = sezonYili + " eğitim öğretim yılı, " + baslangicTarihi +
                " tarihinden itibaren geçerli ders programınız aşağıdaki tabloda gösterilmiştir.";
            p3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            p3.Format.SpaceAfter = 0;
            p3.Range.InsertParagraphAfter();

            hedef = objDoc.Bookmarks.get_Item(ref dokumanSonu).Range;
            Word.Paragraph p4 = objDoc.Content.Paragraphs.Add(ref hedef);
            p4.Range.Text = "\tTüm öğrencilerime derslerinde başarılar dilerim.";
            p4.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            p4.Format.SpaceAfter = 12;
            p4.Range.InsertParagraphAfter();

            hedef = objDoc.Bookmarks.get_Item(ref dokumanSonu).Range;
            Word.Paragraph p5 = objDoc.Content.Paragraphs.Add(ref hedef);
            string isim = "ŞÜKRÜ CAN AVCI";
            p5.Range.Text = isim;
            p5.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            p5.Format.SpaceAfter = 0;
            p5.Range.InsertParagraphAfter();

            hedef = objDoc.Bookmarks.get_Item(ref dokumanSonu).Range;
            Word.Paragraph p6 = objDoc.Content.Paragraphs.Add(ref hedef);
            string unvan = "OKUL MÜDÜRÜ";
            p6.Range.Text = unvan;
            p6.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
            p6.Format.SpaceAfter = 12;
            p6.Range.InsertParagraphAfter();

            #endregion

            #region Ders programı


            Word.Range wordRange = objDoc.Bookmarks.get_Item(ref dokumanSonu).Range;
            Word.Table tablo = objDoc.Tables.Add(wordRange, frmAna.gunSayisi + 1, frmAna.gunlukDersSayisi + 1, ref objMissing, ref objMissing);
            tablo.Range.ParagraphFormat.SpaceAfter = 12;
            tablo.Range.Font.Size = 10;
            tablo.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            tablo.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            for (int i = 0; i < frmAna.gunlukDersSayisi; i++)
            {
                tablo.Cell(1, i + 2).Range.Text = (i + 1).ToString();

                for (int j = 0; j < frmAna.gunSayisi; j++)
                {
                    tablo.Cell(j + 2, i + 2).Range.Text = "A";
                }
            }

            for (int j = 0; j < frmAna.gunSayisi; j++)
            {
                tablo.Cell(j + 2, 1).Range.Text = frmAna.secilenGunler[j];
            }


            #endregion

        }
    }
}
