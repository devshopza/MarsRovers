namespace MarsRovers.Library
{
    public interface ICardinal
    {
        ICardinal RotateLeft();
        ICardinal RotateRight();
        Coordinates Proceed(Coordinates coordinates);
    }

}
