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

            // توليد رقم عشوائي بين 50 و 75
            // Next(50, 76) لأن الحد الأعلى غير مشمول
            int secretNumber = random.Next(50, 76);

            int guess = 0;           // تخزين تخمين المستخدم
            int attempts = 0;        // عدد المحاولات
            int points = 0;          // النقاط

            Console.WriteLine("Guessing Game");

            // حلقة while: تستمر حتى يخمن المستخدم الرقم الصحيح
            while (guess != secretNumber)
            {
                Console.Write("Guess a number between 50 and 75: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;  // زيادة عدد المحاولات

                // إذا كان التخمين صحيح
                if (guess == secretNumber)
                {
                    // حساب النقاط بناءً على عدد المحاولات
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
                // إذا كان التخمين أقل من الرقم السري
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Try a higher number.");
                }
                // إذا كان التخمين أكبر من الرقم السري
                else
                {
                    Console.WriteLine("Try a lower number.");
                }
            }

            Console.ReadKey();
        }
    }
}



