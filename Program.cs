using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 45;
            bool married = true;
            decimal kids = 2.0m;
            string name = "John Smith III";
            double yearsWorked = 25.5;
            char favLetter = 'R';

            Console.WriteLine($"Hello, {name}, I see from the /n" +
                $"the information you submitted that you are /n" +
                $"{age} years old; have been working for {yearsWorked} years;\n" +
                $"and that you have {kids} children.  Your random fact\n" +
                $"is that your favorite Letter is {favLetter}.");

        }
    }
}
