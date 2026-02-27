namespace SimLab2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Tolsh = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TempPlast = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Koef = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Ydel = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeStep = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.SizeStep = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.LeftTemp = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.RightTemp = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.PlaneDensity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeCount = new System.Windows.Forms.NumericUpDown();
            this.TimeText = new System.Windows.Forms.Label();
            this.MiddleTemp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tolsh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempPlast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ydel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCount)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 148);
            this.button1.TabIndex = 0;
            this.button1.Text = "Прогнать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tolsh
            // 
            this.Tolsh.DecimalPlaces = 2;
            this.Tolsh.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Tolsh.Location = new System.Drawing.Point(151, 12);
            this.Tolsh.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Tolsh.Name = "Tolsh";
            this.Tolsh.Size = new System.Drawing.Size(120, 20);
            this.Tolsh.TabIndex = 1;
            this.Tolsh.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Tolsh.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Толщина пластины,м";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Температура пластины,м";
            // 
            // TempPlast
            // 
            this.TempPlast.DecimalPlaces = 2;
            this.TempPlast.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.TempPlast.Location = new System.Drawing.Point(151, 38);
            this.TempPlast.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TempPlast.Name = "TempPlast";
            this.TempPlast.Size = new System.Drawing.Size(120, 20);
            this.TempPlast.TabIndex = 3;
            this.TempPlast.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Коэф. теплопроводности";
            // 
            // Koef
            // 
            this.Koef.DecimalPlaces = 2;
            this.Koef.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Koef.Location = new System.Drawing.Point(151, 64);
            this.Koef.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Koef.Name = "Koef";
            this.Koef.Size = new System.Drawing.Size(120, 20);
            this.Koef.TabIndex = 5;
            this.Koef.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Удельная теплоемкость";
            // 
            // Ydel
            // 
            this.Ydel.DecimalPlaces = 2;
            this.Ydel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Ydel.Location = new System.Drawing.Point(151, 90);
            this.Ydel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Ydel.Name = "Ydel";
            this.Ydel.Size = new System.Drawing.Size(120, 20);
            this.Ydel.TabIndex = 7;
            this.Ydel.Value = new decimal(new int[] {
            46,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Шаг по времени";
            // 
            // TimeStep
            // 
            this.TimeStep.DecimalPlaces = 5;
            this.TimeStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.TimeStep.Location = new System.Drawing.Point(151, 167);
            this.TimeStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TimeStep.Name = "TimeStep";
            this.TimeStep.Size = new System.Drawing.Size(120, 20);
            this.TimeStep.TabIndex = 9;
            this.TimeStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Шаг по толщине";
            // 
            // SizeStep
            // 
            this.SizeStep.DecimalPlaces = 5;
            this.SizeStep.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.SizeStep.Location = new System.Drawing.Point(151, 193);
            this.SizeStep.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SizeStep.Name = "SizeStep";
            this.SizeStep.Size = new System.Drawing.Size(120, 20);
            this.SizeStep.TabIndex = 11;
            this.SizeStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Температура слева";
            // 
            // LeftTemp
            // 
            this.LeftTemp.DecimalPlaces = 2;
            this.LeftTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.LeftTemp.Location = new System.Drawing.Point(151, 116);
            this.LeftTemp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.LeftTemp.Minimum = new decimal(new int[] {
            271,
            0,
            0,
            -2147483648});
            this.LeftTemp.Name = "LeftTemp";
            this.LeftTemp.Size = new System.Drawing.Size(120, 20);
            this.LeftTemp.TabIndex = 13;
            this.LeftTemp.Value = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Температура справа";
            // 
            // RightTemp
            // 
            this.RightTemp.DecimalPlaces = 2;
            this.RightTemp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.RightTemp.Location = new System.Drawing.Point(151, 143);
            this.RightTemp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.RightTemp.Minimum = new decimal(new int[] {
            271,
            0,
            0,
            -2147483648});
            this.RightTemp.Name = "RightTemp";
            this.RightTemp.Size = new System.Drawing.Size(120, 20);
            this.RightTemp.TabIndex = 15;
            this.RightTemp.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chart1
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(314, 92);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(456, 303);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(372, 40);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(398, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Плотность пластины";
            // 
            // PlaneDensity
            // 
            this.PlaneDensity.DecimalPlaces = 2;
            this.PlaneDensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.PlaneDensity.Location = new System.Drawing.Point(151, 248);
            this.PlaneDensity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PlaneDensity.Name = "PlaneDensity";
            this.PlaneDensity.Size = new System.Drawing.Size(120, 20);
            this.PlaneDensity.TabIndex = 19;
            this.PlaneDensity.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Шагов по времени";
            // 
            // TimeCount
            // 
            this.TimeCount.DecimalPlaces = 2;
            this.TimeCount.Location = new System.Drawing.Point(151, 220);
            this.TimeCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TimeCount.Name = "TimeCount";
            this.TimeCount.Size = new System.Drawing.Size(120, 20);
            this.TimeCount.TabIndex = 21;
            this.TimeCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // TimeText
            // 
            this.TimeText.AutoSize = true;
            this.TimeText.Location = new System.Drawing.Point(379, 19);
            this.TimeText.Name = "TimeText";
            this.TimeText.Size = new System.Drawing.Size(40, 13);
            this.TimeText.TabIndex = 23;
            this.TimeText.Text = "Время";
            // 
            // MiddleTemp
            // 
            this.MiddleTemp.AutoSize = true;
            this.MiddleTemp.Location = new System.Drawing.Point(311, 409);
            this.MiddleTemp.Name = "MiddleTemp";
            this.MiddleTemp.Size = new System.Drawing.Size(121, 13);
            this.MiddleTemp.TabIndex = 24;
            this.MiddleTemp.Text = "Температура в центре";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MiddleTemp);
            this.Controls.Add(this.TimeText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TimeCount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PlaneDensity);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RightTemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LeftTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SizeStep);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TimeStep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Ydel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Koef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TempPlast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tolsh);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tolsh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempPlast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Koef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ydel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlaneDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown Tolsh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TempPlast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Koef;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Ydel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown TimeStep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SizeStep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown LeftTemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown RightTemp;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown PlaneDensity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TimeCount;
        private System.Windows.Forms.Label TimeText;
        private System.Windows.Forms.Label MiddleTemp;
    }
}

