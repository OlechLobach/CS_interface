using System;

namespace SortingAndCalculating
{
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

    public class IntArray : ISort, ICalc
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

        public int[] GetArray()
        {
            return arr;
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
        }
    }
}