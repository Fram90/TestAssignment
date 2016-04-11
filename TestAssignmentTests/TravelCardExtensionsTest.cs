using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestAssignment;

namespace TestAssignmentTests
{
    [TestClass]
    public class TravelCardExtensionsTest
    {

        [TestMethod]
        public void PrintResult_IsCorrect()
        {
            //arrange
            var testCardSet = new List<TravelCard>()
            {
                new TravelCard("Test1", "Test2"),
                new TravelCard("Test2", "Test3"),
                new TravelCard("Test3", "Test4")
            };

            //act
            var result = testCardSet.Print();

            //assert
            Assert.AreEqual("Test1 > Test2, Test2 > Test3, Test3 > Test4", result);
        }

        [TestMethod]
        public void Sorting_ReversedCardSet_IsCorrect()
        {
            //arrange
            var testCardSet = new List<TravelCard>()
            {
                new TravelCard("Test7", "Test8"),
                new TravelCard("Test6", "Test7"),
                new TravelCard("Test5", "Test6"),
                new TravelCard("Test4", "Test5"),
                new TravelCard("Test3", "Test4"),
                new TravelCard("Test2", "Test3"),
                new TravelCard("Test1", "Test2")
            };

            //act
            var result = TravelCardExtensions.SortCards(testCardSet).Print();

            //assert
            Assert.AreEqual("Test1 > Test2, Test2 > Test3, Test3 > Test4, Test4 > Test5, Test5 > Test6, Test6 > Test7, Test7 > Test8", result);
        }

        [TestMethod]
        public void Sorting_ArrangedCardSet_IsCorrect()
        {
            //arrange
            var testCardSet = new List<TravelCard>()
            {
                new TravelCard("Test1", "Test2"),
                new TravelCard("Test2", "Test3"),
                new TravelCard("Test3", "Test4"),
                new TravelCard("Test4", "Test5"),
                new TravelCard("Test5", "Test6"),
                new TravelCard("Test6", "Test7"),
                new TravelCard("Test7", "Test8")
            };

            //act
            var result = TravelCardExtensions.SortCards(testCardSet).Print();

            //assert
            Assert.AreEqual("Test1 > Test2, Test2 > Test3, Test3 > Test4, Test4 > Test5, Test5 > Test6, Test6 > Test7, Test7 > Test8", result);
        }

        [TestMethod]
        public void Sorting_MixedCardSet_IsCorrect()
        {
            //arrange
            var testCardSet = new List<TravelCard>()
            {
                new TravelCard("Test2", "Test3"),
                new TravelCard("Test6", "Test7"),
                new TravelCard("Test1", "Test2"),
                new TravelCard("Test4", "Test5"),
                new TravelCard("Test5", "Test6"),
                new TravelCard("Test7", "Test8"),
                new TravelCard("Test3", "Test4"),
            };

            //act
            var result = TravelCardExtensions.SortCards(testCardSet).Print();

            //assert
            Assert.AreEqual("Test1 > Test2, Test2 > Test3, Test3 > Test4, Test4 > Test5, Test5 > Test6, Test6 > Test7, Test7 > Test8", result);
        }
    }
}
