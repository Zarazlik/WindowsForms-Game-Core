using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetriaChivilisation.Game;

namespace WinForms_GameCore.Game;

public class Camera_2DCell_2
{
    static Point BitmapSize;

    public TileMap TileMap;
    public PictureBox pictureBox;
    public static Bitmap bitmap;

    public Camera_2DCell_2(TileMap TileMap, PictureBox pictureBox)
    {
        this.TileMap = TileMap;
        short x = (short)(TileMap.Size.X * 5);
        short y = (short)(TileMap.Size.Y * 5);

        this.pictureBox = pictureBox;
        pictureBox.Size = new Size(x + 1, y + 1);
        this.pictureBox.WaitOnLoad = false;

        BitmapSize = new Point((short)(x + 1), (short)(y + 1));
        bitmap = new Bitmap(BitmapSize.X, BitmapSize.Y);
    }

    public void Update(List<Point> ChanegesCells)
    {
        foreach (var Point in ChanegesCells)
        {
            FillCell(Point);
        }

        pictureBox.Image = bitmap;
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

        pictureBox.Image = bitmap;
    }

    public void Grid()
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
