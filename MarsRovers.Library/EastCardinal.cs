namespace MarsRovers.Library
{
    public class EastCardinal : ICardinal
    {
        private const string description = "E";

        public ICardinal RotateLeft()
        {
            return new NorthCardinal();
        }

        public ICardinal RotateRight()
        {
            return new SouthCardinal();
        }

        public Coordinates Proceed(Coordinates coordinates)
        {
            return new Coordinates(coordinates.X + 1, coordinates.Y);
        }

        public override string ToString()
        {
            return description;
        }
    }
}
