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
    public partial class Form4 : Form
    {
        public static int status;
        public Form4()
        {
            InitializeComponent();
            switch (status)
            {
                case 2:
                    string text = "";
                    for (int i = 0; i < Form1.pub_twogram.GetLength(0);i++)
                    {
                        if (Form1.pub_twogram[i, 0] == null)
                            break;
                        text += Form1.pub_twogram[i, 0].Replace(" ", "_") + "\t" + (Convert.ToDouble(Form1.pub_twogram[i, 1]) / Form1.text.Length * 100).ToString() + "%\n";
                    }
                    richTextBox1.Text = text;
                    break;
                case 3:
                    string text2 = "";
                    for (int i = 0; i < Form1.pub_threegram.GetLength(0); i++)
                    {
                        if (Form1.pub_threegram[i, 0] == null)
                            break;
                        text2 += Form1.pub_threegram[i, 0].Replace(" ", "_") + "\t" + (Convert.ToDouble(Form1.pub_threegram[i, 1]) / Form1.text.Length * 100).ToString() + "%\n";
                    }
                    richTextBox1.Text = text2;
                    break;
            }
        }
    }
}
