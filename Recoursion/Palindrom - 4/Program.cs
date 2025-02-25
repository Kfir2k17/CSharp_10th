using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom___4
{
    internal class Program
    {
        public static bool Palindrom(int[] a, int left, int right)
        {
            if(left < right)
            {
                if (a[right] == a[left]) 
                    return Palindrom(a, left + 1, right - 1);

                return false;
            }
            return true;
        }
        public static bool Palindrom(int[] a)
        {
            return Palindrom(a, 0, a.Length - 1);
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 2, 1 };
            Console.WriteLine(Palindrom(a));
            Console.ReadLine();
        }
    }
}
