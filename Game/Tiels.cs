using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WinForms_GameCore.Game
{
    public interface ITile
    {
        string Name { get; }
        Color Color { get; }

        byte FoodStandart { get; }
        byte Food { get; set; }

        byte ResoursType { get; }
        byte Resourse { get; }

    }

    public class Water : ITile
    {
        public string Name { get; } = "Вода";
        public Color Color { get; } = Color.FromArgb(0, 200, 220);

        public byte FoodStandart { get; } = 10;
        public byte Food { get; set; } = 10;

        public byte ResoursType { get; } = 0;
        public byte Resourse { get; } = 0;
    }

    public class Сhampaign : ITile
    {
        public string Name { get; } = "Равнины";
        public Color Color { get; } = Color.FromArgb(0, 255, 1);

        public byte FoodStandart { get; } = 30;
        public byte Food { get; set; } = 30;

        public byte ResoursType { get; } = 0;
        public byte Resourse { get; } = 10;
    }

    public class Forest : ITile
    {
        public string Name { get; } = "Лес";
        public Color Color { get; } = Color.FromArgb(0, 160, 50);

        public byte FoodStandart { get; } = 20;
        public byte Food { get; set; } = 20;

        public byte ResoursType { get; } = 0;
        public byte Resourse { get; } = 25;
    }

    public class Mountains : ITile
    {
        public string Name { get; } = "Горы";
        public Color Color { get; } = Color.FromArgb(160, 160, 160);

        public byte FoodStandart { get; } = 10;
        public byte Food { get; set; } = 10;

        public byte ResoursType { get; } = 1;
        public byte Resourse { get; } = 15;
    }

    /*
    public class Drest : ITile
    {
        public string Name { get; } = "Пустыня";
        public Color Color { get; } = Color.FromArgb(255, 125, 0);
    }
    */
}
