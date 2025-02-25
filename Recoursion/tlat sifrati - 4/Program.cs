using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace tlat_sifrati___4
{
    internal class Program
    {
        public static int Tlat(int[] a, int i)
        {
            if (i == a.Length)
                return 0;

            if (a[i] >= 100 && a[i] <= 999)
                return Tlat(a, i + 1) + 1;

            return Tlat(a, i + 1);

        }

        public static int Tlat(int[] a)
        {
            return Tlat(a, 0);
        }


        public static bool Isitodd(int[] a, int i)
        {
            if (a.Length == i)
                return true;

            if (a[i] % 2 == 0)
                return false;

            return Isitodd(a, i + 1);
        }

        public static bool Isitodd(int[] a)
        {
            return Isitodd(a, 0);
        }

        public static bool IsLow(char[] a, int i)
        {
            if (i == a.Length)
                return false;

            if (a[i] == 'a' || a[i] == 'b' || a[i] == 'c' || a[i] == 'd' || a[i] == 'e' || a[i] == 'f' || a[i] == 'g' || a[i] == 'h' || a[i] == 'i' || a[i] == 'j' || a[i] == 'k' || a[i] == 'l' || a[i] == 'm' || a[i] == 'n' || a[i] == 'o' || a[i] == 'p' || a[i] == 'q' || a[i] == 'r' || a[i] == 's' || a[i] == 't' || a[i] == 'u' || a[i] == 'v' || a[i] == 'w' || a[i] == 'x' || a[i] == 'y' || a[i] == 'z')
                return true;

            return IsLow(a, i + 1);
        }
        public static bool IsLow(char[] a)
        {
            return IsLow(a, 0);
        }


        static void Main(string[] args)
        {
        }
    }
}
