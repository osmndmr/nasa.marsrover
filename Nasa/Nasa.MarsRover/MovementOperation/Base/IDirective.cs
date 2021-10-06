using Nasa.MarsRover.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.MovementOperation.Base
{
    public interface IDirective 
    {
        Position Move(Position position); 
    }
}
