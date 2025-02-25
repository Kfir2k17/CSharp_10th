using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___5
{
    internal class Program
    {
        public static void DeleteNodeN(int n, Node<int> list) //לא רלוונטי
        {
            int counter = 0;
            Node<int> back = list;
            Node<int> next = list.GetNext();

            while (next.HasNext())
            {
                if (counter == n)
                {
                    back.SetNext(new Node<int>(n, next));
                    break;
                }
                counter++;
                back = next;
                next = next.GetNext();
            }

            if (counter < n)
                list.SetNext(new Node<int>(n));
        }

        public static int MostRepeatedNum(Queue<int> queue) //פעולה המקבלת תור ומחזירה את הספרה הכי שכיחה בתור
        {
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = 0;

            while (!queue.IsEmpty())
            {
                int x = queue.Remove();
                while (x > 0)
                {
                    arr[x % 10]++;
                    x /= 10;
                }
            }

            int max_place = 0, max = arr[max_place];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    max_place = i;
                }
            }

            return max_place;
        }

        public static bool AreTwoDouble(Queue<int> q) //פעולה המקבלת תור של מספרים שלמים ובודקת האם קיים בתור איבר שערכו כפול מאיבר כלשהו אחר בתור
        {
            while (!q.IsEmpty())
            {
                Queue<int> copy = CopyQueue(q);
                int x = q.Remove();

                while (!copy.IsEmpty())
                {
                    int y = copy.Remove();
                    if (Math.Abs(y / x) == 2 && y % x == 0 || x % y == 0)
                        return true;
                }
            }
            return false;
        }

        public static Queue<int> PaliEven(Queue<int> q) //פעולה המקבלת תור שמורכב מזוגות סמוכים של מספרים שלמים זהים ומחזירה תור שבתחילתו מספר אחד מכל זוג ובהמשך שיקוף של תחילת התור
        {
            Queue<int> q1 = new Queue<int>();
            int last = q.Remove();
            while (!q.IsEmpty())
            {
                int x = q.Remove();
                if (x != last)
                {
                    q1.Insert(last);
                    last = x;
                }
            }
            q1.Insert(last);
            Queue<int> reverse = CopyQueue(q1);
            Reverse(reverse);
            
            while(!reverse.IsEmpty())
                q1.Insert(reverse.Remove());

            return q1;
        }

        //פעולות עזר
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

        public static void Reverse(Queue<int> q)//פעולה המקבלת תור והופכת אותו
        {
            if (!q.IsEmpty())
            {
                int x = q.Remove();
                Reverse(q);
                q.Insert(x);
            }
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Insert(2);
            queue.Insert(2);
            queue.Insert(2);
            queue.Insert(3);
            queue.Insert(3);
            queue.Insert(2);
            queue.Insert(4);
            queue.Insert(4);
            queue.Insert(5);
            queue.Insert(5);
            queue.Insert(4);

            Queue<int> q1 = PaliEven(queue);
            while (!q1.IsEmpty())
                Console.WriteLine(q1.Remove());

            Console.ReadLine();
        }
    }
}
