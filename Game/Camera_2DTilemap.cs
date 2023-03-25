using WinForms_GameCore.EngineCore;

namespace WinForms_GameCore.Game
{
    internal class Camera_2DTilemap : ICamera
    {
        TileGameWorld World;

        Graphics graphics;

        Bitmap bitmap;
        Point SizePerCell;
        Point Position;
        short CellSize;

        byte GridWidth = 1;

        public PictureBox PictureBox { get; set; }


        public Camera_2DTilemap(PictureBox PictureBox, TileGameWorld TileGameWorld, Point StartCameraPosition, Point StartCameraSizePerCells)
        {
            this.World = TileGameWorld;
            this.PictureBox = PictureBox;
            this.PictureBox.WaitOnLoad = false;

            Position = StartCameraPosition;
            this.SizePerCell = StartCameraSizePerCells;

            Resize();
        }

        public void Resize()
        {
            bitmap = new Bitmap(new Bitmap(PictureBox.Width, PictureBox.Height));
            graphics = Graphics.FromImage(bitmap);

            CellSize = (short)((PictureBox.Size.Width - ((GridWidth * 2) + (SizePerCell.X * GridWidth))) / SizePerCell.X);

            if ((CellSize * (SizePerCell.Y + GridWidth)) + (GridWidth * 2) > PictureBox.Size.Height)
            {
                CellSize = (short)((PictureBox.Size.Height - ((GridWidth * 2) + (SizePerCell.Y * GridWidth))) / SizePerCell.Y);
            }

            MakeFrame(true);
        }


        void ICamera.MakeFrame()
        {
            MakeFrame(false);
        }

        void MakeFrame(bool FullRedraw)
        {
            graphics = Graphics.FromImage(bitmap);

            if (FullRedraw)
            {
                for (short x = 0; x < SizePerCell.X; x++)
                {
                    for (short y = 0; y < SizePerCell.Y; y++)
                    {
                        FillCell(new Point(x, y));
                        World.NeedRender[x, y] = false;
                    }
                }
            }
            else
            {
                for (short x = 0; x < SizePerCell.X; x++)
                {
                    for (short y = 0; y < SizePerCell.Y; y++)
                    {
                        if (World.NeedRender[x + Position.X, y + Position.Y])
                        {
                            FillCell(new Point(x, y));
                            World.NeedRender[x, y] = false;
                        }
                    }
                }
            }

            PictureBox.Image = bitmap;

            //----
            void FillCell(Point Cell)
            {
                Point CellPositionOnCamera = new Point(GridWidth + (Cell.X * (CellSize + GridWidth)), GridWidth + (Cell.Y * (CellSize + GridWidth)));
                Point CellPositionOnWorld = new Point(Position.X + Cell.X, Position.Y + Cell.Y);

                graphics.FillRectangle(new SolidBrush(World.Landscape[CellPositionOnWorld.X, CellPositionOnWorld.Y].Color), CellPositionOnCamera.X, CellPositionOnCamera.Y, CellSize, CellSize);
            }
        }
    }
}
