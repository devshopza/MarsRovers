using System;

namespace MarsRovers.Library
{
    public class Rover
    {
        private Coordinates coordinates;
        private ICardinal cardinal;
        private Plateau plateau;
        private string movelog;

        public ICardinal Cardinal => cardinal;
        public Coordinates Coordinates => coordinates;

        public string MoveLog => movelog.Remove(movelog.Length - 1);

        public Rover()
        {
            cardinal = new NoCardinal();
        }

        public void Init(Coordinates coordinates, ICardinal cardinal)
        {
            this.coordinates = coordinates;
            this.cardinal = cardinal;
        }

        public void SetPlateau(Plateau plateau)
        {
            this.plateau = plateau;
        }

        public static Rover CreateRover(string definition)
        {
            if (string.IsNullOrEmpty(definition)) throw new Exception("Definition of rover is empty.");

            var coordinatesAndcardinal = definition.Split(' ');

            if (coordinatesAndcardinal.Length != 3) throw new Exception("Definition of rover not properly formatted.");

            Coordinates coordinates;
            ICardinal cardinal;

            try
            {
                coordinates = new Coordinates(Convert.ToInt32(coordinatesAndcardinal[0]), Convert.ToInt32(coordinatesAndcardinal[1]));

                cardinal = CardinalFactory.GetCardinal(coordinatesAndcardinal[2]);
            }
            catch (Exception ex)
            {
                throw new Exception("Bad definition.", ex);
            }

            var rover = new Rover();

            rover.Init(coordinates, cardinal);

            return rover;
        }

        public void RotateLeft()
        {
            cardinal = cardinal.RotateLeft();
        }

        public void RotateRight()
        {
            cardinal = cardinal.RotateRight();
        }

        public void Move()
        {
            var nextPosition = cardinal.Proceed(coordinates);

            if (plateau != null)
            {
                if(!plateau.AreCoordinatesInside(nextPosition)) throw new Exception("Rover can't move out of the plateau dimensions.");
            }

            coordinates = nextPosition;
            movelog += "[" + coordinates.ToString().Replace(" ",",") + "],";
        }

        public void ExecuteBatchCmds(string stringCommands)
        {
            foreach (var command in stringCommands)
            {
                switch (command)
                {
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                    case 'M':
                        Move();
                        break;
                    default:
                        throw new Exception(string.Format("The command '{0}' is unknown.", command));
                }
            }
        }

        public string GetPosition()
        {
            return string.Format("{0} {1}", coordinates, cardinal);
        }
    }
}