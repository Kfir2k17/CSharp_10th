using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_1____replace_space_with
{
    internal class Program
    {
        public static string ReplaceSpace(string s1)
        {
            int space_num = 0;
            for (int i = 0; i < s1.Length; i++) 
            {
                if (s1[i] == ' ')
                    space_num++;
            }

            string s2 = null;
            
            for (int i = 0; i < space_num; i++)
            {
                s2 += '*';
            }
            
            return s2;
        }

        public static void Prrr(int n) 
        {
            if (n > 0)
            {
                Console.WriteLine(n);
                Prrr(n - 1);
                Console.WriteLine(n);
            }

            else
                Console.WriteLine('*');
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceSpace("     "));

            Console.WriteLine();

            Prrr(4);
            Console.ReadLine();
        }
    }
}
