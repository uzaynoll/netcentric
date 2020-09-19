using System;

namespace volumeSphere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3.0);
            Console.WriteLine($"Volume of the sphere = {volume}");
        }
    }
}
