using System;

namespace MarsRovers.Library
{
    public class NorthCardinal : ICardinal 
    {
        private const string description = "N";

        public ICardinal RotateLeft()
        {
            return new WestCardinal();
        }

        public ICardinal RotateRight()
        {
            return new EastCardinal();
        }

        public Coordinates Proceed(Coordinates coordinates)
        {
            return new Coordinates(coordinates.X, coordinates.Y + 1);
        }

        public override string ToString()
        {
            return description;
        }      

    }
}
