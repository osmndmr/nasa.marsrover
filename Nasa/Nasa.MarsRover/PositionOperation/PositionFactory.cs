using Nasa.MarsRover.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.PositionOperation
{
    public class PositionFactory
    {
        private int x, y,xMax,yMax;
        private List<string> directions = new List<string>() { "E", "N", "W", "S" };
        private Position errorPosition = new Position(new Location(0, 0, 0, 0), "");

        public Position SetStartPosition(string startPosition,string locationLimit)
        {
            string[] directionList = startPosition.TrimEnd().TrimStart().Split(' ');
            string[] locationValue = locationLimit.TrimEnd().TrimStart().Split(' ');

            if (directionList.Length == 3)
            {
                if (!directions.Contains(directionList[2]))
                {
                    errorPosition.Error = "Direction is not Correct.";
                    return errorPosition;
                }

                string startX = directionList[0];
                x = Helper.Converter.StringToInt(startX);

                string startY = directionList[1];
                y = Helper.Converter.StringToInt(startY);

                string maxX = locationValue[0];
                xMax = Helper.Converter.StringToInt(maxX);

                string maxY = locationValue[1];
                yMax = Helper.Converter.StringToInt(maxY);

                string direction = directionList[2];
                var location = new Location(x, y,xMax,yMax);

                return new Position(location, direction);
            }

            errorPosition.Error="Given parameters are not correct.Please try again with correct parameters.";
            return errorPosition;
        }
    }
}
