using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_GameCore
{
    public partial class MainWindow : EngineCore.CoreForm
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadGame();
            StartGame();
            FpsWindow.Show();
        }
    }
}
