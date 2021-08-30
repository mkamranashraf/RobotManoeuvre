using Robot.Models;
using Robot.Validators;

namespace Robot.Helpers
{
    public static class ManoeuverHelper
    {

        public static Position Place(int x, int y, Directions direction)
        {
            if (MoveValidator.IsPlaceValid(x, y))
            {
                return new Position(x, y, direction);
            }
            return null;
        }
        public static Position Move(Position currentPosition)
        {
            if (currentPosition != null)
            {
                switch (currentPosition.CurrentDirection)
                {
                    case Directions.EAST:
                        return MoveEast(currentPosition);
                    case Directions.WEST:
                        return MoveWest(currentPosition);
                    case Directions.NORTH:
                        return MoveNorth(currentPosition);
                    case Directions.SOUTH:
                        return MoveSouth(currentPosition);
                }
            }
            return currentPosition;
        }

        public static Position Left(Position currentPosition)
        {
            if (currentPosition != null)
            {
                switch (currentPosition.CurrentDirection)
                {
                    case Directions.EAST:
                        return new Position(currentPosition.PosX, currentPosition.PosY, Directions.NORTH);
                    case Directions.WEST:
                        return new Position(currentPosition.PosX, currentPosition.PosY, Directions.SOUTH);
                    case Directions.NORTH:
                        return new Position(currentPosition.PosX, currentPosition.PosY, Directions.WEST);
                    case Directions.SOUTH:
                        return new Position(currentPosition.PosX, currentPosition.PosY, Directions.EAST);
                }
            }
            return currentPosition;
        }

        public static Position Right(Position currentPosition)
        {
            if (currentPosition != null)
            {
                switch (currentPosition.CurrentDirection)
                {
                    case Directions.EAST:
                        return new Position(currentPosition.PosX, currentPosition.PosY, Directions.SOUTH);
                    case Directions.WEST:
                        return new Position(currentPosition.PosX, currentPosition.PosY, Directions.NORTH);
                    case Directions.NORTH:
                        return new Position(currentPosition.PosX, currentPosition.PosY, Directions.EAST);
                    case Directions.SOUTH:
                        return new Position(currentPosition.PosX, currentPosition.PosY, Directions.WEST);
                }
            }
            return currentPosition;
        }

        private static Position MoveEast(Position currentPosition)
        {
            if (MoveValidator.IsMoveEastValid(currentPosition))
            {
                return new Position(++currentPosition.PosX, currentPosition.PosY, currentPosition.CurrentDirection);
            }
            return currentPosition;
        }

        private static Position MoveWest(Position currentPosition)
        {
            if (MoveValidator.IsMoveWestValid(currentPosition))
            {
                return new Position(--currentPosition.PosX, currentPosition.PosY, currentPosition.CurrentDirection);
            }
            return currentPosition;
        }

        private static Position MoveNorth(Position currentPosition)
        {
            if (MoveValidator.IsMoveNorthValid(currentPosition))
            {
                return new Position(currentPosition.PosX, ++currentPosition.PosY, currentPosition.CurrentDirection);
            }

            return currentPosition;
        }

        private static Position MoveSouth(Position currentPosition)
        {
            if (MoveValidator.IsMoveSouthValid(currentPosition))
            {
                return new Position(currentPosition.PosX, --currentPosition.PosY, currentPosition.CurrentDirection);
            }
            return currentPosition;
        }
    }
}
