using System.Collections.Generic;

namespace Robot.Models
{
    public class RobotCommand
    {
        public string Command { get; set; }
        public List<string> Parameters { get; set; }
    }
}
