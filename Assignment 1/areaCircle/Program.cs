using System;

namespace areaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Radius of Circle: ");
            int radius = int.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area of the circle = {area}");
        }
    }
}
