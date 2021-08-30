using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Command;
using Robot.Helpers;
using Robot.Models;
using System;
using System.IO;

namespace RobotTest.CommandInvokerTests
{
    [TestClass]
    public class GroupCommandsTests
    {
        [TestMethod]
        public void GivenGroupCommands01TestExecuteCommandExpectsCommandExecuted()
        {
            // setup mock
            var output = new StringWriter();
            Console.SetOut(output);

            // setup data
            Position pos = null;
            const string command1 = "PLACE 0,0,NORTH";
            const string command2 = "MOVE";
            const string command3 = "REPORT";
            const string expectedOutput = "Output: 0,1,NORTH";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);
            pos = CommandInvoker.ExecuteCommand(command3, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(0, pos.PosX);
            Assert.AreEqual(1, pos.PosY);
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection);
            Assert.AreEqual(expectedOutput, output.ToString().Trim());
        }

        [TestMethod]
        public void GivenGroupCommands02TestExecuteCommandExpectsCommandExecuted()
        {
            // setup mock
            var output = new StringWriter();
            Console.SetOut(output);

            // setup data
            Position pos = null;
            const string command1 = "PLACE 0,0,NORTH";
            const string command2 = "LEFT";
            const string command3 = "REPORT";
            const string expectedOutput = "Output: 0,0,WEST";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);
            pos = CommandInvoker.ExecuteCommand(command3, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(0, pos.PosX);
            Assert.AreEqual(0, pos.PosY);
            Assert.AreEqual(Directions.WEST, pos.CurrentDirection);
            Assert.AreEqual(expectedOutput, output.ToString().Trim());
        }

        [TestMethod]
        public void GivenGroupCommands03TestExecuteCommandExpectsCommandExecuted()
        {
            // setup mock
            var output = new StringWriter();
            Console.SetOut(output);

            // setup data
            Position pos = null;
            const string command1 = "PLACE 1,2,EAST";
            const string command2 = "MOVE";
            const string command3 = "MOVE";
            const string command4 = "LEFT";
            const string command5 = "MOVE";
            const string command6 = "REPORT";
            const string expectedOutput = "Output: 3,3,NORTH";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);
            pos = CommandInvoker.ExecuteCommand(command3, pos);
            pos = CommandInvoker.ExecuteCommand(command4, pos);
            pos = CommandInvoker.ExecuteCommand(command5, pos);
            pos = CommandInvoker.ExecuteCommand(command6, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(3, pos.PosX);
            Assert.AreEqual(3, pos.PosY);
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection);
            Assert.AreEqual(expectedOutput, output.ToString().Trim());
        }

        [TestMethod]
        public void GivenGroupCommands04TestExecuteCommandExpectsCommandExecuted()
        {
            // setup mock
            var output = new StringWriter();
            Console.SetOut(output);

            // setup data
            Position pos = null;
            const string command1 = "PLACE 1,2,EAST";
            const string command2 = "MOVE";
            const string command3 = "LEFT";
            const string command4 = "MOVE";
            const string command5 = "PLACE 3,1";
            const string command6 = "MOVE";
            const string command7 = "REPORT";
            const string expectedOutput = "Output: 3,2,NORTH";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);
            pos = CommandInvoker.ExecuteCommand(command3, pos);
            pos = CommandInvoker.ExecuteCommand(command4, pos);
            pos = CommandInvoker.ExecuteCommand(command5, pos);
            pos = CommandInvoker.ExecuteCommand(command6, pos);
            pos = CommandInvoker.ExecuteCommand(command7, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(3, pos.PosX);
            Assert.AreEqual(2, pos.PosY);
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection);
            Assert.AreEqual(expectedOutput, output.ToString().Trim());
        }
    }
}