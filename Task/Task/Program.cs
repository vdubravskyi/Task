using System;
using Task.Classes;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();


            Console.WriteLine(solution.GetSolution("nice", "niece"));
            Console.WriteLine(solution.GetSolution("nece", "niece"));
            Console.WriteLine(solution.GetSolution("test", "tent"));
            Console.WriteLine(solution.GetSolution("form", "from"));
            Console.WriteLine(solution.GetSolution("abcdr", "abcrd"));
            Console.WriteLine(solution.GetSolution("bacde", "abcde"));
            Console.WriteLine(solution.GetSolution("o", "odd"));
            Console.WriteLine(solution.GetSolution("odd", "odd"));

        }
    }
}
