using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CS_interface;

namespace Test
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void TestShow()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            CS_interface.Array array = new CS_interface.Array(numbers);

            // Act
            string expectedOutput = "1 2 3 4 5";
            string actualOutput;
            using (var consoleOutput = new ConsoleOutput())
            {
                array.Show();
                actualOutput = consoleOutput.GetOutput();
            }

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput.Trim());
        }

        [TestMethod]
        public void TestShowWithInfo()
        {
            // Arrange
            int[] numbers = { 1, 2, 3, 4, 5 };
            CS_interface.Array array = new CS_interface.Array(numbers);
            string info = "Array elements:";

            // Act
            string expectedOutput = "Array elements:\n1 2 3 4 5\n";
            string actualOutput;
            using (var consoleOutput = new ConsoleOutput())
            {
                array.Show(info);
                actualOutput = consoleOutput.GetOutput();
            }

            // Assert
            Assert.AreEqual(expectedOutput, actualOutput.TrimEnd());
        }
    }

    public class ConsoleOutput : IDisposable
    {
        private readonly System.IO.StringWriter stringWriter;
        private readonly System.IO.TextWriter originalOutput;

        public ConsoleOutput()
        {
            stringWriter = new System.IO.StringWriter();
            originalOutput = Console.Out;
            Console.SetOut(stringWriter);
        }

        public string GetOutput()
        {
            return stringWriter.ToString();
        }

        public void Dispose()
        {
            Console.SetOut(originalOutput);
            stringWriter.Dispose();
        }
    }
}