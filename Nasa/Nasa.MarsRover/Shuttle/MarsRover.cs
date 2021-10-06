using Nasa.MarsRover.Entity;
using Nasa.MarsRover.MovementOperation;
using Nasa.MarsRover.MovementOperation.Base;
using Nasa.MarsRover.PositionOperation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.Shuttle
{
    public class MarsRover
    {
        private Position Position;

        public MarsRover(string startPosition,string locationLimit)
        {
            Position = new PositionFactory().SetStartPosition(startPosition, locationLimit);
        }

        public Position GetPosition()
        {
            return Position;
        }

        public Position Move(string moves)
        {
            foreach (var item in moves.ToCharArray())
            {
                switch (item)
                {
                    case 'L':
                        new Left().Move(Position);
                        break;
                    case 'R':
                        new Right().Move(Position);
                        break;
                    case 'M':
                        new Next().Move(Position);
                        break;
                }
            }

            return GetPosition();
        }
    }
}
