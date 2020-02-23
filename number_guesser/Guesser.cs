using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_guesser
{
    class Guesser
    {
        public static void GetAppInfo()
        {
            string appName = "Number guesser game";
            string appVersion = "1.0";
            string author = "Mateusz Nowak";

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);
            Console.ResetColor();
        }
        public static void GreetUser()
        {
            Console.WriteLine("\nEnter player name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Player: {0}", playerName);
            Console.ReadLine();
        }
        public static void Game()
        {
            Random random = new Random();
            while (true)
            {
                int anwserNum = random.Next(1, 10);

                int guess = 0;

                Console.Clear();
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != anwserNum)
                {
                    string strGuess = Console.ReadLine();

                    if (!int.TryParse(strGuess, out guess))
                    {
                        Console.WriteLine("Enter a NUMBER!");
                        continue;
                    }

                    if (guess != anwserNum)
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong answer. Try again: ");
                    }
                }

                Console.WriteLine("You WIN!");

                Console.Write("Play agian (y - yes, n - no): ");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
