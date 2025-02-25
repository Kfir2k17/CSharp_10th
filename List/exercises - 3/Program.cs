using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace exercises___3
{
    internal class Program
    {
        public static Node<int> GetPrevious(Node<int> list, Node<int> x)
        {
            while (list != x)
                list = list.GetNext();
            return list;
        }
        public static Node<int> GetLast(Node<int> list)
        {
            while (list.GetNext() != null)
                list = list.GetNext();
            return list;
        }

        public static bool AreSidesEqual(Node<int> list)// O(n²), בודק אם 2 הצדדים שווים
        {
            if (list.GetNext() == null)
                return false;

            Node<int> i = list;

            while (i != null)
            {
                int start_sum = 0;
                int end_sum = 0;

                Node<int> end = i;

                while (end != null)
                {
                    end_sum += end.GetValue();
                    end = end.GetNext();
                }

                Node<int> start = list;

                while (start != i)
                {
                    start_sum += start.GetValue();
                    start = start.GetNext();
                }

                if (end_sum == start_sum)
                    return true;

                i = i.GetNext();
            }
            return false;
        }

        public static bool IsPalindrom(Node<int> letters)
        {
            if (letters.GetNext() == null) 
                return false;

            Node<int> left = letters;
            Node<int> right = GetLast(left);
            left = letters;

            while (right != left || left.GetNext() != right)
            {
                if (left != right)
                    return false;

                left = left.GetNext();
                right = GetPrevious(letters, right);
            }
            return true;
        }

        static void Main(string[] args)
        {
        }
    }
}
