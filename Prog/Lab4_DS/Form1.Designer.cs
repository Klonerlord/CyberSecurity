
namespace Lab4_DS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.File_path = new System.Windows.Forms.TextBox();
            this.File_browse = new System.Windows.Forms.Button();
            this.File_peform = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Sort_alpha = new System.Windows.Forms.Button();
            this.Sort_number = new System.Windows.Forms.Button();
            this.Analyze_type1 = new System.Windows.Forms.RadioButton();
            this.Analyze_type2 = new System.Windows.Forms.RadioButton();
            this.Analyze_type3 = new System.Windows.Forms.RadioButton();
            this.Matrix = new System.Windows.Forms.Button();
            this.Affine = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // File_path
            // 
            this.File_path.Location = new System.Drawing.Point(12, 346);
            this.File_path.Name = "File_path";
            this.File_path.Size = new System.Drawing.Size(214, 20);
            this.File_path.TabIndex = 0;
            // 
            // File_browse
            // 
            this.File_browse.Location = new System.Drawing.Point(232, 344);
            this.File_browse.Name = "File_browse";
            this.File_browse.Size = new System.Drawing.Size(75, 23);
            this.File_browse.TabIndex = 1;
            this.File_browse.Text = "Пошук";
            this.File_browse.UseVisualStyleBackColor = true;
            this.File_browse.Click += new System.EventHandler(this.File_browse_Click);
            // 
            // File_peform
            // 
            this.File_peform.Location = new System.Drawing.Point(313, 344);
            this.File_peform.Name = "File_peform";
            this.File_peform.Size = new System.Drawing.Size(75, 23);
            this.File_peform.TabIndex = 2;
            this.File_peform.Text = "Аналізувати";
            this.File_peform.UseVisualStyleBackColor = true;
            this.File_peform.Click += new System.EventHandler(this.File_peform_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(776, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // Sort_alpha
            // 
            this.Sort_alpha.Enabled = false;
            this.Sort_alpha.Location = new System.Drawing.Point(452, 344);
            this.Sort_alpha.Name = "Sort_alpha";
            this.Sort_alpha.Size = new System.Drawing.Size(160, 23);
            this.Sort_alpha.TabIndex = 4;
            this.Sort_alpha.Text = "Відсортувати за алфавітом";
            this.Sort_alpha.UseVisualStyleBackColor = true;
            this.Sort_alpha.Click += new System.EventHandler(this.Sort_alpha_Click);
            // 
            // Sort_number
            // 
            this.Sort_number.Enabled = false;
            this.Sort_number.Location = new System.Drawing.Point(618, 344);
            this.Sort_number.Name = "Sort_number";
            this.Sort_number.Size = new System.Drawing.Size(160, 23);
            this.Sort_number.TabIndex = 5;
            this.Sort_number.Text = "Відсортувати за кількістю";
            this.Sort_number.UseVisualStyleBackColor = true;
            this.Sort_number.Click += new System.EventHandler(this.Sort_number_Click);
            // 
            // Analyze_type1
            // 
            this.Analyze_type1.AutoSize = true;
            this.Analyze_type1.Checked = true;
            this.Analyze_type1.Location = new System.Drawing.Point(232, 391);
            this.Analyze_type1.Name = "Analyze_type1";
            this.Analyze_type1.Size = new System.Drawing.Size(92, 17);
            this.Analyze_type1.TabIndex = 6;
            this.Analyze_type1.TabStop = true;
            this.Analyze_type1.Text = "Один символ";
            this.Analyze_type1.UseVisualStyleBackColor = true;
            this.Analyze_type1.CheckedChanged += new System.EventHandler(this.Analyze_type1_CheckedChanged);
            // 
            // Analyze_type2
            // 
            this.Analyze_type2.AutoSize = true;
            this.Analyze_type2.Location = new System.Drawing.Point(330, 391);
            this.Analyze_type2.Name = "Analyze_type2";
            this.Analyze_type2.Size = new System.Drawing.Size(65, 17);
            this.Analyze_type2.TabIndex = 7;
            this.Analyze_type2.Text = "Біграма";
            this.Analyze_type2.UseVisualStyleBackColor = true;
            this.Analyze_type2.CheckedChanged += new System.EventHandler(this.Analyze_type2_CheckedChanged);
            // 
            // Analyze_type3
            // 
            this.Analyze_type3.AutoSize = true;
            this.Analyze_type3.Location = new System.Drawing.Point(401, 391);
            this.Analyze_type3.Name = "Analyze_type3";
            this.Analyze_type3.Size = new System.Drawing.Size(75, 17);
            this.Analyze_type3.TabIndex = 8;
            this.Analyze_type3.Text = "Триграма";
            this.Analyze_type3.UseVisualStyleBackColor = true;
            this.Analyze_type3.CheckedChanged += new System.EventHandler(this.Analyze_type3_CheckedChanged);
            // 
            // Matrix
            // 
            this.Matrix.Enabled = false;
            this.Matrix.Location = new System.Drawing.Point(482, 388);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(160, 23);
            this.Matrix.TabIndex = 9;
            this.Matrix.Text = "Матриця біграми";
            this.Matrix.UseVisualStyleBackColor = true;
            this.Matrix.Click += new System.EventHandler(this.Matrix_Click);
            // 
            // Affine
            // 
            this.Affine.Location = new System.Drawing.Point(663, 388);
            this.Affine.Name = "Affine";
            this.Affine.Size = new System.Drawing.Size(115, 23);
            this.Affine.TabIndex = 10;
            this.Affine.Text = "Афіний шифр";
            this.Affine.UseVisualStyleBackColor = true;
            this.Affine.Click += new System.EventHandler(this.Affine_Click);
            // 
            // Table
            // 
            this.Table.Enabled = false;
            this.Table.Location = new System.Drawing.Point(134, 388);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(75, 23);
            this.Table.TabIndex = 11;
            this.Table.Text = "Таблиця";
            this.Table.UseVisualStyleBackColor = true;
            this.Table.Click += new System.EventHandler(this.Table_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Affine);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.Analyze_type3);
            this.Controls.Add(this.Analyze_type2);
            this.Controls.Add(this.Analyze_type1);
            this.Controls.Add(this.Sort_number);
            this.Controls.Add(this.Sort_alpha);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.File_peform);
            this.Controls.Add(this.File_browse);
            this.Controls.Add(this.File_path);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Lab4";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox File_path;
        private System.Windows.Forms.Button File_browse;
        private System.Windows.Forms.Button File_peform;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Sort_alpha;
        private System.Windows.Forms.Button Sort_number;
        private System.Windows.Forms.RadioButton Analyze_type1;
        private System.Windows.Forms.RadioButton Analyze_type2;
        private System.Windows.Forms.RadioButton Analyze_type3;
        private System.Windows.Forms.Button Matrix;
        private System.Windows.Forms.Button Affine;
        private System.Windows.Forms.Button Table;
    }
}

