using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Helpers;
using Robot.Models;

namespace RobotTest.ManoeuverHelperTests
{
    [TestClass]
    public class RightTests
    {
        [TestMethod]
        public void GivenOnTableSouthFacingTestLeftExpectTurnRight()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.SOUTH);

            // invoke function
            pos = ManoeuverHelper.Right(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.WEST, pos.CurrentDirection); // direction changed to right
        }

        [TestMethod]
        public void GivenOnTableEastFacingTestLeftExpectTurnRight()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.EAST);

            // invoke function
            pos = ManoeuverHelper.Right(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.SOUTH, pos.CurrentDirection); // direction changed to right
        }

        [TestMethod]
        public void GivenOnTableWestFacingTestLeftExpectTurnRight()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.WEST);

            // invoke function
            pos = ManoeuverHelper.Right(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection); // direction changed to right
        }

        [TestMethod]
        public void GivenOnTableNorthFacingTestLeftExpectTurnRight()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.NORTH);

            // invoke function
            pos = ManoeuverHelper.Right(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection); // direction changed to right
        }
    }
}
