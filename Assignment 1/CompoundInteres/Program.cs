using System;

namespace CompoundInteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Principal: ");
            int principal = int.Parse(Console.ReadLine());
            Console.Write("Rate: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Number of times interest is compounded per year: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Time in years: ");
            int time = int.Parse(Console.ReadLine());

            double temp = 1 + (rate / n);
            double final = (principal * (Math.Pow(temp, (n * time))));
            Console.WriteLine($"Compound Interest with Principal = {final}");
            double compoundInterest = final - principal;
            Console.WriteLine($"Compound Interest is = {compoundInterest}");
        }
    }
}
