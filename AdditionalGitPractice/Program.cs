using System;

namespace AdditionalGitPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name, Please?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}, Nice to meet you!");
        }
    }
}
