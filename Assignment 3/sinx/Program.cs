using System;

namespace SinValue
{
    class Program
    {
        static void Main()
        {
            double degreeValue = input("Enter degree: ");
            double radianValue = convert(degreeValue);
            Console.WriteLine($"sin({ degreeValue }) = { ValueOfSin(radianValue, 1, 1) }");
        }

        private static double ValueOfSin(double radianValue, int counter, int weightValue)
        {
            double nextTerm, sumOfSeries = 0;
            do
            {
                nextTerm = Math.Pow(radianValue, weightValue) / FactorialOf(weightValue);
                sumOfSeries += Math.Pow(-1, ++counter) * nextTerm;
                weightValue += 2;
            } while (nextTerm > 1E-5);
            return sumOfSeries;
        }

        private static double input(string displayText)
        {
            Console.Write(displayText);
            return double.Parse(Console.ReadLine());
        }

        private static double convert(double degreeValue)
        {
            return degreeValue * (Math.PI / 180);
        }

        private static double FactorialOf(int digit)
        {
            if (digit == 1)
                return 1;
            else
                return digit * FactorialOf(digit - 1);
        }
    }
}