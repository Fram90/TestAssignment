using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAssignment;


namespace TestAssignmentTests
{
    [TestClass]
    public class TravelCardTest
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void Has_DepartueOrDestinationIsEmpty_InvalidDataException()
        {
            //arrange
            string departue = "";
            string destination = "Moscow";

            //act
            var card = new TravelCard(departue, destination);

            //assert
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException))]
        public void Has_DepartueOrDestinationIsNull_InvalidDataException()
        {
            //arrange
            string departue = "Moscow";
            string destination = null;

            //act
            var card = new TravelCard(departue, destination);

            //assert
        }

        [TestMethod]
        public void PrintResult_IsCorrect()
        {
            //arrange
            var card = new TravelCard("Test1", "Test2");

            //act
            var result = card.Print();

            //assert
            Assert.AreEqual("Test1 > Test2", result);
        }

    }
}
