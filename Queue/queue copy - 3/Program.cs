using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace queue_copy___3
{
    internal class Program
    {
        public static Queue<int> CopyQueue(Queue<int> q)//מחזירה תור חדש זהה ושומרת על התור המקורי
        {
            Queue<int> copy1 = new Queue<int>();
            Queue<int> copy2 = new Queue<int>();
            while (!q.IsEmpty())
            {
                int x = q.Remove();
                copy1.Insert(x);
                copy2.Insert(x);
            }
            while (!copy2.IsEmpty())//המטרה של הלולאה הזאת היא להחזיר את הערכים לתור המקורי  
                q.Insert(copy2.Remove());
            return copy1;
        }

        public static int QueueLength(Queue<int> q)//פעולה הבודקת את אורך התור
        {
            Queue<int> q1 = new Queue<int>();
            int counter = 0;

            while (!q.IsEmpty())
            {
                counter++;
                q1.Insert(q.Remove());
            }

            while (!q1.IsEmpty())
            {
                q.Insert(q1.Remove());
            }

            return counter;
        }

        public static int LengthWithCopyQueue(Queue<int> q)//פעולה הבודקת את אורך התור עם קופי קיו
        {
            Queue<int> q1 = CopyQueue(q);

            int counter = 0;
            while (!q1.IsEmpty())
            {
                q1.Remove();
                counter++;
            }
            return counter;
        }

        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            for (int i = 1; i <= 5; i++)
                q.Insert(i);
            Console.WriteLine(QueueLength(q));
            Console.WriteLine(q);

            Queue<int> q1 = CopyQueue(q);

            Console.WriteLine(LengthWithCopyQueue(q1));
            Console.WriteLine(q1);

            Console.ReadLine();
        }
    }
}
