using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Helpers;
using Robot.Models;

namespace RobotTest.ManoeuverHelperTests
{
    [TestClass]
    public class MoveTests
    {
        [TestMethod]
        public void GivenFarFromTableEdgeNorthFacingTestMoveExpectMoved() 
        {
            // setup data
            Position pos = ManoeuverHelper.Place(2, 3, Directions.NORTH);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos); // not null position means command executed
            Assert.AreEqual(2, pos.PosX);
            Assert.AreEqual(4, pos.PosY);
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenFarFromTableEdgeWestFacingTestMoveExpectMoved()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(2, 3, Directions.WEST);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos); // not null position means command executed
            Assert.AreEqual(1, pos.PosX);
            Assert.AreEqual(3, pos.PosY);
            Assert.AreEqual(Directions.WEST, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenFarFromTableEdgeEastFacingTestMoveExpectMoved()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(2, 3, Directions.EAST);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos); // not null position means command executed
            Assert.AreEqual(3, pos.PosX);
            Assert.AreEqual(3, pos.PosY);
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenFarFromTableEdgeSouthFacingTestMoveExpectMoved()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(2, 3, Directions.SOUTH);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos); // not null position means command executed
            Assert.AreEqual(2, pos.PosX);
            Assert.AreEqual(2, pos.PosY);
            Assert.AreEqual(Directions.SOUTH, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenOnTableSouthWestEdgeSouthFacingTestMoveExpectNoMove()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(0, 0, Directions.SOUTH);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(0, pos.PosX); // No movement on X
            Assert.AreEqual(0, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.SOUTH, pos.CurrentDirection); // no direction change
        }

        [TestMethod]
        public void GivenOnTableSouthWestEdgeWestFacingTestMoveExpectNoMove()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(0, 0, Directions.WEST);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(0, pos.PosX); // No movement on X
            Assert.AreEqual(0, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.WEST, pos.CurrentDirection); // no direction change
        }

        [TestMethod]
        public void GivenOnTableNorthEastEdgeNorthFacingTestMoveExpectNoMove()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.NORTH);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection); // no direction change
        }

        [TestMethod]
        public void GivenOnTableNorthEastEdgeEastFacingTestMoveExpectNoMove()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.EAST);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection); // no direction change
        }



        [TestMethod]
        public void GivenOnTableSouthWestEdgeEastFacingTestMoveExpectMove()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(0, 0, Directions.EAST);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(1, pos.PosX); // movement on X
            Assert.AreEqual(0, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection); // no direction change
        }

        [TestMethod]
        public void GivenOnTableSouthWestEdgeNorthFacingTestMoveExpectMove()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(0, 0, Directions.NORTH);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(0, pos.PosX); // No movement on X
            Assert.AreEqual(1, pos.PosY); // movement on Y
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection); // no direction change
        }

        [TestMethod]
        public void GivenOnTableNorthEastEdgeSouthFacingTestMoveExpectMove()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.SOUTH);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(4, pos.PosY); // movement on Y
            Assert.AreEqual(Directions.SOUTH, pos.CurrentDirection); // no direction change
        }

        [TestMethod]
        public void GivenOnTableNorthEastEdgeWestFacingTestMoveExpectMove()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.WEST);

            // invoke function
            pos = ManoeuverHelper.Move(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(4, pos.PosX); // movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.WEST, pos.CurrentDirection); // no direction change
        }
    }
}
