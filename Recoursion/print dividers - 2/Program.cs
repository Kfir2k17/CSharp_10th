using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_dividers___2
{
    internal class Program 
    {
        public static int HowManyDigits(int n) // פעולת מעטפת
        {

        }

        public static int HowManyDigits(int n, int fs, ) //
        {

        }

        public static int Mystery(int num)
        {
            if (num < 10)
                return num;

            else
            {
                int i = 10;
                while (num % i != num)
                    i *= 10;

                return ((num % 10) * i / 10) + Mystery(num/10);
            }
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(Mystery(457));
            Console.ReadLine();
        }
    }
}
