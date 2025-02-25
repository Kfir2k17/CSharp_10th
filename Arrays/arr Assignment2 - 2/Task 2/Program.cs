using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        public static int[] Avg(int[] show_rating, int[] show_raters)
        {
            int[] avg = new int[21];
            for (int i = 1; i <= 20; i++)
                avg[i] = show_rating[i] / show_raters[i];
            return avg;
        }
        static void Main(string[] args)
        {
            int[] show_rating = new int[21];
            int[] show_raters = new int[21];

            for(int i = 1; i <= 300; i++)
            {
                Console.WriteLine("Hello participant {0}. Please enter the number of the show you want to rate (from 1 - 20).", i);
                int show_num = int.Parse(Console.ReadLine());
                show_raters[show_num]++;
                Console.WriteLine("\nHow Much Would You rate it?");
                show_rating[show_num] = int.Parse(Console.ReadLine());
            }
            int[] avg = Avg(show_rating, show_raters);
            int max_avg = Math.Max(avg);
        }
    }
}