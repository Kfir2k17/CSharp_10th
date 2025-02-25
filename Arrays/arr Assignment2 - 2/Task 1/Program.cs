using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        public static int[] Game()
        {
            Random rnd = new Random();
            int[] game = new int[4];

            for (int x = 0; x < game.Length; x++)
            {
                    game[x] = rnd.Next(10);
            }

            for (int y = 0; y < game.Length; y++)
            {
                for(int z = y+1; z <game.Length; z++)
                {
                    if (game[y] == game[z])
                    {
                        while (game[y] == game[z])
                            game[y] = rnd.Next(10);
                    }
                }
            }

            return game;
        }

        public static int[] Guess()
        {
            int[] guess = new int[4];
            for (int i = 0; i < guess.Length; i++)
            {
                Console.WriteLine("Please enter digit " + (i + 1));
                guess[i] = int.Parse(Console.ReadLine());
            }
            return guess;
        }

        public static int HowMany(int[] game, int[] guess)
        {
            int hit = 0;
            int full_hit = 0;

            for (int x = 0; x < game.Length; x++)
            {
                for (int y = 0; y < game.Length; y++)
                {
                    if (game[x] == guess[y] && x == y)
                        full_hit++;
                    if (game[x] == guess[y] && x != y)
                        hit++;
                }
            }
            Console.WriteLine("You had {0} hits and {1} bulls' eye", hit, full_hit);
            return full_hit;
        }

        static bool Resulter(int[] game, int[] guess, int full_hit)
        {
            bool Victory = false;
            if (full_hit == 4)
            {
                Console.WriteLine("You Won!!!!!");
                return true;
            }

            if (full_hit < 4)
            {
                Console.Write("The number you guessed was ");
                for (int i = 0; i < guess.Length; i++)
                {
                    Console.Write(guess[i]);
                }
            }
            return Victory;
        }

        static void Main(string[] args)
        {
            bool Victory = false;
            int counter = 1;
            int[] game = Game();
            Console.WriteLine("Please enter a 4 digit number");
            while (Victory == false && counter < 31)
            {
                Console.WriteLine("\ntry " + counter);
                int[] guess = Guess();
                int full_hit = HowMany(game, guess);
                Victory = Resulter(game, guess, full_hit);
                counter++;
            }

            if (counter <= 30 && Victory == false)
            { 
                Console.WriteLine("Major Skill Issue to be honest");
                Console.WriteLine("The number was:");
                for (int i = 0; i < game.Length; i++)
                    Console.Write(game[i]);
            }
            
            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadLine();
        }
    }
}