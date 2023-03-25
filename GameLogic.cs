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
        TileGameWorld World;

        Point Now = new Point();

        public GameLogic(CoreForm coreForm) : base(coreForm) { }

        public override void LoadGame()
        {
            World = new TileGameWorld().GetLandscapeFromBitmap(Properties.Resources.DeafulMap);

            Camera = new Camera_2DTilemap(CoreForm.MainDisplay, World, new Point(0,0), new Point(50,50));
        }

        public override void Update()
        {
            Now.X ++;
            if (Now.X == World.Size.X)
            {
                Now.X = 0;
                Now.Y++;
            }
            if (Now.Y == World.Size.Y)
            {
                Now.Y = 0;
            }

            if (World.Landscape[Now.X, Now.Y] is Water)
            {
                World.Landscape[Now.X, Now.Y] = new Mountains();
                World.NeedRender[Now.X, Now.Y] = true;
            }
        }
    }
}
