using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John Smith";
            int age = 46;
            //int kidsPerYearsWorked;
            char letter = 'R';
            bool isMarried = true;
            double kids = 5.0;
            decimal yearsWorked = 25;
            //kidsPerYearsWorked = age * age;
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"I see from your profile that you have {kids} children;");
            Console.WriteLine($"are married, and have been employed for {yearsWorked} years.");
            Console.WriteLine($"It also says you are {age} years onld and your favorite letter is {letter}.");
            //Console.WriteLine(kidsPerYearsWorked);
        }
    }
}
