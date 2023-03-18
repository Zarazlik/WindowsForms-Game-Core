using PetriaChivilisation.FPS;
using PetriaChivilisation.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_GameCore.EngineCore;
using WinForms_GameCore.Game;

namespace WinForms_GameCore
{
    internal class GameLogic : EngineLogic
    {
        TileMap map;
        Point Now;

        public GameLogic(CoreForm coreForm) : base(coreForm) { }

        public override void LoadGame()
        {
            map = new TileMap();
            map.ReadManualMap("C:\\Users\\Zaraz\\OneDrive\\Рабочий стол\\Карта2.png");

            Camera = new Camera_2DCell(CoreForm.MainDisplay, map);
        }

        public override void Update()
        {
            Now.X ++;
            if (Now.X == map.Size.X)
            {
                Now.X = 0;
                Now.Y++;
            }
            if (Now.Y == map.Size.Y)
            {
                Now.Y = 0;
            }

            if (map.map[Now.X, Now.Y] is Water)
            {
                map.map[Now.X, Now.Y] = new Mountains();
            }
        }
    }
}
