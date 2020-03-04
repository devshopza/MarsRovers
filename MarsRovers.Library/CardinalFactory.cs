using System;

namespace MarsRovers.Library
{
    public static class CardinalFactory
    {
        public static ICardinal GetCardinal(string type)
        {
            switch (type)
            {
                case "N":
                    return new NorthCardinal();
                case "E":
                    return new EastCardinal();
                case "S":
                    return new SouthCardinal();
                case "W":
                    return new WestCardinal();
                default:
                    throw new Exception("Unknown Cardinal.");
            }
        }
    }
}
