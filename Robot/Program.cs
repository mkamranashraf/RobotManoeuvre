using Robot.Command;
using Robot.Models;
using System;

namespace Robot
{
    class Program
    {
        private static Position CurrentPosition { get; set; }

        static void Main(string[] args)
        {
            bool exitProg = false;
            Console.WriteLine("**********************************************************");
            Console.WriteLine("* Please type commands to place and move robot           *");
            Console.WriteLine("* Example:                                               *");
            Console.WriteLine("* PLACE 0,0,NORTH                                        *");
            Console.WriteLine("* MOVE                                                   *");
            Console.WriteLine("* REPORT                                                 *");
            Console.WriteLine("* EXIT                                                   *");
            Console.WriteLine("**********************************************************");

            do
            {
                string command = Console.ReadLine();
                if (command.ToUpper() == "EXIT")
                {
                    exitProg = true;
                }
                else
                {
                    CurrentPosition = CommandInvoker.ExecuteCommand(command, CurrentPosition);
                }

            } while (!exitProg);

        }
    }

}
