using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimLab3
{
    public partial class Form1 : Form
    {
        Env env;
        State[][] oldStates;
        private Bitmap canvas;
        private Panel paramPanel; 

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
            this.Resize += (s, e) => Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawEnv(e.Graphics);
        }

        private void DrawEnv(Graphics g)
        {
            if (env == null) return;

            int size = env.size;
            int panelWidth = paramPanel?.Width ?? 0;
            int availableWidth = ClientSize.Width - panelWidth;
            int cellSize = Math.Min(availableWidth / size, ClientSize.Height / size);
            if (cellSize < 1) cellSize = 1;

            if (canvas == null || canvas.Width != availableWidth || canvas.Height != ClientSize.Height)
            {
                canvas?.Dispose();
                canvas = new Bitmap(availableWidth, ClientSize.Height);

                using (var canvasG = Graphics.FromImage(canvas))
                {
                    canvasG.Clear(BackColor);
                    DrawAllCells(canvasG, cellSize);
                }

                oldStates = new State[size][];
                for (int i = 0; i < size; i++)
                {
                    oldStates[i] = new State[size];
                    for (int j = 0; j < size; j++)
                        oldStates[i][j] = env.map[i][j].state;
                }
            }
            else
            {
                using (var canvasG = Graphics.FromImage(canvas))
                {
                    for (int row = 0; row < size; row++)
                    {
                        for (int col = 0; col < size; col++)
                        {
                            Cell cell = env.map[row][col];
                            if (cell.state != oldStates[row][col])
                            {
                                Color color = cell.state == State.Tree ? Color.Green :
                                             cell.state == State.Fire ? Color.Yellow :
                                             cell.state == State.Void ? Color.Brown : Color.Gray;

                                using (var brush = new SolidBrush(color))
                                {
                                    canvasG.FillRectangle(brush, col * cellSize, row * cellSize, cellSize, cellSize);
                                }
                                canvasG.DrawRectangle(Pens.Black, col * cellSize, row * cellSize, cellSize, cellSize);

                                oldStates[row][col] = cell.state;
                            }
                        }
                    }
                }
            }

            g.DrawImage(canvas, 0, 0);
        }

        private void DrawAllCells(Graphics g, int cellSize)
        {
            int size = env.size;
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Cell cell = env.map[row][col];
                    Color color = cell.state == State.Tree ? Color.Green :
                                 cell.state == State.Fire ? Color.Yellow :
                                 cell.state == State.Void ? Color.Brown : Color.Gray;

                    using (var brush = new SolidBrush(color))
                    {
                        g.FillRectangle(brush, col * cellSize, row * cellSize, cellSize, cellSize);
                    }
                    g.DrawRectangle(Pens.Black, col * cellSize, row * cellSize, cellSize, cellSize);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            env = new Env(100);
            EnvTimer.Enabled = true;
            SetupParameterControls();
        }

        int ticks = 0;
        private void EnvTimer_Tick(object sender, EventArgs e)
        {
            ticks += 1;
            env.Tick();
            if (ticks % 2 != 0) return;
            Invalidate();
        }

        private void SetupParameterControls()
        {
            paramPanel = new Panel
            {
                Dock = DockStyle.Right,
                Width = 340,
                BackColor = Color.FromArgb(240, 240, 240),
                Padding = new Padding(5)
            };

            var table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                Padding = new Padding(5),
                AutoScroll = true,
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));

            AddParameterRow(table, "Шанс удара молнии:", "BaseIgnition", 0, 0.000001m, 0.001m, 0.00001m, 6);
            AddParameterRow(table, "Шанс распространения огня:", "FireSpread", 1, 0m, 1m, 0.1m, 3);
            AddParameterRow(table, "Базовый шанс тушения:", "BaseExtinction", 2, 0m, 1m, 0.1f, 3);
            AddParameterRow(table, "Коэфф. тушения от деревьев:", "TreeInfluence", 3, 0m, 1m, 0.25f, 3);
            AddParameterRow(table, "Шанс роста дерева:", "VoidRegrowth", 4, 0m, 0.1m, 0.01f, 4);
            AddParameterRow(table, "Коэфф. мертвой земли:", "DeathDecay", 5, 1m, 5m, 2f, 2);
            AddParameterRow(table, "Размер поля:", "FieldSize", 6, 10m, 500m, 100, 0);

            var restartButton = new Button
            {
                Text = "Restart",
                Dock = DockStyle.Fill,
                Height = 30,
                BackColor = Color.LightCoral,
                FlatStyle = FlatStyle.Flat
            };
            restartButton.Click += (s, e) => RestartSimulation();
            table.Controls.Add(restartButton, 0, 7);
            table.SetColumnSpan(restartButton, 2);

            paramPanel.Controls.Add(table);
            this.Controls.Add(paramPanel);
        }

        private void AddParameterRow(TableLayoutPanel table, string labelText, string paramName, int row, decimal min, decimal max, dynamic defaultValue, int decimals)
        {
            Console.WriteLine($"Added row {row}: {labelText}");

            var label = new Label
            {
                Text = labelText,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Padding = new Padding(0, 5, 0, 5)
            };
            table.Controls.Add(label, 0, row);

            var nud = new NumericUpDown
            {
                Minimum = min,
                Maximum = max,
                DecimalPlaces = decimals,
                Increment = decimals >= 4 ? 0.0001m : (decimals >= 2 ? 0.01m : 1m),
                Value = (decimal)defaultValue,
                Width = 80,
                Dock = DockStyle.Right
            };

            if (paramName == "BaseIgnition")
                nud.ValueChanged += (s, e) => { if (env != null) env.BaseIgnitionChance = (float)nud.Value; };
            else if (paramName == "FireSpread")
                nud.ValueChanged += (s, e) => { if (env != null) env.FireSpreadFactor = (float)nud.Value; };
            else if (paramName == "BaseExtinction")
                nud.ValueChanged += (s, e) => { if (env != null) env.BaseExtinctionChance = (float)nud.Value; };
            else if (paramName == "TreeInfluence")
                nud.ValueChanged += (s, e) => { if (env != null) env.TreeInfluenceOnExtinction = (float)nud.Value; };
            else if (paramName == "VoidRegrowth")
                nud.ValueChanged += (s, e) => { if (env != null) env.VoidRegrowthChance = (float)nud.Value; };
            else if (paramName == "DeathDecay")
                nud.ValueChanged += (s, e) => { if (env != null) env.DeathDecayFactor = (float)nud.Value; };
            else if (paramName == "FieldSize")
                nud.ValueChanged += (s, e) => {
                    if (env != null)
                    {
                        RestartSimulation();
                        canvas = null;
                        Invalidate();
                        RestartSimulation();
                    }
                };

            table.Controls.Add(nud, 1, row);
        }


        private void RestartSimulation()
        {
            if (env == null) return;

            int currentSize = env.size;

            float baseIgnition = env.BaseIgnitionChance;
            float fireSpread = env.FireSpreadFactor;
            float baseExtinction = env.BaseExtinctionChance;
            float treeInfluence = env.TreeInfluenceOnExtinction;
            float voidRegrowth = env.VoidRegrowthChance;
            float deathDecay = env.DeathDecayFactor;

            env = new Env(currentSize);

            env.BaseIgnitionChance = baseIgnition;
            env.FireSpreadFactor = fireSpread;
            env.BaseExtinctionChance = baseExtinction;
            env.TreeInfluenceOnExtinction = treeInfluence;
            env.VoidRegrowthChance = voidRegrowth;
            env.DeathDecayFactor = deathDecay;

            canvas = null;
            Invalidate();
        }
    }

    public enum State { Tree, Fire, Void }

    public class Cell
    {
        public static Random rng = new Random();

        public int x;
        public int y;

        public float deaths;

        public Env env;
        public State state;

        public Cell(State initialState, int posX, int posY)
        {
            state = initialState;
            x = posX;
            y = posY;
        }

        private bool Inside(int i, int j) => i >= 0 && i < env.size && j >= 0 && j < env.size;

        public List<EnvChange> ApplyRules()
        {
            if (state == State.Tree)
                return ApplyTreeRules();
            else if (state == State.Fire)
                return ApplyFireRules();
            else
                return ApplyVoidRules();
        }

        public List<EnvChange> ApplyTreeRules()
        {
            List<EnvChange> result = new List<EnvChange>();

            float fireFactor = 0.0f;
            int x = this.x;
            int y = this.y;

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (Inside(i, j) && (i != x || j != y) && env.map[i][j].state == State.Fire)
                    {
                        fireFactor += env.FireSpreadFactor;
                    }
                }
            }

            float rn = (float)rng.NextDouble();
            float xFactor = (x - env.size * 0.5f) * (x - env.size * 0.5f) / env.size / env.size * 4;
            float yFactor = (y - env.size * 0.5f) * (y - env.size * 0.5f) / env.size / env.size * 4;
            float posFactor = xFactor + yFactor;

            if (rn < fireFactor * posFactor + env.BaseIgnitionChance)
            {
                result.Add(new EnvChangeState(this, State.Fire));
            }
            return result;
        }

        public List<EnvChange> ApplyFireRules()
        {
            List<EnvChange> result = new List<EnvChange>();

            float treeNeighbors = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (Inside(i, j) && (i != x || j != y) && env.map[i][j].state == State.Tree)
                    {
                        treeNeighbors += 1;
                    }
                }
            }

            float factor = (float)Math.Pow(1 + treeNeighbors * env.TreeInfluenceOnExtinction, 2);
            if (rng.NextDouble() * factor < env.BaseExtinctionChance)
            {
                result.Add(new EnvChangeState(this, State.Void));
                deaths += 1;
            }
            return result;
        }

        public List<EnvChange> ApplyVoidRules()
        {
            List<EnvChange> result = new List<EnvChange>();
            if (rng.NextDouble() < env.VoidRegrowthChance / Math.Pow(env.DeathDecayFactor, deaths + 1))
            {
                result.Add(new EnvChangeState(this, State.Tree));
            }
            return result;
        }
    }

    public class Env
    {
        public float BaseIgnitionChance = 0.00001f;
        public float FireSpreadFactor = 0.1f;
        public float BaseExtinctionChance = 0.1f;
        public float TreeInfluenceOnExtinction = 0.25f;
        public float VoidRegrowthChance = 0.01f;
        public float DeathDecayFactor = 2.0f;

        private static Random rng = new Random();
        private Queue<EnvChange> envChanges;
        public int size;
        public Cell[][] map;

        public Env(int sizeArg)
        {
            size = sizeArg;
            envChanges = new Queue<EnvChange>();

            map = new Cell[size][];
            for (int i = 0; i < size; i++)
            {
                map[i] = new Cell[size];
                for (int j = 0; j < size; j++)
                {
                    float entityTypeRng = (float)rng.NextDouble();
                    Cell cellToCreate;
                    if (entityTypeRng < 0.8f)
                    {
                        cellToCreate = new Cell(State.Tree, i, j);
                    }
                    else
                    {
                        cellToCreate = new Cell(State.Void, i, j);
                    }
                    cellToCreate.env = this;
                    map[i][j] = cellToCreate;
                }
            }
        }

        public void Tick()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    foreach (var change in map[i][j].ApplyRules())
                    {
                        envChanges.Enqueue(change);
                    }
                }
            }

            while (envChanges.Count > 0)
            {
                envChanges.Dequeue().Apply();
            }
        }
    }

    public abstract class EnvChange
    {
        public abstract void Apply();
    }

    public class EnvChangeState : EnvChange
    {
        public State newState;
        public Cell context;

        public EnvChangeState(Cell contextArg, State newStateArg)
        {
            newState = newStateArg;
            context = contextArg;
        }
        public override void Apply()
        {
            context.state = newState;
        }
    }
}