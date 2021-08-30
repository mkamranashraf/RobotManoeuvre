using Microsoft.VisualStudio.TestTools.UnitTesting;
using Robot.Helpers;
using Robot.Models;

namespace RobotTest.ManoeuverHelperTests
{
    [TestClass]
    public class PlaceTests
    {

        [TestMethod]
        public void GivenOutofTableParamertsTestPlaceExpectCommandDiscarded()
        {
            // setup data

            // invoke function
            Position pos = ManoeuverHelper.Place(1, 9, Directions.EAST);

            // verify result
            Assert.IsNull(pos); // null position means command discarded
        }

        [TestMethod]
        public void GivenOutofTableNegativeParamertsTestPlaceExpectCommandDiscarded()
        {
            // setup data

            // invoke function
            Position pos = ManoeuverHelper.Place(-1, -5, Directions.EAST);

            // verify result
            Assert.IsNull(pos); // null position means command discarded
        }


        [TestMethod]
        public void GivenOnTheTableNorthPositionTestPlaceExpectCommandExecuted()
        {
            // setup data

            // invoke function
            Position pos = ManoeuverHelper.Place(1, 4, Directions.NORTH);

            // verify result
            Assert.IsNotNull(pos); // not null position means command executed
            Assert.AreEqual(1, pos.PosX);
            Assert.AreEqual(4, pos.PosY);
            Assert.AreEqual(Directions.NORTH, pos.CurrentDirection);
        }


        [TestMethod]
        public void GivenOnTheTableSouthPositionTestPlaceExpectCommandExecuted()
        {
            // setup data

            // invoke function
            Position pos = ManoeuverHelper.Place(5, 4, Directions.SOUTH);

            // verify result
            Assert.IsNotNull(pos); // not null position means command executed
            Assert.AreEqual(5, pos.PosX);
            Assert.AreEqual(4, pos.PosY);
            Assert.AreEqual(Directions.SOUTH, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenOnTheTableEastPositionTestPlaceExpectCommandExecuted()
        {
            // setup data

            // invoke function
            Position pos = ManoeuverHelper.Place(5, 5, Directions.EAST);

            // verify result
            Assert.IsNotNull(pos); // not null position means command executed
            Assert.AreEqual(5, pos.PosX);
            Assert.AreEqual(5, pos.PosY);
            Assert.AreEqual(Directions.EAST, pos.CurrentDirection);
        }

        [TestMethod]
        public void GivenOnTheTableWestPositionTestPlaceExpectCommandExecuted()
        {
            // setup data

            // invoke function
            Position pos = ManoeuverHelper.Place(2, 5, Directions.WEST);

            // verify result
            Assert.IsNotNull(pos); // not null position means command executed
            Assert.AreEqual(2, pos.PosX);
            Assert.AreEqual(5, pos.PosY);
            Assert.AreEqual(Directions.WEST, pos.CurrentDirection);
        }

    }
}
