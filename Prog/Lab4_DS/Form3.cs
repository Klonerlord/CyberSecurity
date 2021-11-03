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
    public partial class Form3 : Form
    {
        char[] alphabet = Form1.alphabet;
        char[] cipher_array;

        static int modInverse(int a, int m)
        {

            for (int x = 1; x < m; x++)
                if (((a % m) * (x % m)) % m == 1)
                    return x;
            return 1;
        }

        static int Greatest_part(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;
            if (a == b)
                return a;
            if (a > b)
                return Greatest_part(a - b, b);
            return Greatest_part(a, b - a);
        }

        public Form3()
        {
            InitializeComponent(); 
            Orig_text.Text = Form1.text;
            if (Orig_text.Text != "")
            {
                if (a_text.Text != "" && b_text.Text != "")
                    Cipher.Enabled = true;
                Clear_orig.Enabled = true;
            }
        }

        private void Cipher_Click(object sender, EventArgs e)
        {
            try
            {
                char[] cipher_alphabet = new char[alphabet.Length];
                int a = Convert.ToInt32(a_text.Text);
                int b = Convert.ToInt32(b_text.Text);
                int m = alphabet.Length;
                if (Greatest_part(a, m) == 1)
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        int k = (a * i + b) % m;
                        cipher_alphabet[k] = alphabet[i];
                    }
                    char[] text_array = Orig_text.Text.ToLower().ToCharArray();
                    cipher_array = new char[text_array.Length];
                    bool prog = true;
                    for (int i = 0; i < text_array.Length; i++)
                    {
                        try
                        {
                            if (alphabet.Contains(text_array[i]))
                                cipher_array[i] = cipher_alphabet[Array.IndexOf(alphabet, text_array[i])];
                            else
                                cipher_array[i] = text_array[i];
                        }
                        catch (Exception exp)
                        {
                            MessageBox.Show(exp.Message);
                            prog = false;
                            break;
                        }
                    }
                    if (prog == true)
                        Ciphr_text.Text = new string(cipher_array);
                }
                else
                    MessageBox.Show("Спробуйте інше а!");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message + "\nTry again!");
            }
        }

        private void a_text_TextChanged(object sender, EventArgs e)
        {
            if (Orig_text.Text != "" && b_text.Text != "" && a_text.Text != "")
                Cipher.Enabled = true;
            else
                Cipher.Enabled = false;
        }

        private void b_text_TextChanged(object sender, EventArgs e)
        {
            if (Orig_text.Text != "" && a_text.Text != "" && b_text.Text != "")
                Cipher.Enabled = true;
            else
                Cipher.Enabled = false;
        }

        private void Orig_text_TextChanged(object sender, EventArgs e)
        {
            if (Orig_text.Text != "")
            {
                if (a_text.Text != "" && b_text.Text != "")
                    Cipher.Enabled = true;
                Clear_orig.Enabled = true;
            }
            else
            {
                Cipher.Enabled = false;
                Clear_orig.Enabled = false;
            }
        }

        private void Ciphr_text_TextChanged(object sender, EventArgs e)
        {
            if (Ciphr_text.Text != "")
            {
                Decipher.Enabled = true;
                Clear_cipher.Enabled = true;
            }
            else
            {
                Decipher.Enabled = false;
                Clear_cipher.Enabled = false;
            }
        }

        private void Clear_cipher_Click(object sender, EventArgs e)
        {
            Ciphr_text.Text = "";
        }

        private void Clear_orig_Click(object sender, EventArgs e)
        {
            Orig_text.Text = "";
        }

        private void Decipher_Click(object sender, EventArgs e)
        {
            a_text.Text = "";
            b_text.Text = "";
            string[,] onegram = new string[alphabet.Length, 2];
            cipher_array = Ciphr_text.Text.ToCharArray();
            double length = cipher_array.Length;
            foreach (char letter in cipher_array)
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
                        foreach (char comp in alphabet)
                            if (comp == letter)
                                num++;
                        for (int i = 0; i < alphabet.Length; i++)
                            if (onegram[i, 0] == null)
                            {
                                onegram[i, 0] = letter.ToString();
                                onegram[i, 1] = num.ToString();
                                break;
                            }
                    }
                }
            }
            double[] prob = new double[] { 0.072,0.017,0.052,0.016,0.003,0.035,0.017,0.008,0.009,0.023,0.061,0.057,0.006,0.008,0.035,0.036,0.031,0.065,0.094,0.029,0.047,0.041,0.055,
            0.04,0.001,0.012,0.006,0.018,0.012,0.001,0.004,0.029,0.029,0.17};
            string[,] alpha_prob = new string[alphabet.Length, 2];
            for (int i = 0; i < alpha_prob.GetLength(0); i++)
            {
                alpha_prob[i, 1] = prob[i].ToString();
                alpha_prob[i, 0] = alphabet[i].ToString();
            }
            while (true)
            {
                bool loop = false;
                for (int i = 0; i < onegram.GetLength(0) - 1; i++)
                {
                    if (Convert.ToInt32(onegram[i, 1]) < Convert.ToInt32(onegram[i + 1, 1]))
                    {
                        var temp1 = onegram[i, 0];
                        var temp2 = onegram[i, 1];
                        onegram[i, 0] = onegram[i + 1, 0];
                        onegram[i, 1] = onegram[i + 1, 1];
                        onegram[i + 1, 0] = temp1;
                        onegram[i + 1, 1] = temp2;
                        loop = true;
                    }
                }
                if (!loop)
                    break;
            }
            if (alphabet.Contains(Common1.Text.ToCharArray()[0]) && Common1.Text.ToCharArray().Length == 1 && alphabet.Contains(Common2.Text.ToCharArray()[0]) && Common2.Text.ToCharArray().Length == 1)
            {
                int pos1 = Array.IndexOf(alphabet, Common1.Text.ToCharArray()[0]);
                int new_pos1 = Array.IndexOf(alphabet, onegram[0, 0].ToCharArray()[0]);
                int pos2 = Array.IndexOf(alphabet, Common2.Text.ToCharArray()[0]);
                int new_pos2 = Array.IndexOf(alphabet, onegram[1, 0].ToCharArray()[0]);
                List<int> a_n = new List<int>();
                List<int> b_n = new List<int>();
                for (int a1 = 1; a1 < alphabet.Length; a1++)
                {
                    for (int b1 = 0; b1 <= alphabet.Length; b1++)
                        if ((Greatest_part(a1, alphabet.Length) == 1 || Greatest_part(alphabet.Length, a1) == 1) && (pos1 == (a1 * new_pos1 + b1) % alphabet.Length || pos2 == (a1 * new_pos2 + b1) % alphabet.Length))
                        {
                            a_n.Add(a1);
                            b_n.Add(b1);
                        }
                }
                try
                {
                    List<double> text_prob = new List<double>();
                    List<string> text_list = new List<string>();
                    for (int j = 0; j < a_n.Count; j++)
                    {
                        char[] uncipher_alphabet = new char[alphabet.Length];
                        int a = a_n[j];
                        int b = b_n[j];
                        int m = alphabet.Length;
                        char[] uncipher_array = new char[cipher_array.Length];
                        for (int i = 0; i < alphabet.Length; i++)
                        {
                            int k = modInverse(a, m) * Math.Abs(i - b + m) % m;
                            uncipher_alphabet[k] = alphabet[i];
                        }
                        bool prog = true;
                        for (int i = 0; i < cipher_array.Length; i++)
                        {
                            try
                            {
                                if (alphabet.Contains(cipher_array[i]))
                                    uncipher_array[i] = uncipher_alphabet[Array.IndexOf(alphabet, cipher_array[i])];
                                else
                                    uncipher_array[i] = cipher_array[i];
                            }
                            catch (Exception exp)
                            {
                                MessageBox.Show(exp.Message);
                                prog = false;
                                break;
                            }
                        }
                        if (!prog)
                            break;
                        text_list.Add(new string(uncipher_array));
                        string[,] testgram = new string[alphabet.Length, 2];
                        //for (int k = 0; k < testgram.GetLength(0); k++)
                        //    testgram[k, 0] = alphabet[k].ToString();
                        foreach (char letter in uncipher_array)
                        {
                            if (alphabet.Contains(letter))
                            {
                                int temp = 0;
                                int num = 0;
                                for (int i = 0; i < alphabet.Length; i++)
                                    if (testgram[i, 0] == letter.ToString())
                                        temp++;
                                if (temp == 0)
                                {
                                    foreach (char comp in uncipher_array)
                                        if (comp == letter)
                                            num++;
                                    for (int i = 0; i < alphabet.Length; i++)
                                        if (testgram[i, 0] == null)
                                        {
                                            testgram[i, 0] = letter.ToString();
                                            testgram[i, 1] = num.ToString();
                                            break;
                                        }
                                }
                            }
                        }
                        for (int k = 0; k < alphabet.Length; k++)
                            for (int i = 0; i < testgram.GetLength(0) - 1; i++)
                            {
                                if (alphabet[k].ToString() == testgram[i, 0])
                                {
                                    var temp1 = testgram[k, 0];
                                    var temp2 = testgram[k, 1];
                                    testgram[k, 0] = testgram[i, 0];
                                    testgram[k, 1] = testgram[i, 1];
                                    testgram[i, 0] = temp1;
                                    testgram[i, 1] = temp2;
                                }
                            }
                        double uncipher_length = uncipher_array.Length;
                        double sum = 0;
                        for (int k = 0; k < alphabet.Length; k++)
                            if (testgram[k, 1] != null)
                                sum += Convert.ToDouble(alpha_prob[k, 1]) * Convert.ToDouble(testgram[k, 1]) / uncipher_length;
                        text_prob.Add(sum);
                    }
                    double max = 0;
                    int max_index = 0;
                    for (int j = 0; j < text_prob.Count; j++)
                    {
                        if (max < text_prob[j])
                        {
                            max = text_prob[j];
                            max_index = j;
                        }
                    }
                    a_text.Text = a_n[max_index].ToString();
                    b_text.Text = b_n[max_index].ToString();
                    Orig_text.Text = text_list[max_index];
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
            else
                MessageBox.Show("Введіть по одній найчастішіх букв алфавіту.");
        }

        private void Space_CheckedChanged(object sender, EventArgs e)
        {
            if (Space.Checked != true)
                alphabet = new string(alphabet).Replace(" ", "").ToCharArray();
            else
                alphabet = (new string(alphabet) + " ").ToCharArray();
        }
    }
}
