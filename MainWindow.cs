using PetriaChivilisation.FPS;

namespace WinForms_GameCore
{
    public partial class MainWindow : EngineCore.CoreForm
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadGame();
            StartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FpsWindow.Show();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            Logic.Camera.Resize();
        }
    }
}
