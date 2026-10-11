using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class GuessingGame
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int secretNumber = random.Next(50, 76);

            int guess = 0;           
            int attempts = 0;       
            int points = 0;          

            Console.WriteLine("Guessing Game");

            while (guess != secretNumber)
            {
                Console.Write("Guess a number between 50 and 75: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;  

                if (guess == secretNumber)
                {
                    if (attempts == 1)
                        points = 10;
                    else if (attempts == 2)
                        points = 7;
                    else if (attempts == 3)
                        points = 5;
                    else
                        points = 0;

                    Console.WriteLine("\nCongratulations!");
                    Console.WriteLine($"Attempts: {attempts}");
                    Console.WriteLine($"Points: {points}");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                else
                {
                    Console.WriteLine("Try a lower number.");
                }
            }

            Console.ReadKey();
        }
    }
}



