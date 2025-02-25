
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace bool___3
{
    internal class Program
    {
        public static bool Exist(int[] a, int x, int i)
        {
            if (i == a.Length)
                return false;

            if (a[i] == x)
                return true;

            return Exist(a, x, i + 1);
        }
        public static bool Exist(int[] a, int x)
        {
            return Exist(a, x, 0);
        }

        public static int BinSearch(int[] a, int x, int left, int right)
        {
            if (right >= left)
            {
                int mid = (left + right) / 2;
            
                if (a[mid] == x)
                    return mid;
            
                if (a[mid] > x)
                    return BinSearch(a, x, mid + 1, right);
            
                else
                    return BinSearch(a, x, left, mid - 1);
            }
            return -1;
        }

        public static int BinSearch(int[] a, int x)
        {
            return BinSearch(a, x, 0, a.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6};
            Console.WriteLine(Exist(a, 7));
            Console.ReadLine();
        }
    }
}
