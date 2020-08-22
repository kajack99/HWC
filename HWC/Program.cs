using System;

namespace HelloWorldCovidStyle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Are you staying safe?");
            var userResponse = Console.ReadLine();

            Console.WriteLine("Nice to meet you.");

            Console.WriteLine("What's your age?");
            userResponse = Console.ReadLine();
            Console.WriteLine("That's old! I'm younger. Haha!");

            Console.WriteLine("What did you do today?");
            userResponse = Console.ReadLine();
            Console.WriteLine("Oh, that's all... Ever think about watching less tv?");
            userResponse = Console.ReadLine();
            Console.WriteLine("You should.");
            Console.WriteLine("Have a nice day!");
        }
    }
}