using Robot.Helpers;
using Robot.Models;
using System.Collections.Generic;

namespace Robot.Validators
{
    public static class CommandValidator
    {
        private static List<string> Commands = new List<string> {
            Constants.CMD_MOVE,
            Constants.CMD_REPORT,
            Constants.CMD_LEFT,
            Constants.CMD_RIGHT,
            Constants.CMD_PLACE
        };

        public static bool IsCommandValid(RobotCommand cmd)
        {
            if (cmd == null)
            {
                return false;
            }

            if (!Commands.Contains(cmd.Command))
            {
                return false;
            }

            return (AreParametersValid(cmd));
        }

        private static bool AreParametersValid(RobotCommand cmd)
        {
            if (cmd == null)
            {
                return false;
            }

            if (cmd.Command == Constants.CMD_PLACE)
            {
                if (cmd.Parameters == null || cmd.Parameters.Count < 2)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
