using System;

namespace MarsRovers.Library
{
    public class NoCardinal : ICardinal
    {
        private const string description = "No Cardinal";

        public ICardinal RotateLeft()
        {
            return this;
        }

        public ICardinal RotateRight()
        {
            return this;
        }

        public Coordinates Proceed(Coordinates coordinates)
        {
            return coordinates;
        }
               
        public override string ToString()
        {
            return description;
        }

    }
}
