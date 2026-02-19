using System;
using System.Security.Policy;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "параметр dt";
            dataGridView1.Columns[1].Name = (stepBox.Value).ToString();
            dataGridView1.Columns[2].Name = (stepBox.Value*0.1M).ToString();
            dataGridView1.Columns[3].Name = (stepBox.Value*0.01M).ToString();
            dataGridView1.Columns[4].Name = (stepBox.Value*0.001M).ToString();
            dataGridView1.Columns[5].Name = (stepBox.Value*0.0001M).ToString();

            dataGridView1.Rows.Add("Дальность полёта, м");
            dataGridView1.Rows.Add("Максимальная высота, м");
            dataGridView1.Rows.Add("Скорость в конечной точке, м/с");
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void weightBox_ValueChanged(object sender, EventArgs e) { }

        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        double t, x, y, v0, cosa, sina, S, m, k, vx, vy;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        double dt = 0.1;
        int curDt = 0;

        double[] ranges = new double[5];
        double[] maxHeights = new double[5];
        double[] finalSpeeds = new double[5];

        private void timer2_Tick(object sender, EventArgs e)
        {
            double st = (double)stepBox.Value;
            double[] dts = new double[5] { st, st*0.1, st * 0.01, st * 0.001, st * 0.0001 };

            if (!timer1.Enabled && curDt < dts.Length)
            {
                dt = dts[curDt];

                chart1.Series.Add("Траектория-" + dts[curDt].ToString());
                chart1.Series[chart1.Series.Count - 1].ChartType = SeriesChartType.Line;

                t = 0;
                x = 0;
                y = (double)heightBox.Value;
                v0 = (double)speedBox.Value;
                double a = (double)angleBox.Value * Math.PI / 180;
                cosa = Math.Cos(a);
                sina = Math.Sin(a);
                S = (double)sizeBox.Value;
                m = (double)weightBox.Value;
                k = 0.5 * C * rho * S / Math.Max(m, 1e-7);
                vx = v0 * cosa;
                vy = v0 * sina;

                chart1.Series[chart1.Series.Count - 1].Points.AddXY(x, y);

                maxHeights[curDt] = 0;

                curDt++;
                timer1.Start();
            }

            if (curDt >= dts.Length && !timer1.Enabled )
            {
                timer2.Stop();
                curDt = 0;

                for (int i = 0; i < 5; i++)
                {
                    dataGridView1.Rows[0].Cells[i + 1].Value = ranges[i].ToString("F2");
                    dataGridView1.Rows[1].Cells[i + 1].Value = maxHeights[i].ToString("F2");
                    dataGridView1.Rows[2].Cells[i + 1].Value = finalSpeeds[i].ToString("F2");
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            int loops = (int)(0.033 / dt);
            if (loops < 1) loops = 1;

            for (int i = 0; i < loops; i++)
            {
                t += dt;
                double v = Math.Sqrt(vx * vx + vy * vy);
                vx -= k * vx * v * dt;
                vy -= (g + k * vy * v) * dt;
                x += vx * dt;
                y += vy * dt;

                if (y > maxHeights[curDt-1])
                    maxHeights[curDt-1] = y;

                if (y <= 0)
                {
                    ranges[curDt-1] = x;
                    finalSpeeds[curDt-1] = Math.Sqrt(vx * vx + vy * vy);
                    timer1.Stop();
                    break;
                }

                chart1.Series[chart1.Series.Count - 1].Points.AddXY(x, y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer2.Enabled) return;

            dataGridView1.Columns[0].Name = "параметр dt";
            dataGridView1.Columns[1].Name = (stepBox.Value).ToString();
            dataGridView1.Columns[2].Name = (stepBox.Value * 0.1M).ToString();
            dataGridView1.Columns[3].Name = (stepBox.Value * 0.01M).ToString();
            dataGridView1.Columns[4].Name = (stepBox.Value * 0.001M).ToString();
            dataGridView1.Columns[5].Name = (stepBox.Value * 0.0001M).ToString();

            chart1.Series.Clear();
            curDt = 0;

            Array.Clear(ranges, 0, ranges.Length);
            Array.Clear(maxHeights, 0, maxHeights.Length);
            Array.Clear(finalSpeeds, 0, finalSpeeds.Length);

            timer2.Start();
        }
    }
}