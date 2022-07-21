using System;

namespace exercise7_arrays_for_and_foreach_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            GetOdd(array);
            GetEven(array);
        }

        public static void GetOdd(int[] Array)
        {
            Console.WriteLine("Odd numbers from the array:");

            foreach (int value in Array)
            {
                if (value % 2 != 0)
                {
                    Console.WriteLine(value);
                }
            }
        }

        public static void GetEven(int[] Array)
        {
            Console.WriteLine("Even numbers from the array:");

            foreach (int value in Array)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);
                }
            }
        }
    }
}


