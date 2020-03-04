using System;

namespace MarsRovers.Library
{
    public class WestCardinal : ICardinal
    {
        private const string description = "W";

        public ICardinal RotateLeft()
        {
            return new SouthCardinal();
        }

        public ICardinal RotateRight()
        {
            return new NorthCardinal();
        }

        public Coordinates Proceed(Coordinates coordinates)
        {
            return new Coordinates(coordinates.X - 1, coordinates.Y);
        }

        public override string ToString()
        {
            return description;
        }

    }
}
