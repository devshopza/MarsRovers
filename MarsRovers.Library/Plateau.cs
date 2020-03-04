using System;

namespace MarsRovers.Library
{
    public class Plateau
    {
        private readonly Coordinates upperRight;

        public Coordinates UpperRight => upperRight;

        public Plateau(Coordinates upperRight)
        {
            this.upperRight = upperRight;
        }

        public bool AreCoordinatesInside(Coordinates coordinatesToCheck)
        {
            if (coordinatesToCheck.Y > upperRight.Y) return false;
            if (coordinatesToCheck.X > upperRight.X) return false;
            if (coordinatesToCheck.X < 0) return false;
            if (coordinatesToCheck.Y < 0) return false;
            
            return true;
        }

        public static Plateau CreatePlateau(string dimensions)
        {
            if (string.IsNullOrEmpty(dimensions)) throw new Exception("Dimensions of plateau is empty.");

            var stringDimensions = dimensions.Split(' ');

            if (stringDimensions.Length != 2) throw new Exception("Dimensions of plateau not properly formatted.");

            Coordinates coordinates;

            try
            {
                coordinates = new Coordinates(Convert.ToInt32(stringDimensions[0]), Convert.ToInt32(stringDimensions[1]));
            }
            catch(Exception ex)
            {
                throw new Exception("Bad dimensions.", ex);
            }

            return new Plateau(coordinates);
        }
    }
}
