using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetriaChivilisation.Game
{
    public class TileMap
    {
        public Vector Size;
        public ITile[,] map;

        public TileMap()
        {

        }

        public void ReadManualMap(string path)
        {
            Bitmap manualmap = new Bitmap(path);

            Size = new Vector((short)manualmap.Width, (short)manualmap.Height);
            map = new ITile[Size.X, Size.Y];

            for (short x = 0; x < Size.X; x++)
            {
                for (short y = 0; y < Size.Y; y++)
                {
                    if (manualmap.GetPixel(x, y) == new Water().Color)
                    {
                        map[x, y] = new Water();
                    }
                    else if (manualmap.GetPixel(x, y) == new Сhampaign().Color)
                    {
                        map[x, y] = new Сhampaign();
                    }
                    else if (manualmap.GetPixel(x, y) == new Forest().Color)
                    {
                        map[x, y] = new Forest();
                    }
                    else if (manualmap.GetPixel(x, y) == new Mountains().Color)
                    {
                        map[x, y] = new Mountains();
                    }
                }
            }
        }
    }
}
