using Microsoft.VisualStudio.TestTools.UnitTesting;
using CS_interface;

namespace Test
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void TestMax()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            CS_interface.Array array = new CS_interface.Array(numbers);

            // Act
            int max = array.Max();

            // Assert
            Assert.AreEqual(5, max);
        }

        [TestMethod]
        public void TestMin()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            CS_interface.Array array = new CS_interface.Array(numbers);

            // Act
            int min = array.Min();

            // Assert
            Assert.AreEqual(1, min);
        }

        [TestMethod]
        public void TestAvg()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            CS_interface.Array array = new CS_interface.Array(numbers);

            // Act
            float avg = array.Avg();

            // Assert
            Assert.AreEqual(3, avg);
        }

        [TestMethod]
        public void TestSearch()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            CS_interface.Array array = new CS_interface.Array(numbers);

            // Act
            bool found1 = array.Search(3);
            bool found2 = array.Search(6);

            // Assert
            Assert.IsTrue(found1);
            Assert.IsFalse(found2);
        }
    }
}