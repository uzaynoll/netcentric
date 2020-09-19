using System;

namespace multiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which number do you want multiplication table of ? ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Upto ? ");
            int upto = int.Parse(Console.ReadLine());

            for (int i = 1; i <=upto; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}
