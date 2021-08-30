using Robot.Models;
using System;
using System.Collections.Generic;

namespace Robot.Helpers
{
    public static class CommandHelper
    {
        public static int ConvertToInt(string value)
        {
            int newValue;

            if (!string.IsNullOrWhiteSpace(value) && int.TryParse(value.Trim(), out newValue))
            {
                return newValue;
            }
            return -1;
        } 

        public static Tenum? ConvertToEnum<Tenum>(string value) where Tenum : struct
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            try
            {
                Tenum res = (Tenum)Enum.Parse(typeof(Tenum), value.Trim());
                if (!Enum.IsDefined(typeof(Tenum), res))
                {
                    return null;
                }
                    
                return res;
            }
            catch
            {
                return null;
            }
        }
        public static RobotCommand ParseCommand(string command)
        {
            if (!string.IsNullOrWhiteSpace(command))
            {
                var cmd = new RobotCommand();
                var commandParts = command.ToUpper().Split(' ', 2, StringSplitOptions.RemoveEmptyEntries);
                cmd.Command = commandParts[0];
                if (commandParts.Length == 1)
                {
                    return cmd;
                }

                var commandParameters = commandParts[1].Split(',', StringSplitOptions.RemoveEmptyEntries);
                cmd.Parameters = new List<string> ( commandParameters );
                return cmd;
            }

            return null;
        }
    }
}
