using Nasa.MarsRover.Entity;
using Nasa.MarsRover.MovementOperation.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.MovementOperation
{
    public class Right : IDirective
    {
        private string direction;

        public Position Move(Position position)
        {
            switch (position.Direction)
            {
                case "S":
                    direction = "W";
                    break;

                case "N":
                    direction = "E";
                    break;

                case "E":
                    direction = "S";
                    break;

                case "W":
                    direction = "N";
                    break;
            }
            position.Direction = direction;
            return position;
        }
    }
}
