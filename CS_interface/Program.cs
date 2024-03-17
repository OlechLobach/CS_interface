using System;
using System.Collections;

public interface ISort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);
}

public interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

public interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

public class IntArray : ISort, ICalc, IOutput2
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

    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (var item in arr)
        {
            if (item < valueToCompare)
            {
                count++;
            }
        }
        return count;
    }

    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (var item in arr)
        {
            if (item > valueToCompare)
            {
                count++;
            }
        }
        return count;
    }

    public void ShowEven()
    {
        Console.WriteLine("Even numbers:");
        foreach (var item in arr)
        {
            if (item % 2 == 0)
            {
                Console.Write($"{item} ");
            }
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.WriteLine("Odd numbers:");
        foreach (var item in arr)
        {
            if (item % 2 != 0)
            {
                Console.Write($"{item} ");
            }
        }
        Console.WriteLine();
    }

    public ICollection? GetArray()
    {
        throw new NotImplementedException();
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

        int valueToCompare = 5;
        Console.WriteLine($"\nNumber of elements less than {valueToCompare}: {array.Less(valueToCompare)}");
        Console.WriteLine($"Number of elements greater than {valueToCompare}: {array.Greater(valueToCompare)}");

        array.ShowEven();
        array.ShowOdd();
    }
}