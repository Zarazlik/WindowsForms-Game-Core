using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace PetriaChivilisation.Game
{
    class GameLogic
    {
        static TileMap TileMap;
        static Label FPSlable;

        Vector Now;

        public GameLogic(TileMap tilemap)
        {
            TileMap = tilemap;
        }

        public (List<Vector>, long) Frame()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            List<Vector> vectors = new List<Vector>();

            Now.X++;
            if (Now.X == TileMap.Size.X)
            {
                Now.X = 0;
                Now.Y++;
            }
            if (Now.Y == TileMap.Size.Y)
            {
                Now.Y = 0;
            }

            if (TileMap.map[Now.X, Now.Y] is Water)
            {
                TileMap.map[Now.X, Now.Y] = new Mountains();
                vectors.Add(Now);
            }

            stopwatch.Stop();
            return (vectors, stopwatch.ElapsedMilliseconds);
        }
    }
}
