using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Palindrom___2
{
    internal class Program
    {
        public static Node<int> Last(Node<int> list)
        {
            Node<int> p = list;
            while (p.GetNext() != null)
            {
                p = p.GetNext();
            }
            return p;
        }
        public static Node<int> Prev(Node<int> list, Node<int> p)
        {
            if (p == list) return list;
            Node<int> p1 = list;
            while (p1.GetNext() != p)
            {
                p1 = p1.GetNext();
            }
            return p1;
        }

        public static bool ListSymmetries(Node<int> list)
        {
            Node<int> left = list;
            Node<int> right = Last(list);

            return ListSymmetries(list, right, left, left.GetValue() + right.GetValue());
        }
        public static bool ListSymmetries(Node<int> list, Node<int> right, Node<int> left, int sum)
        { 
             if (left.GetValue() + right.GetValue() != sum)
                return false;
            
            if (right.GetNext() == left)
                return true;

            return ListSymmetries(list, Prev(list, right), left.GetNext(), sum);
        }

        static void Main(string[] args)
        {
            Node<int> list = new Node<int>(9, new Node<int>(3, new Node<int>(7, new Node<int>(1))));
            Console.WriteLine(ListSymmetries(list));

            Console.ReadLine();
        }
    }
}
