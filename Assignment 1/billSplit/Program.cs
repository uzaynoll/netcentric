using System;

namespace billSplit
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("What is the total cost? ");
            float cost = float.Parse(Console.ReadLine());
            Console.Write("Number of person: ");
            int numberPerson = int.Parse(Console.ReadLine());

            double costPerPerson = cost / numberPerson;
            Console.WriteLine($"Cost per person is = {costPerPerson}");
        }
    }
}
