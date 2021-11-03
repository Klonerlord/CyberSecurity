
namespace Lab4_DS
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Orig_text = new System.Windows.Forms.RichTextBox();
            this.Ciphr_text = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cipher = new System.Windows.Forms.Button();
            this.Clear_orig = new System.Windows.Forms.Button();
            this.Decipher = new System.Windows.Forms.Button();
            this.Clear_cipher = new System.Windows.Forms.Button();
            this.a_text = new System.Windows.Forms.TextBox();
            this.b_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Space = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Common2 = new System.Windows.Forms.TextBox();
            this.Common1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Orig_text
            // 
            this.Orig_text.Location = new System.Drawing.Point(12, 29);
            this.Orig_text.Name = "Orig_text";
            this.Orig_text.Size = new System.Drawing.Size(776, 161);
            this.Orig_text.TabIndex = 0;
            this.Orig_text.Text = "";
            this.Orig_text.TextChanged += new System.EventHandler(this.Orig_text_TextChanged);
            // 
            // Ciphr_text
            // 
            this.Ciphr_text.Location = new System.Drawing.Point(12, 221);
            this.Ciphr_text.Name = "Ciphr_text";
            this.Ciphr_text.Size = new System.Drawing.Size(776, 180);
            this.Ciphr_text.TabIndex = 1;
            this.Ciphr_text.Text = "";
            this.Ciphr_text.TextChanged += new System.EventHandler(this.Ciphr_text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оригінал:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шифрований текст:";
            // 
            // Cipher
            // 
            this.Cipher.Enabled = false;
            this.Cipher.Location = new System.Drawing.Point(15, 429);
            this.Cipher.Name = "Cipher";
            this.Cipher.Size = new System.Drawing.Size(115, 43);
            this.Cipher.TabIndex = 4;
            this.Cipher.Text = "Шифрувати";
            this.Cipher.UseVisualStyleBackColor = true;
            this.Cipher.Click += new System.EventHandler(this.Cipher_Click);
            // 
            // Clear_orig
            // 
            this.Clear_orig.Enabled = false;
            this.Clear_orig.Location = new System.Drawing.Point(552, 429);
            this.Clear_orig.Name = "Clear_orig";
            this.Clear_orig.Size = new System.Drawing.Size(115, 43);
            this.Clear_orig.TabIndex = 5;
            this.Clear_orig.Text = "Очистити оригінал";
            this.Clear_orig.UseVisualStyleBackColor = true;
            this.Clear_orig.Click += new System.EventHandler(this.Clear_orig_Click);
            // 
            // Decipher
            // 
            this.Decipher.Enabled = false;
            this.Decipher.Location = new System.Drawing.Point(673, 429);
            this.Decipher.Name = "Decipher";
            this.Decipher.Size = new System.Drawing.Size(115, 43);
            this.Decipher.TabIndex = 6;
            this.Decipher.Text = "Дешифрувати";
            this.Decipher.UseVisualStyleBackColor = true;
            this.Decipher.Click += new System.EventHandler(this.Decipher_Click);
            // 
            // Clear_cipher
            // 
            this.Clear_cipher.Enabled = false;
            this.Clear_cipher.Location = new System.Drawing.Point(136, 429);
            this.Clear_cipher.Name = "Clear_cipher";
            this.Clear_cipher.Size = new System.Drawing.Size(115, 43);
            this.Clear_cipher.TabIndex = 7;
            this.Clear_cipher.Text = "Очистити шифр";
            this.Clear_cipher.UseVisualStyleBackColor = true;
            this.Clear_cipher.Click += new System.EventHandler(this.Clear_cipher_Click);
            // 
            // a_text
            // 
            this.a_text.Location = new System.Drawing.Point(280, 429);
            this.a_text.Name = "a_text";
            this.a_text.Size = new System.Drawing.Size(89, 20);
            this.a_text.TabIndex = 8;
            this.a_text.TextChanged += new System.EventHandler(this.a_text_TextChanged);
            // 
            // b_text
            // 
            this.b_text.Location = new System.Drawing.Point(280, 452);
            this.b_text.Name = "b_text";
            this.b_text.Size = new System.Drawing.Size(89, 20);
            this.b_text.TabIndex = 9;
            this.b_text.TextChanged += new System.EventHandler(this.b_text_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(253, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(253, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "b:";
            // 
            // Space
            // 
            this.Space.AutoSize = true;
            this.Space.Checked = true;
            this.Space.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Space.Location = new System.Drawing.Point(728, 202);
            this.Space.Name = "Space";
            this.Space.Size = new System.Drawing.Size(60, 17);
            this.Space.TabIndex = 12;
            this.Space.Text = "Пробіл";
            this.Space.UseVisualStyleBackColor = true;
            this.Space.CheckedChanged += new System.EventHandler(this.Space_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(414, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Common2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(414, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Common1:";
            // 
            // Common2
            // 
            this.Common2.Location = new System.Drawing.Point(500, 452);
            this.Common2.Name = "Common2";
            this.Common2.Size = new System.Drawing.Size(46, 20);
            this.Common2.TabIndex = 14;
            this.Common2.Text = "о";
            // 
            // Common1
            // 
            this.Common1.Location = new System.Drawing.Point(500, 429);
            this.Common1.Name = "Common1";
            this.Common1.Size = new System.Drawing.Size(46, 20);
            this.Common1.TabIndex = 13;
            this.Common1.Text = " ";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Common2);
            this.Controls.Add(this.Common1);
            this.Controls.Add(this.Space);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_text);
            this.Controls.Add(this.a_text);
            this.Controls.Add(this.Clear_cipher);
            this.Controls.Add(this.Decipher);
            this.Controls.Add(this.Clear_orig);
            this.Controls.Add(this.Cipher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ciphr_text);
            this.Controls.Add(this.Orig_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Affine cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Orig_text;
        private System.Windows.Forms.RichTextBox Ciphr_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cipher;
        private System.Windows.Forms.Button Clear_orig;
        private System.Windows.Forms.Button Decipher;
        private System.Windows.Forms.Button Clear_cipher;
        private System.Windows.Forms.TextBox a_text;
        private System.Windows.Forms.TextBox b_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Space;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Common2;
        private System.Windows.Forms.TextBox Common1;
    }
}