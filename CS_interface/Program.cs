using System;

namespace CS_interface
{
    public interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }

    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IMath, IOutput
    {
        private int[] array;

        public Array(int[] array)
        {
            this.array = array;
        }

        public int Max()
        {
            int max = array[0];
            foreach (int element in array)
            {
                if (element > max)
                {
                    max = element;
                }
            }
            return max;
        }

        public int Min()
        {
            int min = array[0];
            foreach (int element in array)
            {
                if (element < min)
                {
                    min = element;
                }
            }
            return min;
        }

        public float Avg()
        {
            float sum = 0;
            foreach (int element in array)
            {
                sum += element;
            }
            return sum / array.Length;
        }

        public bool Search(int valueToSearch)
        {
            foreach (int element in array)
            {
                if (element == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        public void Show()
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }

    class Program
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Array array = new Array(numbers);

            Console.WriteLine("Max: " + array.Max());
            Console.WriteLine("Min: " + array.Min());
            Console.WriteLine("Avg: " + array.Avg());
            Console.WriteLine("Search for 3: " + array.Search(3));
            Console.WriteLine("Search for 6: " + array.Search(6));

            Console.WriteLine("Showing array:");
            array.Show();

            Console.WriteLine("Showing array with info:");
            array.Show("Array elements:");
        }
    }
}