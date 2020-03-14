using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public class LabelKart : Label
    {
        public LabelKart(DersBlogu dersBlogu)
        {
            AutoSize = false;
            Size = new Size(75 * dersBlogu.uzunluk, 30);
            //Dock = DockStyle.Fill;
            //Text = dersBlogu.uzunluk.ToString();
            Text = dersBlogu.atananDers.ders.kod;
            TextAlign = ContentAlignment.MiddleCenter;
            BackColor = dersBlogu.atananDers.ogretmenler[0].renk;
            Margin = new Padding(0);

            if (dersBlogu.atananDers.ogretmenler.Count > 1) 
            {
                //TextAlign = ContentAlignment.MiddleLeft;
                Splitter splitter;
                foreach (var ogretmen in dersBlogu.atananDers.ogretmenler.GetRange(1, dersBlogu.atananDers.ogretmenler.Count - 1))
                {
                    splitter = new Splitter();
                    splitter.BackColor = ogretmen.renk;
                    splitter.Dock = DockStyle.Right;
                    splitter.Width = Width / dersBlogu.atananDers.ogretmenler.Count;
                    Controls.Add(splitter);
                }

                this.Resize += new EventHandler(Resize);
                void Resize(object sender, EventArgs e)
                {
                    foreach (Splitter spl in Controls)
                    {
                        spl.Width = Width / dersBlogu.atananDers.ogretmenler.Count;
                    }
                }
            }
        }
    }
}
