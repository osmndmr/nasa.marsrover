using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.Entity
{
    public class Position
    {
        public Location Location;
        public string Direction;
        public string Error;


        public Position(Location location,string direction)
        {
            Direction = direction;
            Location = location;
        }
    }
}
