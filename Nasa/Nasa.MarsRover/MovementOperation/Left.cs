using Nasa.MarsRover.Entity;
using Nasa.MarsRover.MovementOperation.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.MovementOperation
{
    public class Left : IDirective
    {
        private string direction;

        public Position Move(Position position)
        {
            switch (position.Direction)
            {
                case "S":
                    direction = "E";
                    break;

                case "N":
                    direction = "W";
                    break;

                case "E":
                    direction = "N";
                    break;

                case "W":
                    direction = "S";
                    break;
            }
            position.Direction = direction;
            return position;
        }
    }
}
