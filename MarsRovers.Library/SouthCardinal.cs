using System;

namespace MarsRovers.Library
{
    public class SouthCardinal : ICardinal
    {
        private const string description = "S";

        public ICardinal RotateLeft()
        {
            return new EastCardinal();
        }

        public ICardinal RotateRight()
        {
            return new WestCardinal();
        }

        public Coordinates Proceed(Coordinates coordinates)
        {
            return new Coordinates(coordinates.X, coordinates.Y - 1);
        }

        public override string ToString()
        {
            return description;
        }

    }
}
