using System.ComponentModel;
using System.Diagnostics;

using PetriaChivilisation.Game;

namespace PetriaChivilisation
{
    public partial class CoreForm : Form
    {
        Display Display;
        TileMap map;
        GameLogic Logic;

        int MaxFPS = 0, MinFPS = 1000;
        int FPScount;
        long LogicTime;

        static List<Vector> ChaingesCells;

        Stopwatch stopwatch = new Stopwatch();

        public CoreForm()
        {
            InitializeComponent();

            map = new TileMap();
            map.ReadManualMap("C:\\Users\\Zaraz\\OneDrive\\Рабочий стол\\Карта2.png");

            Display = new Display(map, pictureBox1);
            Display.LoadMap();

            Logic = new GameLogic(map);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FpsLimiter.Start();
            FpsCounterTimer.Start();
        }

        private void FpsLimiter_Tick(object sender, EventArgs e)
        {
            FrameUpdate();
        }

        private void FpsCounterTimer_Tick(object sender, EventArgs e)
        {
            FpsLabel2.Text = FPScount.ToString();

            if (FPScount > MaxFPS)
            {
                MaxFPS = FPScount;
                MaxFpsLable2.Text = MaxFPS.ToString();
            }
            else if (FPScount < MinFPS)
            {
                MinFPS = FPScount;
                MinFpsLable2.Text = MinFPS.ToString();
            }
            FPScount = 0;

            LogicLabel2.Text = LogicTime.ToString();
            LogicTime = 0;
        }

        async public void FrameUpdate()
        {

            (ChaingesCells, long nans ) = await Task.Run(Logic.Frame);

            LogicTime += nans;

            Display.Update(ChaingesCells);

            FPScount++;
        }
    }
}