using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sidra___5
{
    internal class Program
    {
        public static int Sidra(int num)
        {
            if (num == 1)
            {
                Console.WriteLine(1);
                return 1;
            }

            int sidra = Sidra(num - 1) * 3 + 1;
            Console.WriteLine(sidra);
            return sidra;
        }


        static void Main(string[] args)
        {
            Sidra(6);

            Console.ReadLine();
        }
    }
}
