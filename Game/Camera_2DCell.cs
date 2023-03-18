using PetriaChivilisation.Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_GameCore.EngineCore;

namespace WinForms_GameCore.Game
{
    internal class Camera_2DCell : ICamera
    {
        public PictureBox PictureBox { get; set; }
        TileMap TileMap;
        Bitmap bitmap;

        static Point BitmapSize;

        public Camera_2DCell(PictureBox PictureBox, TileMap TileMap) 
        { 
            this.TileMap = TileMap;
            short x = (short)(TileMap.Size.X * 5);
            short y = (short)(TileMap.Size.Y * 5);

            this.PictureBox = PictureBox;
            PictureBox.Size = new Size(x + 1, y + 1);
            this.PictureBox.WaitOnLoad = false;

            BitmapSize = new Point((short)(x + 1), (short)(y + 1));
            bitmap = new Bitmap(BitmapSize.X, BitmapSize.Y);
        }

        void ICamera.MakeFrame()
        {
            Grid();

            for (short x = 0; x < TileMap.Size.X; x++)
            {
                for (short y = 0; y < TileMap.Size.Y; y++)
                {
                    FillCell(new Point(x, y));
                }
            }

            PictureBox.Image = bitmap;
        }

        public void LoadMap()
        {
            Grid();

            for (short x = 0; x < TileMap.Size.X; x++)
            {
                for (short y = 0; y < TileMap.Size.Y; y++)
                {
                    FillCell(new Point(x, y));
                }
            }

            PictureBox.Image = bitmap;

            
        }
        void Grid()
        {
            Color CellColor = Color.FromArgb(220, 220, 220);

            for (short x = 4; x < BitmapSize.X; x += 5)
            {
                for (short y = 0; y < BitmapSize.Y; y++)
                {
                    bitmap.SetPixel(x, y, CellColor);
                }
            }

            for (short y = 4; y < BitmapSize.Y; y += 5)
            {
                for (short x = 0; x < BitmapSize.X; x++)
                {
                    bitmap.SetPixel(x, y, CellColor);
                }
            }
        }

        public void FillCell(Point Cell)
        {
            Point CellPosition = new Point((short)(Cell.X * 5), (short)(Cell.Y * 5));

            for (short x = 0; x < 4; x++)
            {
                for (short y = 0; y < 4; y++)
                {
                    bitmap.SetPixel(CellPosition.X + x, CellPosition.Y + y, TileMap.map[Cell.X, Cell.Y].Color);
                }
            }
        }
    }
}
