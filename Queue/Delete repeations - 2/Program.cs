using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Delete_repeations___2
{
    internal class Program
    {
        public static Queue<Patient> CopyQueue(Queue<Patient> q)//מחזירה תור חדש זהה ושומרת על התור המקורי
        {
            Queue<Patient> copy1 = new Queue<Patient>();
            Queue<Patient> copy2 = new Queue<Patient>();
            while (!q.IsEmpty())
            {
                Patient x = q.Remove();
                copy1.Insert(x);
                copy2.Insert(x);
            }
            while (!copy2.IsEmpty())//המטרה של הלולאה הזאת היא להחזיר את הערכים לתור המקורי  
                q.Insert(copy2.Remove());
            return copy1;
        }
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
        public static void Reverse(Queue<int> q)
        {
            if (!q.IsEmpty())
            {
                int x = q.Remove();
                Reverse(q);
                q.Insert(x);
            }
        }

        public static void RemoveDuplications(Queue<int> queue)
        {
            Queue<int> second = new Queue<int>();
            Queue<int> copy = new Queue<int>();

            while (!queue.IsEmpty())
            {
                copy = CopyQueue(second);
                int x = queue.Remove();
                bool inthelist = false;

                while (!copy.IsEmpty() && !inthelist)
                {
                    if (x == copy.Remove())
                        inthelist = true;
                }

                if (!inthelist)
                    second.Insert(x);

                Console.WriteLine(second);
            }
        }
        
        public static void AddPatient(Queue<Patient> queue, Patient x)
        {
            bool onthelist = false;
            Queue<Patient> ass = new Queue<Patient>();
            
        }

        static void Main(string[] args)
        {
        }
    }
}
