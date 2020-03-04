using System;
using NUnit.Framework;
using MarsRovers.Library;

namespace MarsRovers.UnitTests
{
    [TestFixture]
    public class PlateauTests
    {
        [Test]
        public void AreCoordinatesInside_Plateau55AndCoordinates33_ReturnTrue()
        {
            // Arrange
            var upperRight = new Coordinates(5, 5);
            var plateau = new Plateau(upperRight);
            var coordinatesToCheck = new Coordinates(3, 3);

            // Act
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            // Assert
            Assert.That(result, Is.True);
        }


        [Test]
        public void AreCoordinatesInside_Plateau55AndCoordinates00_ReturnTrue()
        {
            // Arrange
            var upperRight = new Coordinates(5, 5);
            var plateau = new Plateau(upperRight);
            var coordinatesToCheck = new Coordinates(0, 0);

            // Act
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void AreCoordinatesInside_Plateau55AndCoordinates55_ReturnTrue()
        {
            // Arrange
            var upperRight = new Coordinates(5, 5);
            var plateau = new Plateau(upperRight);
            var coordinatesToCheck = new Coordinates(5, 5);

            // Act
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void AreCoordinatesInside_Plateau55AndCoordinates56_ReturnFalse()
        {
            // Arrange
            var upperRight = new Coordinates(5, 5);
            var plateau = new Plateau(upperRight);
            var coordinatesToCheck = new Coordinates(5, 6);

            // Act
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void AreCoordinatesInside_Plateau55AndCoordinates65_ReturnFalse()
        {
            // Arrange
            var upperRight = new Coordinates(5, 5);
            var plateau = new Plateau(upperRight);
            var coordinatesToCheck = new Coordinates(6, 5);

            // Act
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void AreCoordinatesInside_Plateau55AndCoordinatesMinus15_ReturnFalse()
        {
            // Arrange
            var upperRight = new Coordinates(5, 5);
            var plateau = new Plateau(upperRight);
            var coordinatesToCheck = new Coordinates(-1, 5);

            // Act
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void AreCoordinatesInside_Plateau55AndCoordinates5Minus1_ReturnFalse()
        {
            // Arrange
            var upperRight = new Coordinates(5, 5);
            var plateau = new Plateau(upperRight);
            var coordinatesToCheck = new Coordinates(5, -1);

            // Act
            var result = plateau.AreCoordinatesInside(coordinatesToCheck);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        [Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedException(typeof(Exception))]
        public void CreatePlateau_XX_WrongDimensionsExceptionReturnFalse()
        {
            // Act
            Plateau.CreatePlateau("X X");
        }

        [Test]
        public void CreatePlateau_55_CoordinatesEqual55ReturnTrue()
        {
            // Act
            var plateau = Plateau.CreatePlateau("5 5");
            var coordinates = new Coordinates(5, 5);

            // Assert
            Assert.That(plateau.UpperRight.Y == coordinates.Y && plateau.UpperRight.X == coordinates.X);
        }


    }
}
