using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_Odd_Nodes___7
{
    internal class Program
    {
        public static void DeleteLast(Node<int> list) 
        {
            Node<int> p = list;
            while (p.GetNext().HasNext())
                p = p.GetNext();
            p.SetNext(null);
        }

        public static void DeleteSequence(Node<char> list)
        {
            Node<char> p = list.GetNext();
            Node<char> prev = list;
            while (p != null)
            {
                if (prev.GetValue() == p.GetValue())
                { 
                    prev.SetNext(p.GetNext());
                    p.SetNext(null);
                    p = prev.GetNext();
                }
                
                else 
                { 
                    prev = p;
                    p = p.GetNext();
                }
            }
        }
        public static void Print(Node<int> list)
        {
            Node<int> p = list;
            while (p != null)
            {
                Console.Write(p.GetValue() + " ");
                p = p.GetNext();
            }
            Console.WriteLine();
        }
        public static void Print(Node<char> list)
        {
            Node<char> p = list;
            while (p != null)
            {
                Console.Write(p.GetValue() + " ");
                p = p.GetNext();
            }
            Console.WriteLine();
        }

        public static Node<int> DeleteMaxAndMin(Node<int> list)
        {
            Node<int> p = list;

            if (!p.HasNext())
                return null;

            int min = int.MaxValue;
            int max = int.MinValue;
            int comp = 0;

            while (p != null)
            {
                if (p.GetValue() < min)
                    min = p.GetValue();

                if (p.GetValue() > max)
                    max = p.GetValue();
                
                p = p.GetNext();
            }

            p = list;
            Node<int> check = list.GetNext();
            Node<int> prev = list;

            while (comp < 2 && check != null)
            {
                if (check.GetValue() == min)
                {
                    prev.SetNext(check.GetNext());
                    check.SetNext(null);
                    comp++;
                }

                if (check.GetValue() == max)
                {
                    prev.SetNext(check.GetNext());
                    check.SetNext(null);
                    comp++;
                }
                prev = prev.GetNext();
                check = check.GetNext();
            }
            return list;
        }
        static void Main(string[] args)
        {
            Node<char> list = new Node<char>('r', new Node<char>('r', new Node<char>('r', new Node<char>('l', new Node<char>('l')))));
            Node<int> list2 = new Node<int>(5, new Node<int>(20, new Node<int>(25, new Node<int>(3, new Node<int>(30, new Node<int>(5, new Node<int>(6, new Node<int>(11))))))));
            DeleteSequence(list);
            //Print(list);
            Node<int> list22 = DeleteMaxAndMin(list2);
            Print(list22);
            Console.ReadLine();
        }
    }
}
