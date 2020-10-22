using System;
using System.Collections.Generic;
using System.Text;

namespace IRobo.Domain
{
    public class MapArea
    {
        public int MinY { get; set; }
        public int MaxY { get; set; }
        public int Minx { get; set; }
        public int MaxX { get; set; }
        public PointMap PointMap { get; set; }

        public MapArea()
        {
            MinY = 0;
            MaxY = 4;
            Minx = 0;
            MaxX = 4;
            PointMap = new PointMap();
        }

        public bool ValidAxis(int value)
        {
            if ((value < 0) || (value > 4))
            {
                throw new Exception("WoW, Você não deve ir para lugares desconhecidos!! Este é o limite do mapa!!");
            }
            return true;
        }
    }
}
