using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess = 0, chosen, counter = 0;
            char answer;
            Random rndm = new Random();
            chosen = rndm.Next(1, 101);

            Console.WriteLine("Welcome.\nPlease press any key to start the game.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The computer is choosing a number please wait.");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("The computer chose a number.");

            while (true)
            {
                while (guess != chosen)
                {
                    counter++;
                    Console.WriteLine("Guess the number that the computer choose: ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > chosen)
                    {
                        Console.WriteLine("Decrease the number.");
                        Thread.Sleep(2000);
                        Console.Clear();

                    }

                    else if (chosen > guess)
                    {
                        Console.WriteLine("Increase the number.");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Congratulations!");
                        Console.WriteLine("You guessed {0} times.", counter);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                {
                    Console.WriteLine("To contiune press 'c', to quit press 'q'.");
                    answer = Convert.ToChar(Console.ReadLine());

                    if (answer == 'c' || answer == 'C')
                    {
                        Console.WriteLine("Get ready to new round");
                        Thread.Sleep(2000);
                        Console.Clear();
                        chosen = rndm.Next(1, 101);
                        counter = 0;
                    }

                    if (answer == 'q' || answer == 'Q')
                    {
                        Console.WriteLine("See you soon");
                        break;
                    }
                }
            }
        }
    }
}
