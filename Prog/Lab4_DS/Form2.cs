using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_DS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.RowCount = Form1.alphabet.Length;
            dataGridView1.ColumnCount = Form1.alphabet.Length;
            for (int i = 0; i < Form1.alphabet.Length; i++) 
            {
                dataGridView1.Columns[i].Name = Form1.alphabet[i].ToString().Replace(" ", "_");
                dataGridView1.Rows[i].HeaderCell.Value = Form1.alphabet[i].ToString().Replace(" ", "_");
            }
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.DarkGreen;
                    string twogram = dataGridView1.Columns[i].Name + dataGridView1.Rows[j].HeaderCell.Value;
                    twogram = twogram.Replace("_", " ");
                    for (int k = 0; k < Form1.pub_twogram.GetLength(0); k++)
                        if (twogram == Form1.pub_twogram[k,0])
                        {
                            dataGridView1.Rows[j].Cells[i].Value = Convert.ToInt32(Form1.pub_twogram[k, 1]);
                            if (Convert.ToInt32(Form1.pub_twogram[k, 1]) > 100)
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.GreenYellow;
                            else if (Convert.ToInt32(Form1.pub_twogram[k, 1]) > 50 && Convert.ToInt32(Form1.pub_twogram[k, 1]) < 100)
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.LawnGreen;
                            else if(Convert.ToInt32(Form1.pub_twogram[k, 1]) > 25 && Convert.ToInt32(Form1.pub_twogram[k, 1]) < 50)
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.LimeGreen;
                            else if (Convert.ToInt32(Form1.pub_twogram[k, 1]) > 15 && Convert.ToInt32(Form1.pub_twogram[k, 1]) < 25)
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.ForestGreen;
                            else
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.Green;
                        }
                }
            }
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            dataGridView1.Invalidate();
        }
    }
}
