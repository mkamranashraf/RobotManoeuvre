using Robot.Helpers;
using Robot.Models;
using Robot.Validators;
using System;

namespace Robot.Command
{
    public static class CommandInvoker
    {
        public static Position ExecuteCommand(string command, Position currentPosition)
        {
            RobotCommand cmd = CommandHelper.ParseCommand(command);
            Position newPosition = null;

            if (CommandValidator.IsCommandValid(cmd))
            {
                switch (cmd.Command)
                {
                    case Constants.CMD_PLACE:
                        newPosition = InvokePlaceCommand(cmd, currentPosition);
                        break;
                    case Constants.CMD_MOVE:
                        newPosition = ManoeuverHelper.Move(currentPosition);
                        break;
                    case Constants.CMD_LEFT:
                        newPosition = ManoeuverHelper.Left(currentPosition);
                        break;
                    case Constants.CMD_RIGHT:
                        newPosition = ManoeuverHelper.Right(currentPosition);
                        break;
                    case Constants.CMD_REPORT:
                        Console.WriteLine(currentPosition != null ? currentPosition.ToString() : "");
                        break;
                }
            }

            return newPosition ?? currentPosition;
        }

        private static Position InvokePlaceCommand(RobotCommand cmd, Position position)
        {
            if (cmd == null || cmd.Command != Constants.CMD_PLACE || cmd.Parameters.Count < 2)
            {
                return null;
            }

            int posX = CommandHelper.ConvertToInt(cmd.Parameters[0]);
            int posY = CommandHelper.ConvertToInt(cmd.Parameters[1]);

            if (cmd.Parameters.Count == 3)
            {
                Directions? direction = CommandHelper.ConvertToEnum<Directions>(cmd.Parameters[2]);
                if (posX > -1 && posY > -1 && direction.HasValue)
                {
                    return  ManoeuverHelper.Place(posX, posY, direction.Value);
                }
            }

            if (posX > -1 && posY > -1 && position != null)
            {
                return ManoeuverHelper.Place(posX, posY, position.CurrentDirection);
            }

            return null;
        }


    }
}
