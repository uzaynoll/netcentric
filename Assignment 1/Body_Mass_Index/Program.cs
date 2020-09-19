using System;

namespace Body_Mass_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the weight (in kgs): ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Enter the height (in metres): ");
            float height = float.Parse(Console.ReadLine());

            double Body_Mass_Index = weight / Math.Pow(height, 2.0);
            Console.WriteLine($"Body Mass Index = {Body_Mass_Index}");
        }
    }
}
