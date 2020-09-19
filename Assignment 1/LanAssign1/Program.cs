using System;

namespace LanAssign1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Principal");
            decimal pr = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate");
            decimal ra = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Time");
            decimal ti = decimal.Parse(Console.ReadLine());
            decimal si = (pr * ra * ti) / 100;
            Console.WriteLine($"Correct number is:{si}");
        }
    }
}
