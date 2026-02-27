using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace SimLab2
{
    public partial class Form1 : Form
    {
        private TempRun tempRun;
        private List<float[]> tempHistory = new List<float[]>();
        private float[] xCoordinates;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TempRunSettings settings = new TempRunSettings
            {
                planeProvodka = (float)Koef.Value,
                planeDensity = (float)PlaneDensity.Value,
                planeTemp = (float)TempPlast.Value,
                leftTemp = (float)LeftTemp.Value,
                rightTemp = (float)RightTemp.Value,
                planeTeploemkost = (float)Ydel.Value,
                timeStep = (float)TimeStep.Value,
                sizeStep = (float)SizeStep.Value,
                planeThickness = (float)Tolsh.Value
            };

            tempRun = new TempRun(settings);
            tempHistory.Clear();

            int steps = (int)TimeCount.Value;
            trackBar1.Minimum = 0;
            trackBar1.Maximum = steps;
            trackBar1.Value = 0;

            xCoordinates = tempRun.GetXCoordinates(); 

            for (int step = 0; step <= steps; step++)
            {
                float[] current = tempRun.temps;
                float[] copy = new float[current.Length];
                Array.Copy(current, copy, current.Length);
                tempHistory.Add(copy);
                if (step < steps)
                    tempRun.RunStep();
            }

            UpdateChart(0);
        }

        private void UpdateChart(int stepIndex)
        {
            if (tempHistory.Count == 0 || stepIndex >= tempHistory.Count) return;

            float[] tempsAtStep = tempHistory[stepIndex];
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < xCoordinates.Length; i++)
                chart1.Series[0].Points.AddXY(xCoordinates[i], tempsAtStep[i]);

            chart1.ChartAreas[0].AxisY.Title = "Температура";
            chart1.ChartAreas[0].RecalculateAxesScale();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateChart(trackBar1.Value);
            TimeText.Text = "Время:" +
                (trackBar1.Value * TimeStep.Value).ToString() + " секунд";

            MiddleTemp.Text = "Температура в центре:" + 
                tempHistory[trackBar1.Value][tempHistory[trackBar1.Value].Length/2];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }

    public class TempRun
    {
        public float[] temps;
        private float[] nextTemps;
        private float[] alpha;
        private float[] beta;
        private TempRunSettings settings;
        private float actualH;

        public TempRun(TempRunSettings settingsArg)
        {
            settings = settingsArg;
            Reset();
        }

        public void Reset()
        {
            int nodesCount = (int)Math.Round(settings.planeThickness / settings.sizeStep) + 1;
            actualH = settings.planeThickness / (nodesCount - 1);

            temps = new float[nodesCount];
            nextTemps = new float[nodesCount];
            alpha = new float[nodesCount];
            beta = new float[nodesCount];

            for (int i = 0; i < nodesCount; i++)
                temps[i] = settings.planeTemp;
        }

        public float[] RunStep()
        {
            int N = temps.Length - 1;
            float λ = settings.planeProvodka;
            float ρ = settings.planeDensity;
            float c = settings.planeTeploemkost;
            float τ = settings.timeStep;
            float h = actualH;

            float A = λ / (h * h);
            float C = A;
            float B = (2 * λ) / (h * h) + (ρ * c) / τ;
            float coeff = (ρ * c) / τ;

            alpha[1] = A / B;
            beta[1] = (C * settings.leftTemp + coeff * temps[1]) / B;

            for (int i = 2; i <= N - 1; i++)
            {
                float denom = B - C * alpha[i - 1];
                alpha[i] = A / denom;
                beta[i] = (C * beta[i - 1] + coeff * temps[i]) / denom;
            }

            nextTemps[N] = settings.rightTemp;
            for (int i = N - 1; i >= 1; i--)
                nextTemps[i] = alpha[i] * nextTemps[i + 1] + beta[i];
            nextTemps[0] = settings.leftTemp;

            Array.Copy(nextTemps, temps, temps.Length);
            return temps;
        }

        public float[] GetXCoordinates()
        {
            int n = temps.Length;
            float[] x = new float[n];
            float half = settings.planeThickness / 2f;
            for (int i = 0; i < n; i++)
                x[i] = i * actualH - half;
            return x;
        }
    }

    public struct TempRunSettings
    {
        public float timeStep;         
        public float sizeStep;          
        public float leftTemp;        
        public float rightTemp;      
        public float planeTemp;         
        public float planeThickness;      
        public float planeDensity;      
        public float planeProvodka; // коэффициент теплопроводности
        public float planeTeploemkost; // удельная теплоемкость

        public TempRunSettings(float timeStepA, float sizeStepA, float leftTempA, float rightTempA,
            float planeThicknessA, float planeTempA,
            float planeDensityA, float planeProvodkaA, float planeTeploemkostA)
        {
            timeStep = timeStepA;
            sizeStep = sizeStepA;
            leftTemp = leftTempA;
            rightTemp = rightTempA;
            planeThickness = planeThicknessA;
            planeTemp = planeTempA;
            planeDensity = planeDensityA;
            planeProvodka = planeProvodkaA;
            planeTeploemkost = planeTeploemkostA;
        }
    }
}