using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.Entity
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int maxX { get; set; }
        public int maxY { get; set; }

        public Location(int x,int y,int xMax,int yMax)
        {
            X = x;
            Y = y;
            maxX = xMax;
            maxY = yMax;
        }
    }
}
