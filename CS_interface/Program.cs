using System;

namespace CS_interface
{

    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput
    {
        private int[] array;

        public Array(int[] array)
        {
            this.array = array;
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

            Console.WriteLine("Showing array:");
            array.Show();

            Console.WriteLine("Showing array with info:");
            array.Show("Array elements:");
        }
    }
}