using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Smith";
            int age = 46;
            char letter = 'R';
            bool isMarried = true;
            double kids = 5.0;
            decimal yearsWorked = 25;

            Console.WriteLine($"Hello World, {name}!/n" +
                $"I see from your profile that you are married with/n" +
                $"{kids} children.");
        }
    }
}
