using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab4_DS
{
    public partial class Form1 : Form
    {
        public static char[] alphabet = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя ".ToCharArray();
        public static string[,] pub_twogram;
        public static string[,] pub_threegram;
        public static string text;

        public Form1()
        {
            InitializeComponent();
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisX.MinorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
        }

        private void File_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                File_path.Text = openFileDialog1.FileName;
        }

        private void File_peform_Click(object sender, EventArgs e)
        {
            try
            {
                int prob = 0;
                text = File.ReadAllText(File_path.Text);
                text = text.ToLower();
                char[] text_array = text.ToCharArray();
                Matrix.Enabled = false;
                chart1.Series["Series1"].Points.Clear();
                Sort_alpha.Enabled = false;
                Table.Enabled = false;

                if (text_array != null)
                {
                    if (Analyze_type1.Checked)
                    {
                        string[,] onegram = new string[alphabet.Length, 2];
                        foreach (char letter in text_array)
                        {
                            if (alphabet.Contains(letter))
                            {
                                int temp = 0;
                                int num = 0;
                                for (int i = 0; i < alphabet.Length; i++)
                                    if (onegram[i, 0] == letter.ToString())
                                        temp++;
                                if (temp == 0)
                                {
                                    foreach (char comp in text_array)
                                        if (comp == letter)
                                            num++;
                                    for (int i = 0; i < alphabet.Length; i++)
                                        if (onegram[i, 0] == null)
                                        {
                                            onegram[i, 0] = letter.ToString();
                                            onegram[i, 1] = num.ToString();
                                            prob += num;
                                            break;
                                        }
                                }
                            }
                        }
                        for (int i = 0; i < alphabet.Length; i++)
                            if (onegram[i, 0] != null)
                                chart1.Series["Series1"].Points.AddXY(onegram[i, 0].Replace(" ", "_") + "\n" + Math.Round(Convert.ToDouble(onegram[i, 1]) / prob, 3), onegram[i, 1]);
                        Sort_alpha.Enabled = true;
                    }
                    else if (Analyze_type2.Checked)
                    {
                        string chars = "";
                        int number = 0;
                        string[,] twogram = new string[text_array.Length, 2];
                        foreach (char letter in text_array)
                        {
                            if (alphabet.Contains(letter))
                            {
                                chars += letter;
                                number++;
                            }
                            if (number == 2)
                            {
                                int temp = 0;
                                int num = 0;
                                for (int i = 0; i < text_array.Length; i++)
                                    if (twogram[i, 0] == chars)
                                        temp++;
                                if (temp == 0)
                                {
                                    string char_temp = "";
                                    int num_temp = 0;
                                    foreach (char c in text_array)
                                    {
                                        if (alphabet.Contains(c))
                                        {
                                            char_temp += c;
                                            num_temp++;
                                        }
                                        if (num_temp == 2)
                                        {
                                            if (char_temp == chars)
                                                num++;
                                            num_temp--;
                                            char_temp = char_temp.Remove(0, 1);
                                        }
                                    }
                                    for (int i = 0; i < text_array.Length; i++)
                                        if (twogram[i, 0] == null)
                                        {
                                            twogram[i, 0] = chars.ToString();
                                            twogram[i, 1] = num.ToString();
                                            prob += num;
                                            break;
                                        }
                                }
                                number--;
                                chars = chars.Remove(0, 1);
                            }
                        }

                        pub_twogram = twogram;

                        while (true)
                        {
                            bool loop = false;
                            for (int i = 0; i < twogram.GetLength(0) - 1; i++)
                            {
                                if (Convert.ToInt32(twogram[i, 1]) < Convert.ToInt32(twogram[i + 1, 1]))
                                {
                                    var temp1 = twogram[i, 0];
                                    var temp2 = twogram[i, 1];
                                    twogram[i, 0] = twogram[i + 1, 0];
                                    twogram[i, 1] = twogram[i + 1, 1];
                                    twogram[i + 1, 0] = temp1;
                                    twogram[i + 1, 1] = temp2;
                                    loop = true;
                                }
                            }
                            if (!loop)
                                break;
                        }

                        for (int i = 0; i < 30; i++)
                            if (twogram[i, 0] != null)
                                chart1.Series["Series1"].Points.AddXY(twogram[i, 0].Replace(" ", "_") + "\n" + Math.Round(Convert.ToDouble(twogram[i, 1]) / prob, 3), Convert.ToInt32(twogram[i, 1]));
                        Matrix.Enabled = true;
                        Table.Enabled = true;
                    }
                    else if (Analyze_type3.Checked)
                    {
                        string chars = "";
                        int number = 0;
                        string[,] threegram = new string[text_array.Length, 2];
                        foreach (char letter in text_array)
                        {
                            if (alphabet.Contains(letter))
                            {
                                chars += letter;
                                number++;
                            }
                            if (number == 3)
                            {
                                int temp = 0;
                                int num = 0;
                                for (int i = 0; i < text_array.Length; i++)
                                    if (threegram[i, 0] == chars)
                                        temp++;
                                if (temp == 0)
                                {
                                    string char_temp = "";
                                    int num_temp = 0;
                                    foreach (char c in text_array)
                                    {
                                        if (alphabet.Contains(c))
                                        {
                                            char_temp += c;
                                            num_temp++;
                                        }
                                        if (num_temp == 3)
                                        {
                                            if (char_temp == chars)
                                                num++;
                                            num_temp--;
                                            char_temp = char_temp.Remove(0, 1);
                                        }
                                    }
                                    for (int i = 0; i < text_array.Length; i++)
                                        if (threegram[i, 0] == null)
                                        {
                                            threegram[i, 0] = chars.ToString();
                                            threegram[i, 1] = num.ToString();
                                            prob += num;
                                            break;
                                        }
                                }
                                number--;
                                chars = chars.Remove(0, 1);
                            }
                        }

                        pub_threegram = threegram;

                        while (true)
                        {
                            bool loop = false;
                            for (int i = 0; i < threegram.GetLength(0) - 1; i++)
                            {
                                if (Convert.ToInt32(threegram[i, 1]) < Convert.ToInt32(threegram[i + 1, 1]))
                                {
                                    var temp1 = threegram[i, 0];
                                    var temp2 = threegram[i, 1];
                                    threegram[i, 0] = threegram[i + 1, 0];
                                    threegram[i, 1] = threegram[i + 1, 1];
                                    threegram[i + 1, 0] = temp1;
                                    threegram[i + 1, 1] = temp2;
                                    loop = true;
                                }
                            }
                            if (!loop)
                                break;
                        }

                        for (int i = 0; i < 30; i++)
                            if (threegram[i, 0] != null)
                            {
                                chart1.Series["Series1"].Points.AddXY(threegram[i, 0].Replace(" ", "_") + "\n" + Math.Round(Convert.ToDouble(threegram[i, 1]) / prob, 3), Convert.ToInt32(threegram[i, 1]));
                            }
                        Table.Enabled = true;

                    }
                    else
                        MessageBox.Show("Хоча б один метод має бути обраний");
                }
                chart1.Enabled = true;
                chart1.Visible = true;
                Sort_number.Enabled = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "\nTry again!");
                chart1.Enabled = false;
                chart1.Visible = false;
                Sort_alpha.Enabled = false;
                Sort_number.Enabled = false;
            }
        }

        private void Sort_alpha_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Sort(0, "AxisLabel");
        }

        private void Sort_number_Click(object sender, EventArgs e)
        {
            chart1.Series["Series1"].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Descending, "Y");
        }

        private void Matrix_Click(object sender, EventArgs e)
        {
            Form2 Bi_matrix = new Form2();
            Bi_matrix.ShowDialog();
        }

        private void Affine_Click(object sender, EventArgs e)
        {
            Form3 Affine_cipher = new Form3();
            Affine_cipher.ShowDialog();
        }

        private void Table_Click(object sender, EventArgs e)
        {
            if (Analyze_type2.Checked)
            {
                Form4.status = 2;
                new Form4().ShowDialog();
            }
            else if (Analyze_type3.Checked)
            {
                Form4.status = 3;
                new Form4().ShowDialog();
            }
        }

        private void Analyze_type2_CheckedChanged(object sender, EventArgs e)
        {
            if (Sort_alpha.Enabled == true || Matrix.Enabled != true || Analyze_type1.Checked == true)
                Table.Enabled = false;
            else
                Table.Enabled = true;
        }

        private void Analyze_type3_CheckedChanged(object sender, EventArgs e)
        {
            if (Sort_alpha.Enabled == true || Matrix.Enabled == true || Analyze_type1.Checked == true)
                Table.Enabled = false;
            else
                Table.Enabled = true;
        }

        private void Analyze_type1_CheckedChanged(object sender, EventArgs e)
        {
            Table.Enabled = false;
        }
    }
}
