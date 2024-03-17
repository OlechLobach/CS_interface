using System;
using System.Collections;

public interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

public class IntArray : ISort
{
    private int[] arr;

    public IntArray(int[] arr)
    {
        this.arr = arr;
    }

    public void SortAsc()
    {
        Array.Sort(arr);
    }

    public void SortDesc()
    {
        Array.Sort(arr);
        Array.Reverse(arr);
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }

    public void Print()
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    public ICollection? GetArray()
    {
        return arr;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 2, 7, 1, 9, 5 };
        IntArray array = new IntArray(numbers);

        Console.WriteLine("Original array:");
        array.Print();

        Console.WriteLine("\nSorting in ascending order:");
        array.SortAsc();
        array.Print();

        Console.WriteLine("\nSorting in descending order:");
        array.SortDesc();
        array.Print();

        Console.WriteLine("\nSorting based on parameter (true for ascending, false for descending):");
        array.SortByParam(true);
        array.Print();

        array.SortByParam(false);
        array.Print();
    }
}