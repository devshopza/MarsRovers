using System;
namespace MarsRovers.Library
{
    public class Coordinates 
    {
        private readonly int x;
        private readonly int y;

        public int X => x;
        public int Y => y;

        public Coordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", x, y);
        }
    }
}