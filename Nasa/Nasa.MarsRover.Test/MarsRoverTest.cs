using System;
using Xunit;

namespace Nasa.MarsRover.Test
{
    public class MarsRoverTest
    {
        [Fact]
        public void Move_Success()
        {
            MarsRover.Shuttle.MarsRover marsRover = new Shuttle.MarsRover("1 2 N","5 5");
            marsRover.Move("LMLMLMLMM");

            Assert.Equal(1, marsRover.GetPosition().Location.X);
            Assert.Equal(3, marsRover.GetPosition().Location.Y);
            Assert.Equal("N", marsRover.GetPosition().Direction);
        }
        [Fact]
        public void Move_OutOfCoordinate()
        {
            MarsRover.Shuttle.MarsRover marsRover = new Shuttle.MarsRover("1 2 N", "5 5");
            marsRover.Move("MMMMM");

            Assert.Equal("MarsRover over limit", marsRover.GetPosition().Error);
           
        }

        [Fact]
        public void Move_NotCorrectParameter()
        {
            MarsRover.Shuttle.MarsRover marsRover = new Shuttle.MarsRover("1 2 3 N ", "5 5");
            marsRover.Move("LMLMLMLMM");

            Assert.Equal("Given parameters are not correct.Please try again with correct parameters.", marsRover.GetPosition().Error);
        }

        [Fact]
        public void Move_NotValidDirection()
        {
            MarsRover.Shuttle.MarsRover marsRover = new Shuttle.MarsRover("1 2 A", "5 5");
            marsRover.Move("LMLMLMLMM");

            Assert.Equal("Direction is not Correct.", marsRover.GetPosition().Error);
        }
    }
}
