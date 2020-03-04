using System;
using NUnit.Framework;
using MarsRovers.Library;

namespace MarsRovers.UnitTests
{
    [TestFixture]
    public class RoverTests
    {
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(Exception))]
        public void CreateRover_EmptyDefinition_WrongRoverDefinitionException()
        {
            // Act
            Rover.CreateRover("");
        }

        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(Exception))]
        public void CreateRover_NoIntXY_WrongRoverDefinitionException()
        {
            // Act
            Rover.CreateRover("N N N");
        }

        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(Exception))]
        public void CreateRover_WrongCardinal_WrongRoverDefinitionException()
        {
            // Act
            Rover.CreateRover("5 5 H");
        }
       
        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(Exception))]
        public void ExecuteBatchCmds_UnknownCmd_UnknownCmdException()
        {
            // Arrange
            var rover = Rover.CreateRover("5 5 N");

            // Act
            rover.ExecuteBatchCmds("S");
        }

        [Test]
        public void RotateLeft_StartCardinalIsNorth_EndCardinalShouldBeWest()
        {
            // Arrange
            var rover = new Rover();
            var StartCoordinates = new Coordinates(0, 0);
            rover.Init(StartCoordinates, new NorthCardinal());

            // Act
            rover.RotateLeft();

            //Assert
            Assert.That(rover.Cardinal.ToString(), Is.EqualTo(new WestCardinal().ToString()));
        }

        [Test]
        public void RotateLeft_StartCardinalIsWest_EndCardinalShouldBeSouth()
        {
            // Arrange
            var rover = new Rover();
            var StartCoordinates = new Coordinates(0, 0);
            rover.Init(StartCoordinates, new WestCardinal());

            // Act
            rover.RotateLeft();

            //Assert
            Assert.That(rover.Cardinal.ToString(), Is.EqualTo(new SouthCardinal().ToString()));
        }

        [Test]
        public void RotateLeft_StartCardinalIsSouth_EndCardinalShouldBeEast()
        {
            // Arrange
            var rover = new Rover();
            var StartCoordinates = new Coordinates(0, 0);
            rover.Init(StartCoordinates, new SouthCardinal());

            // Act
            rover.RotateLeft();

            //Assert
            Assert.That(rover.Cardinal.ToString(), Is.EqualTo(new EastCardinal().ToString()));
        }

        [Test]
        public void RotateLeft_StartCardinalIsEast_EndCardinalShouldBeNorth()
        {
            // Arrange
            var rover = new Rover();
            var StartCoordinates = new Coordinates(0, 0);
            rover.Init(StartCoordinates, new EastCardinal());

            // Act
            rover.RotateLeft();

            //Assert
            Assert.That(rover.Cardinal.ToString(), Is.EqualTo(new NorthCardinal().ToString()));
        }

        [Test]
        public void RotateRight_StartCardinalIsNorth_EndCardinalShouldBeEast()
        {
            // Arrange
            var rover = new Rover();
            var StartCoordinates = new Coordinates(0, 0);
            rover.Init(StartCoordinates, new NorthCardinal());

            // Act
            rover.RotateRight();

            //Assert
            Assert.That(rover.Cardinal.ToString(), Is.EqualTo(new EastCardinal().ToString()));
        }

        [Test]
        public void RotateRight_StartCardinalIsWest_EndCardinalShouldBeNorth()
        {
            // Arrange
            var rover = new Rover();
            var StartCoordinates = new Coordinates(0, 0);
            rover.Init(StartCoordinates, new WestCardinal());

            // Act
            rover.RotateRight();

            //Assert
            Assert.That(rover.Cardinal.ToString(), Is.EqualTo(new NorthCardinal().ToString()));
        }

        [Test]
        public void RotateRight_StartCardinalIsSouth_EndCardinalShouldBeWest()
        {
            // Arrange
            var rover = new Rover();
            var StartCoordinates = new Coordinates(0, 0);
            rover.Init(StartCoordinates, new SouthCardinal());

            // Act
            rover.RotateRight();

            //Assert
            Assert.That(rover.Cardinal.ToString(), Is.EqualTo(new WestCardinal().ToString()));
        }

        [Test]
        public void RotateRight_StartCardinalIsEast_EndCardinalShouldBeSouth()
        {
            // Arrange
            var rover = new Rover();
            var StartCoordinates = new Coordinates(0, 0);
            rover.Init(StartCoordinates, new EastCardinal());

            // Act
            rover.RotateRight();

            //Assert
            Assert.That(rover.Cardinal.ToString(), Is.EqualTo(new SouthCardinal().ToString()));
        }
    }
}
