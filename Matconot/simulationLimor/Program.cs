using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulationLimor
{
    internal class Program
    {
        public static int MaxOppQueue(Node<OppQueue> list) // פעולה המקבלת שרשרת של המחלקה ומחזירה את המספר בעל האורך המקסימלי של תת סדרה נגדית
        {
            int max_num = 0; // המספר עם אורך הסדרה הארוך ביותר
            int max_length = 0; // אורך הסדרה הארוך ביותר
            Node<OppQueue> p = list;
            while (p != null)
            {
                int length = p.GetValue().OppLength();
                if (max_length < length)
                {
                    max_length = length;
                    max_num = p.GetValue().GetNum();
                }
                p = p.GetNext();
            }
            return max_num;
        }

        public static Node<int> DeleteSeconds(Node<int> list) // פעולה המקבלת רשימה ומדפיסה ומוחקת כל איבר שני ברשימה ומחזירה את האיבר האחרון שנשאר
        {
            Node<int> p = list;
            Node<int> pos = null; // חשוב להגדיר את המשתנה הזה מחוץ ללולאה
            while (p.HasNext())
                p = p.GetNext();
            p.SetNext(list);
            
            p= list;

            while (p.GetNext().GetNext() != p)
            {
                pos = p.GetNext();
                Console.WriteLine(pos.GetValue());
                p.SetNext(pos.GetNext());
                pos.SetNext(null);
                p= p.GetNext();
            }
            pos = p.GetNext();
            Console.WriteLine(pos.GetValue());
            p.SetNext(null);
            pos.SetNext(null);
            return p;
        }

        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(2);
            q.Insert(5);
            q.Insert(6);
            q.Insert(7);
            q.Insert(8);
            q.Insert(6);

            OppQueue opp = new OppQueue(q, 5);
            Console.WriteLine(opp.OppLength());

            Node<int> list = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Node<int>(4))));
            Console.WriteLine(DeleteSeconds(list));
            Console.WriteLine(21 % 10);
            Console.ReadLine();
        }
    }
}
