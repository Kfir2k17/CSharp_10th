using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Library___1
{
    internal class Program
    {
            static void Main(string[] args)
            {
            Random r1 = new Random();

            int num1 = r1.Next(1, 7);
            int num2 = r1.Next(1, 7);

            if (num1 == 6 && num2 == 5 || num2 == 6 && num1 == 5)
                Console.WriteLine("true");

            else
                Console.WriteLine("false");

            Console.WriteLine(num1 + ", " + num2);
            Console.ReadLine();
            }
    }
}
