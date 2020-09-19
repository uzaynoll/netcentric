using System;

namespace meanMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {3,7,9,11,67,89,12 };
            sort(numbers);
        }
        private static void sort(int[] numbers)
        {
            Array.Sort(numbers);
            shor(numbers);
        }
        private static void shor(int [] numbers)
        {
            double s = 0;
            foreach (double element in numbers)
            {
                s += element;
            }
            mean(s,numbers);
            median(s,numbers);
        }
        private static void mean(double s,int[]numbers)
        {
            double mean = s / numbers.Length;
            Console.WriteLine($"Mean of given list = {mean}");
        }
        private static void median(double s,int[]numbers)
        {
            double median = 0;
            if ((numbers.Length % 2) == 0)
            {
                median = (numbers[(numbers.Length / 2) - 1] + numbers[(numbers.Length / 2)]) / 2.0;
            }
            else
            {
                median = (numbers[(numbers.Length / 2)]);
                Console.WriteLine($"Median of given list = {median}");
            }
        }
    }
    
}
