using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Helpers
{
    public enum Directions
    {
        NORTH,
        EAST,
        SOUTH,
        WEST
    }

    public class Constants {
        public const int MaxTableLength = 6;
        public const int MaxTableWidth = 6;
        public const string CMD_MOVE = "MOVE";
        public const string CMD_REPORT = "REPORT";
        public const string CMD_LEFT = "LEFT";
        public const string CMD_RIGHT = "RIGHT";
        public const string CMD_PLACE = "PLACE";
    }
}
