using System.Drawing;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class Kart : UserControl
    {
        DersBlogu db;

        public Kart(DersBlogu dersBlogu)
        {
            InitializeComponent();
            db = dersBlogu;
            Size = new Size(75 * dersBlogu.uzunluk, 30);
            Margin = new Padding(0);

            Label tb = new Label() {
                AutoSize = false,
                BackColor = Color.Transparent,
                Text = db.atananDers.ders.kod,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
            Controls.Add(tb);
        }

        private void Kart_Paint(object sender, PaintEventArgs e)
        {
            int count = db.atananDers.ogretmenler.Count;
            int width = Width / count;

            for (int i = 0; i < count; i++)
            {
                var brush = new SolidBrush(db.atananDers.ogretmenler[i].renk);
                e.Graphics.FillRectangle(brush, width*i, 0, width, Height);
            }
        }
    }
}
