using System;

namespace SelectionStatementsConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");

            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine($"Too High!");
            }
            else if(userInput < favNumber)
            {
                Console.WriteLine($"Too Low!");
            }
            else
            {
                Console.WriteLine($"Nevermind");   
            }
        }
    }
}
