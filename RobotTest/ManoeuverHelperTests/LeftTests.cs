using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Helpers;
using Robot.Models;

namespace RobotTest.ManoeuverHelperTests
{
    [TestClass]
    public class LeftTests
    {
        [TestMethod]
        public void GivenOnTableSouthFacingTestLeftExpectTurnLeft()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.SOUTH);

            // invoke function
            pos = ManoeuverHelper.Left(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection); // direction changed to left
        }

        [TestMethod]
        public void GivenOnTableEastFacingTestLeftExpectTurnLeft()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.EAST);

            // invoke function
            pos = ManoeuverHelper.Left(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection); // direction changed to left
        }

        [TestMethod]
        public void GivenOnTableWestFacingTestLeftExpectTurnLeft()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.WEST);

            // invoke function
            pos = ManoeuverHelper.Left(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.SOUTH, pos.CurrentDirection); // direction changed to left
        }

        [TestMethod]
        public void GivenOnTableNorthFacingTestLeftExpectTurnLeft()
        {
            // setup data
            Position pos = ManoeuverHelper.Place(5, 5, Directions.NORTH);

            // invoke function
            pos = ManoeuverHelper.Left(pos);

            // verify result
            Assert.IsNotNull(pos);
            Assert.AreEqual(5, pos.PosX); // No movement on X
            Assert.AreEqual(5, pos.PosY); // No movement on Y
            Assert.AreEqual(Directions.WEST, pos.CurrentDirection); // direction changed to left
        }
    }
}
