using System.ComponentModel;
using System.Diagnostics;
using PetriaChivilisation.FPS;
using PetriaChivilisation.Game;
using PetriaChivilisation.Viewing;

namespace PetriaChivilisation
{
    public partial class CoreForm : Form
    {
        Display Display;
        TileMap map;
        GameLogic Logic;

        FpsWindow FpsWindow;
        byte FpsCount;
        long LogicTime;

        static List<Vector> ChaingesCells;

        public CoreForm()
        {
            InitializeComponent();

            map = new TileMap();
            map.ReadManualMap("C:\\Users\\Zaraz\\OneDrive\\Рабочий стол\\Карта2.png");

            Display = new Display(map, pictureBox1);
            Display.LoadMap();

            Logic = new GameLogic(map);
            FpsWindow = new FpsWindow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            FpsLimiter.Start();
            FpsCounterTimer.Start();
        }

        private void FpsLimiter_Tick(object sender, EventArgs e)
        {
            FrameUpdate();
        }

        private void FpsCounterTimer_Tick(object sender, EventArgs e)
        {
            FpsWindow.Update(FpsCount, LogicTime);
            FpsCount = 0;
            LogicTime = 0;
        }

        async public void FrameUpdate()
        {
            (ChaingesCells, long ms ) = await Task.Run(Logic.Frame);

            LogicTime += ms;

            Display.Update(ChaingesCells);

            FpsCount++;
        }

        private void fPSControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FpsWindow.Show();
        }
    }
}