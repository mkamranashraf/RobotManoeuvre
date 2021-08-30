using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Command;
using Robot.Helpers;
using Robot.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RobotTest.CommandInvokerTests
{
    [TestClass]
    public class IndividualCommandsTests
    {
        [TestMethod]
        public void GivenGibberishCommandTestExecuteCommandExpectsCommandIgnored()
        {
            // setup data
            Position pos = null;
            const string command = "This is not a valid command";

            // invoke command
            var newPos = CommandInvoker.ExecuteCommand(command, pos);

            // verify result
            Assert.IsNull(newPos);
        }


        [TestMethod]
        public void GivenNoFirstPlaceCommandIssuedMoveCommandTestExecuteCommandExpectsCommandIgnored()
        {
            // setup data
            Position pos = null;
            const string command = "MOVE";

            // invoke command
            var newPos = CommandInvoker.ExecuteCommand(command, pos);

            // verify result
            Assert.IsNull(newPos);
        }

        [TestMethod]
        public void GivenNoFirstPlaceCommandIssuedLeftCommandTestExecuteCommandExpectsCommandIgnored()
        {
            // setup data
            Position pos = null;
            const string command = "LEFT";

            // invoke command
            var newPos = CommandInvoker.ExecuteCommand(command, pos);

            // verify result
            Assert.IsNull(newPos);
        }

        [TestMethod]
        public void GivenNoFirstPlaceCommandIssuedRightCommandTestExecuteCommandExpectsCommandIgnored()
        {
            // setup data
            Position pos = null;
            const string command = "RIGHT";

            // invoke command
            var newPos = CommandInvoker.ExecuteCommand(command, pos);

            // verify result
            Assert.IsNull(newPos);
        }

        [TestMethod]
        public void GivenNoFirstPlaceCommandIssuedPlaceWithTwoParameterCommandTestExecuteCommandExpectsCommandIgnored()
        {
            // setup data
            Position pos = null;
            const string command = "PLACE 1, 1";

            // invoke command
            var newPos = CommandInvoker.ExecuteCommand(command, pos);

            // verify result
            Assert.IsNull(newPos);
        }

        [TestMethod]
        public void GivenPlaceCommandThenMoveCommandTestExecuteCommandExpectsCommandExecuted()
        {
            // setup data
            Position pos = null;
            const string command1 = "PLACE 2,2,EAST";
            const string command2 = "MOVE";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(3, pos.PosX);
            Assert.AreEqual(2, pos.PosY);
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenPlaceCommandThenLeftCommandTestExecuteCommandExpectsCommandExecuted()
        {
            // setup data
            Position pos = null;
            const string command1 = "PLACE 2,2,EAST";
            const string command2 = "LEFT";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(2, pos.PosX);
            Assert.AreEqual(2, pos.PosY);
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenPlaceCommandThenRightCommandTestExecuteCommandExpectsCommandExecuted()
        {
            // setup data
            Position pos = null;
            const string command1 = "PLACE 2,2,EAST";
            const string command2 = "RIGHT";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(2, pos.PosX);
            Assert.AreEqual(2, pos.PosY);
            Assert.AreEqual(Directions.SOUTH, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenPlaceCommandThenPlaceCommandWithTwoParameterTestExecuteCommandExpectsCommandExecuted()
        {
            // setup data
            Position pos = null;
            const string command1 = "PLACE 2,2,EAST";
            const string command2 = "PLACE 1, 1";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(1, pos.PosX);
            Assert.AreEqual(1, pos.PosY);
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenPlaceCommandThenPrintCommandTestExecuteCommandExpectsCommandExecuted()
        {
            // setup mock
            var output = new StringWriter();
            Console.SetOut(output);

            // setup data
            Position pos = null;
            const string command1 = "PLACE 2, 2, EAST";
            const string command2 = "REPORT";
            const string expectedOutput = "Output: 2,2,EAST";

            // invoke command
            pos = CommandInvoker.ExecuteCommand(command1, pos);
            pos = CommandInvoker.ExecuteCommand(command2, pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(2, pos.PosX);
            Assert.AreEqual(2, pos.PosY);
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection);
            Assert.AreEqual(expectedOutput, output.ToString().Trim());
        }
    }
}
