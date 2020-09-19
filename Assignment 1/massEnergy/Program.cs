using System;

namespace massEnergy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the mass of the body? ");
            int mass = int.Parse(Console.ReadLine());
            const double c = 3e8;

            double e = mass * Math.Pow(c, 2.0);
            Console.WriteLine($"Mass Energy Equivalence = {e}");
        }
    }
}
