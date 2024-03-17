using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class IntArrayTests
{
    [TestMethod]
    public void SortAsc_SortsArrayInAscendingOrder()
    {
        // Arrange
        int[] numbers = { 4, 2, 7, 1, 9, 5 };
        IntArray array = new IntArray(numbers);

        // Act
        array.SortAsc();

        // Assert
        CollectionAssert.AreEqual(new int[] { 1, 2, 4, 5, 7, 9 }, array.GetArray());
    }

    [TestMethod]
    public void SortDesc_SortsArrayInDescendingOrder()
    {
        // Arrange
        int[] numbers = { 4, 2, 7, 1, 9, 5 };
        IntArray array = new IntArray(numbers);

        // Act
        array.SortDesc();

        // Assert
        CollectionAssert.AreEqual(new int[] { 9, 7, 5, 4, 2, 1 }, array.GetArray());
    }

    [DataTestMethod]
    [DataRow(true)]
    [DataRow(false)]
    public void SortByParam_SortsArrayBasedOnParameter(bool isAsc)
    {
        // Arrange
        int[] numbers = { 4, 2, 7, 1, 9, 5 };
        IntArray array = new IntArray(numbers);

        // Act
        array.SortByParam(isAsc);

        // Assert
        int[] expected = isAsc ? new int[] { 1, 2, 4, 5, 7, 9 } : new int[] { 9, 7, 5, 4, 2, 1 };
        CollectionAssert.AreEqual(expected, array.GetArray());
    }
}