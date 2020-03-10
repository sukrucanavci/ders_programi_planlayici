using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_Programı_Planlayıcı
{
    public partial class frmKisitlamaOgretmen : Form
    {
        Ogretmen ogretmen;

        public frmKisitlamaOgretmen(Ogretmen ogretmen)
        {
            InitializeComponent();
            this.ogretmen = ogretmen;
            this.Text += ogretmen.ad + " " + ogretmen.soyad;
            lblOgretmenAdSoyad.Text = ogretmen.ad + " " + ogretmen.soyad;
            lblTDS.Text = ogretmen.tds.ToString();
            nudMaxDersGunu.Value = ogretmen.maxDersGunu;
            nudMaxDersGunu.Maximum = frmAna.gunSayisi;
        }

        private void nudMaxDersGunu_ValueChanged(object sender, EventArgs e)
        {
            ogretmen.maxDersGunu = (int)nudMaxDersGunu.Value;
        }

        private void btnTumuneUygula_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tüm öğretmenlere bu ders günü sınırlamasını uygulamak istiyor musunuz?", "Tümüne Uygula", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No) { return; }
            foreach (var ogretmen in frmAna.ogretmenler)
            {
                ogretmen.maxDersGunu = (int)nudMaxDersGunu.Value;
            }
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
