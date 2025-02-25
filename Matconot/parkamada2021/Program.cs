using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkamada2021
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

        public static void RemoveBalancedDigit(Queue<int> q)
        {

        }

        static void Main(string[] args)
        {
        }
    }
}
