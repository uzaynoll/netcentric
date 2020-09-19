using System;

namespace gravitionalForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the mass of first object: ");
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the mass of second object: ");
            int m2 = int.Parse(Console.ReadLine());
            Console.Write("Distance between the two objects: ");
            int distance = int.Parse(Console.ReadLine());
            const double G = 6.67e-11;

            double gf = G * m1 * m2 / Math.Pow(distance, 2.0);
            Console.WriteLine($"Gravitational Force = {gf}");
        }
    }
}
