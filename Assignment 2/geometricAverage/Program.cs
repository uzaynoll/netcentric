using System;

namespace geometricAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total numbers in the list: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers in the list: ");
            int[] number = new int[100];
            double m = 1;
            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
                m*= number[i];
            }
            double geometricMean = Math.Pow(m, 1.0 / n);
            Console.Write($"Geometric mean = {geometricMean}");
        }
    }
}
