namespace SimLab1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.heightBox = new System.Windows.Forms.NumericUpDown();
            this.heightText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.angleBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.stepBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 10D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 25D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(64, 138);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(759, 328);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(140, 29);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(120, 20);
            this.heightBox.TabIndex = 1;
            this.heightBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // heightText
            // 
            this.heightText.AutoSize = true;
            this.heightText.Location = new System.Drawing.Point(87, 31);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(45, 13);
            this.heightText.TabIndex = 2;
            this.heightText.Text = "Высота";
            this.heightText.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Угол";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(140, 55);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(120, 20);
            this.angleBox.TabIndex = 3;
            this.angleBox.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Скорость";
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(140, 81);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(120, 20);
            this.speedBox.TabIndex = 5;
            this.speedBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Размер";
            // 
            // sizeBox
            // 
            this.sizeBox.Location = new System.Drawing.Point(365, 29);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(120, 20);
            this.sizeBox.TabIndex = 7;
            this.sizeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(321, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Вес";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(365, 57);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(120, 20);
            this.weightBox.TabIndex = 9;
            this.weightBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightBox.ValueChanged += new System.EventHandler(this.weightBox_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(547, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 101);
            this.button1.TabIndex = 11;
            this.button1.Text = "Запуск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 472);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(860, 184);
            this.dataGridView1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Начальный шаг";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // stepBox
            // 
            this.stepBox.Location = new System.Drawing.Point(365, 83);
            this.stepBox.Name = "stepBox";
            this.stepBox.Size = new System.Drawing.Size(120, 20);
            this.stepBox.TabIndex = 13;
            this.stepBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stepBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 668);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stepBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angleBox);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown heightBox;
        private System.Windows.Forms.Label heightText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown angleBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sizeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown weightBox;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown stepBox;
    }
}

