using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_GameCore.Game
{
    public struct TileGameWorld
    {
        public Point Size;

        public ITile[,] Landscape;
        public bool[,] NeedRender { get; set; }

        public TileGameWorld GetLandscapeFromBitmap(Bitmap bitmap)
        {
            this = new TileGameWorld();
            Size = new Point((short)bitmap.Width, (short)bitmap.Height);
            Landscape = new ITile[Size.X, Size.Y];
            NeedRender = new bool[Size.X, Size.Y];

            for (short x = 0; x < Size.X; x++)
            {
                for (short y = 0; y < Size.Y; y++)
                {
                    if (bitmap.GetPixel(x, y) == new Water().Color)
                    {
                        Landscape[x, y] = new Water();
                    }
                    else if (bitmap.GetPixel(x, y) == new Сhampaign().Color)
                    {
                        Landscape[x, y] = new Сhampaign();
                    }
                    else if (bitmap.GetPixel(x, y) == new Forest().Color)
                    {
                        Landscape[x, y] = new Forest();
                    }
                    else if (bitmap.GetPixel(x, y) == new Mountains().Color)
                    {
                        Landscape[x, y] = new Mountains();
                    }
                }
            }

            return this;
        }
    }
}
