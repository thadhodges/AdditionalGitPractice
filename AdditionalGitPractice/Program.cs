using System;

namespace AdditionalGitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name, Please?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}, Nice to meet you!/n How are you doing today?");
            var doing = Console.ReadLine();
            Console.WriteLine($"It's good to know you are doing {doing}.../n" +
                $"Mental Health is very important, Don't you agree?");
            Console.ReadLine();
        }
    }
}
