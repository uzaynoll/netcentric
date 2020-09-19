using System;

namespace meanMedian
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {3,7,9,11,67,89,12 };
            Array.Sort(numbers);
            double s = 0;
            foreach (double element in numbers)
            {
                s += element;
            }
            double mean = s / numbers.Length;
            double median = 0;
            if ((numbers.Length % 2) == 0)
            {
                median = (numbers[(numbers.Length / 2) - 1] + numbers[(numbers.Length / 2)]) / 2.0;
            }
            else
            {
                median = (numbers[(numbers.Length / 2)]);
            }
            Console.WriteLine($"Mean of given list = {mean}");
            Console.WriteLine($"Median of given list = {median}");
        }
    }
}
