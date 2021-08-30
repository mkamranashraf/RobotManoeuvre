using Robot.Helpers;
using Robot.Models;

namespace Robot.Validators
{
    public static class MoveValidator
    {
        public static bool IsPlaceValid(int placeX, int placeY)
        {
            return placeX > -1 && placeX < Constants.MaxTableLength
                      && placeY > -1 && placeY < Constants.MaxTableWidth;
        }

        public static bool IsMoveEastValid(Position currentPosition)
        {
            return (currentPosition != null && currentPosition.PosX < Constants.MaxTableWidth - 1);
        }

        public static bool IsMoveWestValid(Position currentPosition)
        {
            return (currentPosition != null && currentPosition.PosX > 0);
        }

        public static bool IsMoveNorthValid(Position currentPosition)
        {
            return (currentPosition != null && currentPosition.PosY < Constants.MaxTableLength - 1);
        }

        public static bool IsMoveSouthValid(Position currentPosition)
        {
            return (currentPosition != null && currentPosition.PosY > 0);
        }
    }
}
