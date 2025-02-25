using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace Introduction___1
{
    internal class Program
    {
        public static double Average(Node<int> list)
        {
            int sum = 0;
            int counter = 0;
            Node<int> p = list;

            while (p != null)
            {
                sum += p.GetValue();
                counter++;
                p = p.GetNext();
            }
            return sum / counter;
        }

        public static void SumUntilNum(Node<int> list, Node<int> place)
        {
            int sum = 0;
            Node<int> p = list;

            while (p != place)
            {
                sum += p.GetValue();
                p = p.GetNext();
            }
            Console.WriteLine(sum);
        }

        public static Node<int> LowestNum(Node<int> list){
            Node<int> p = list;
            Node<int> min_node = null;
            
            while(p != null)
            {
                if (p.GetValue() < min_node.GetValue()) 
                    min_node = p;
                p = p.GetNext();
            }
            return min_node;
        }

        public static bool IsUp(Node<int> list)
        {
            Node<int> current = list;
            Node<int> next = current.GetNext();

            while (next != null)
            {
                if (current.GetValue() > next.GetValue())
                    return false;

                next = next.GetNext();
                current = current.GetNext();
            }
            return true;
        }

        public static void PrintUnique(Node<int> list1, Node<int> list2)
        {
            Node<int> a = list1;
            Node<int> b = list2;

            while (a != null)
            {
                while (b != null)
                {
                    if (a.GetValue() != b.GetValue())
                        Console.WriteLine(a.GetValue());
                    b = b.GetNext();
                }
                a = a.GetNext();
            }
        }

        public static bool LenList(Node<int> list)
        {
            Node<int> p = list;
            Node<int> pHalf = list;

            int amount = 0;

            while (p != null)
            {
                amount++;
                p = p.GetNext();
            }

            p = list;

            if (amount % 2 != 0)
                return false;

            for (int i = 0; i < amount / 2; i++)
                pHalf = pHalf.GetNext();

            while (pHalf != null)
            {
                if (p != pHalf)
                    return false;
                p = p.GetNext();
                pHalf = pHalf.GetNext();
            }
            return true;
        }

        public static bool AreTheyPairs(Node<char> list)
        {
            Node<char> p = list;
            int amount = 0;
            while (p != null)
            {
                amount++;
                p = p.GetNext();
            }

            if (amount % 2 != 0)
                return false;

            p = list;

            while (p != null)
            {
                if (p.GetValue() != p.GetNext().GetValue() || p.GetNext().GetValue() == p.GetNext().GetNext().GetValue())
                    return false;
                p = p.GetNext().GetNext();
            }
            return true;
        }

        public static bool IsIncrease(Node<int> list)
        {
            Node<int> p = list;
            while (p.GetNext() != null) 
            {
                if (p.GetValue() > p.GetNext().GetValue())
                    return false;
            }
            return false;
        }

        public static bool UpDown(Node<int> list)
        {
            Node<int> p = list;

            bool up = true;
            if (p.GetNext() == null || p.GetValue() >= p.GetNext().GetValue())
                return false;

            while (p.GetNext() != null)
            {
                if (p.GetValue() > p.GetNext().GetValue())
                    up = false;

                if (!up && p.GetValue() < p.GetNext().GetValue())
                    return false;
                
                p = p.GetNext();
            }
            if (up)
                return false;
            return true;
        }

       public static int HowManyGreater(Node<int> list)
        {
            Node<int> p = list;
            int counter = 0;

            while(p.GetNext() != null)
            {
                if(p.GetValue() < p.GetNext().GetValue())
                    counter++;
                p = p.GetNext();
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Node<int> list = new Node<int>(5, new Node<int>(60, new Node<int>(7, new Node<int>(5))));
            //Console.WriteLine(Average(list));
            //Console.WriteLine(IsUp(list));
            //Console.WriteLine(LowestNum(list));
            Console.WriteLine(UpDown(list));
            Console.ReadLine();
        }
    }
}