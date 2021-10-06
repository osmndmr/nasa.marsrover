using System;
using System.Collections.Generic;
using System.Text;

namespace Nasa.MarsRover.Helper
{
    public class Converter
    {
        public static int StringToInt(string stringInteger)
        {
            int value;
            var parser = int.TryParse(stringInteger, out value);
            if (parser)
                return value;

            throw new Exception("Coordinate is not correct.");
        }

        public static char StringToChar(string stringChar)
        {
            char value;
            var parser = char.TryParse(stringChar, out value);
            if (parser)
                return value;

            throw new Exception("Value is not char.");
        }
    }
}
