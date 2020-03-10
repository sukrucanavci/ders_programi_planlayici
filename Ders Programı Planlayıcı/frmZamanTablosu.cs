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
    public partial class frmZamanTablosu : Form
    {
        public bool[,] zamanMatrisi = new bool[frmAna.gunSayisi, frmAna.gunlukDersSayisi];

        public frmZamanTablosu(bool[,] zamanMatrisi)
        {
            InitializeComponent();
            this.zamanMatrisi = zamanMatrisi;

            DataGridViewImageColumn column;
            for (int saat = 1; saat <= frmAna.gunlukDersSayisi; saat++)
            {
                column = new DataGridViewImageColumn();
                column.HeaderText = saat.ToString();
                dgwZaman.Columns.Add(column);
            }

            DataGridViewRow row;
            DataGridViewCell cell;
            for (int gun = 0; gun < zamanMatrisi.GetLength(0); gun++)
            {
                row = new DataGridViewRow();
                row.Height = 50;
                row.HeaderCell.Value = frmAna.secilenGunler[gun];

                for (int saat = 0; saat < zamanMatrisi.GetLength(1); saat++)
                {
                    cell = new DataGridViewImageCell();

                    if (zamanMatrisi[gun,saat])
                        cell.Value = Properties.Resources.evet;
                    else
                        cell.Value = Properties.Resources.hayir;

                    cell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    row.Cells.Add(cell);
                }
                dgwZaman.Rows.Add(row);
            }

            dgwZaman.CellClick += new DataGridViewCellEventHandler(Degistir);

            void Degistir(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex == -1 && e.ColumnIndex == -1) { return; }

                if (e.ColumnIndex == -1)
                {
                    if (zamanMatrisi[e.RowIndex, 0])
                    {
                        for (int c = 0; c < dgwZaman.Columns.Count; c++)
                        {
                            zamanMatrisi[e.RowIndex, c] = false;
                            dgwZaman.Rows[e.RowIndex].Cells[c].Value = Properties.Resources.hayir;
                        }
                    }
                    else
                    {
                        for (int c = 0; c < dgwZaman.Columns.Count; c++)
                        {
                            zamanMatrisi[e.RowIndex, c] = true;
                            dgwZaman.Rows[e.RowIndex].Cells[c].Value = Properties.Resources.evet;
                        }
                    }
                    return;
                }

                if (e.RowIndex == -1)
                {
                    if (zamanMatrisi[0, e.ColumnIndex])
                    {
                        for (int r = 0; r < dgwZaman.Rows.Count; r++)
                        {
                            zamanMatrisi[r, e.ColumnIndex] = false;
                            dgwZaman.Rows[r].Cells[e.ColumnIndex].Value = Properties.Resources.hayir;
                        }
                    }
                    else
                    {
                        for (int r = 0; r < dgwZaman.Rows.Count; r++)
                        {
                            zamanMatrisi[r, e.ColumnIndex] = true;
                            dgwZaman.Rows[r].Cells[e.ColumnIndex].Value = Properties.Resources.evet;
                        }
                    }
                    return;
                }

                if (zamanMatrisi[e.RowIndex, e.ColumnIndex] == true)
                {
                    zamanMatrisi[e.RowIndex, e.ColumnIndex] = false;
                    dgwZaman.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.hayir;
                }
                else
                {
                    zamanMatrisi[e.RowIndex, e.ColumnIndex] = true;
                    dgwZaman.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.evet;
                }
            }
        }



        private void btnTamam_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
