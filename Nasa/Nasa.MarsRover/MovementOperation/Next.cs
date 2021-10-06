using Nasa.MarsRover.Entity;
using Nasa.MarsRover.MovementOperation.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.MovementOperation
{
    public class Next : IDirective
    {
        public Position Move(Position position)
        {

            switch (position.Direction)
            {
                case "E":
                    position.Location.X += 1;
                    break;
                case "W":
                    position.Location.X -= 1;
                    break;
                case "N":
                    position.Location.Y += 1;
                    break;
                case "S":
                    position.Location.Y -= 1;
                    break;
            }
            if (position.Location.X > position.Location.maxX || position.Location.Y>position.Location.maxY)
            {
                position.Error = "MarsRover over limit";
            }
            return position;
        }
    }
}
