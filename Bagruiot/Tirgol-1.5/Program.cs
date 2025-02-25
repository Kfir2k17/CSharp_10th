using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unit4.CollectionsLib;

namespace Tirgol_1._5
{
    internal class Program
    {
        public static void Print(Node<double> list) // פעולת עזר שמדפיסה רשימת מספרים ממשיים
        {
            Node<double> p = list;

            while (p != null)
            {
                Console.Write(p.GetValue() + " ");

                p = p.GetNext();
            }

            Console.WriteLine();
        }

        public static void Print(Node<Node<double>> list) // פעולת עזר שמדפיסה רשימה של רשימת מספרים ממשיים
        {
            Node<Node<double>> p = list;
            while (p != null)
            {
                Print(p.GetValue());
                p = p.GetNext();
                
                Console.WriteLine();
            }
        }
        public static Node<Node<double>> ListOfItems() // פעולה חיצונית שקולטת מכל לקוח שנכנס לסופר את כמות המוצרים שהוא קנה ואז את המחירים שלהם. הפעולה תחזיר רשימה שכל איבר בה היא רשימת המוצרים שקנה כל לקוח
        {
            Console.WriteLine("Please enter the number of items you bought");
            int num = int.Parse(Console.ReadLine());

            Node<Node<double>> mega_list = null;
            Node<Node<double>> mega_last = mega_list;

            while (num != 0)
            {
                Console.WriteLine("Enter item number 1");
                Node<double> list = new Node<double>(double.Parse(Console.ReadLine()));
                Node<double> last = list;

                for (int i = 1; i < num; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter item number " + (i + 1));
                    last.SetNext(new Node<double>(double.Parse(Console.ReadLine())));
                    last = last.GetNext();
                }

                if (mega_list == null)
                {
                    mega_list = new Node<Node<double>>(list);
                    mega_last = mega_list;
                }

                else
                {
                    mega_last.SetNext(new Node<Node<double>>(list));
                    mega_last = mega_last.GetNext();
                }

                Console.WriteLine("Please enter the number of items you bought");
                num = int.Parse(Console.ReadLine());
            }

            return mega_list;
        }

        static void Main(string[] args)
        {
            Print(ListOfItems());
        }
    }
}
