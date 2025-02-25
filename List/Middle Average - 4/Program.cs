using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Middle_Average___4
{
    internal class Program
    {
        public static Node<int> BuildList(int n)
        {
            Console.WriteLine("Please enter the first number:");
            int x = int.Parse(Console.ReadLine());
            Node<int> list = new Node<int>(x);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Add another number");
                int value = int.Parse(Console.ReadLine());
                list.SetNext(new Node<int>(value));
                list = list.GetNext();
            }
            return list;
        }
        public static Node<int> ReverseList(Node<int> list)
        {
            Node<int> reverse = null;
            Node<int> p = list;

            while (list != null)
            {
                reverse = new Node<int>(list.GetValue(), reverse);
                list = list.GetNext();
            }
            return reverse;
        }
        public static Node<int> GetLast(Node<int> list)
        {
            while(list.GetNext()!= null)
                list = list.GetNext();
            return list;
        }

        public static Node<int> Duplicate(Node<int> list, int k)
        {
            Node<int> p = list;
            int counter = 0;

            N
            while (counter < k) 
            {
                reverse = new Node<int>(list.GetValue(), reverse);
                list = list.GetNext();
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
