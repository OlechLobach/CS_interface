using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using SortingAndCalculating;

namespace SortingAndCalculating.Tests
{
    [TestClass]
    public class IntArrayTests
    {
        [TestMethod]
        public void SortAsc_SortsArrayInAscendingOrder()
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);

            // Act
            array.SortAsc();

            // Assert
            CollectionAssert.AreEqual(new int[] { 1, 1, 2, 2, 4, 4, 5, 5, 7, 7, 9, 9 }, array.GetArray());
        }

        [TestMethod]
        public void SortDesc_SortsArrayInDescendingOrder()
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);

            // Act
            array.SortDesc();

            // Assert
            CollectionAssert.AreEqual(new int[] { 9, 9, 7, 7, 5, 5, 4, 4, 2, 2, 1, 1 }, array.GetArray());
        }

        [DataTestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void SortByParam_SortsArrayBasedOnParameter(bool isAsc)
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);

            // Act
            array.SortByParam(isAsc);

            // Assert
            int[] expected = isAsc ? new int[] { 1, 1, 2, 2, 4, 4, 5, 5, 7, 7, 9, 9 } :
                                     new int[] { 9, 9, 7, 7, 5, 5, 4, 4, 2, 2, 1, 1 };
            CollectionAssert.AreEqual(expected, array.GetArray());
        }

        [TestMethod]
        public void Less_ReturnsCorrectCountOfElementsLessThanValue()
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);
            int valueToCompare = 5;

            // Act
            int result = array.Less(valueToCompare);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Greater_ReturnsCorrectCountOfElementsGreaterThanValue()
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);
            int valueToCompare = 5;

            // Act
            int result = array.Greater(valueToCompare);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void CountDistinct_ReturnsCorrectCountOfDistinctElements()
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);

            // Act
            int result = array.CountDistinct();

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void EqualToValue_ReturnsCorrectCountOfElementsEqualToValue()
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);
            int valueToCompare = 5;

            // Act
            int result = array.EqualToValue(valueToCompare);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ShowEven_DisplaysEvenNumbers()
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            array.ShowEven();
            string expected = "Even numbers:\r\n4 2 4 2 \r\n";

            // Assert
            Assert.AreEqual(expected, consoleOutput.ToString());
        }

        [TestMethod]
        public void ShowOdd_DisplaysOddNumbers()
        {
            // Arrange
            int[] numbers = { 4, 2, 7, 1, 9, 5, 4, 2, 7, 1, 9, 5 };
            IntArray array = new IntArray(numbers);
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            array.ShowOdd();
            string expected = "Odd numbers:\r\n7 1 9 5 7 1 9 5 \r\n";

            // Assert
            Assert.AreEqual(expected, consoleOutput.ToString());
        }
    }
}