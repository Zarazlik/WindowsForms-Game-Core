using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using PetriaChivilisation.FPS;
using PetriaChivilisation.Game;
using WinForms_GameCore.EngineCore;
using WinForms_GameCore.Game;

namespace WinForms_GameCore.EngineCore
{
    public partial class CoreForm : Form
    {
        GameLogic Logic;
        public FpsWindow FpsWindow;

        public CoreForm()
        {
            InitializeComponent();

            Logic = new GameLogic(this);
            FpsWindow = new FpsWindow();
        }

        private void FpsLimiter_Tick(object sender, EventArgs e)
        {
            Logic.FrameUpdate();
        }

        private void FpsCounterTimer_Tick(object sender, EventArgs e)
        {
            Logic.GetFPSData();
        }

        internal void LoadGame()
        {
            Logic.LoadGame();
        }

        internal void StartGame()
        {
            FpsLimiter.Start();
            FpsCounterTimer.Start();
        }
    }
}