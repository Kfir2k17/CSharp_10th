using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

namespace introduction___1
{
    internal class Program
    {
        public static Queue<double> CopyQueue(Queue<double> q)//פעולת עזר המעתיקה תור
        {
            Queue<double> t1 = new Queue<double>();
            Queue<double> t2 = new Queue<double>();

            while (!q.IsEmpty())
            {
                double x = q.Remove();
                t1.Insert(x);
                t2.Insert(x);
            }
            while (!t1.IsEmpty())
                q.Insert(t1.Remove());

            return t2;
        }

        public static Queue<int> CopyQueue(Queue<int> q)//פעולת עזר המעתיקה תור
        {
            Queue<int> t1 = new Queue<int>();
            Queue<int> t2 = new Queue<int>();

            while (!q.IsEmpty())
            {
                int x = q.Remove();
                t1.Insert(x);
                t2.Insert(x);
            }
            while (!t1.IsEmpty())
                q.Insert(t1.Remove());

            return t2;
        }

        public int MaxSeq(Queue<double> queue)//פעולה המחזירה את אורך רצף המספרים הממוינים בסדר עולה הארוך ביותר
        {
            if (queue.IsEmpty())
                return 0;

            int max = 0;
            double x = queue.Remove();
            int current = 0;
            
            while (!queue.IsEmpty())
            {
                double y = queue.Remove();
                if (y > x)
                    current++;

                if (y <= x)
                {
                    if (max > current) 
                        max = current;
                    current = 0;
                }
                x = y;
            }

            return max;
        }

        public static Queue<int> ArrToQueue(int[] arr)//פעולה המקבלת מערך ומחזירה תור של אותו מערך
        {
            Queue<int> queue = new Queue<int>();

            for (int i = arr.Length - 1; i <= 0; i++)
                queue.Insert(arr[i]);

            return queue;
        }

        public static int ReturnMaxValue(Queue<int> q) //מחזירה את הרצף הארוך ביותר, רצפים מופרדים ב -9
        {
            Queue<int> queue = CopyQueue(q);
            int max = 0;
            int current = 0;

            while (!queue.IsEmpty())
            {
                int x = queue.Remove();
                if (x == -9)
                {
                    if (current > max) max = current;
                    current = queue.Remove();
                }

                else
                {
                    current *= 10;
                    current += x;
                }
            }

            if (current > max) max = current;

            return max;
        }

        public static bool SmallInBig(Queue<int> big, Queue<int> small) //פעולה המקבלת 2 תורים ומחזירה אמת אם הקטן נמצא בתוך הגדול
        {
            Queue<int> copy_big = CopyQueue(big);
            Queue<int> copy_small = CopyQueue(small);
            int big_counter = 0;
            int small_counter = 0;

            while (!copy_big.IsEmpty())
            {
                big_counter++;
                copy_big.Remove();

                if (!small.IsEmpty())
                {
                    small_counter++;
                    copy_small.Remove();
                }
            }

            int counter = 0;
            
            Queue<int> place = CopyQueue(big);

            while (counter + small_counter < big_counter)
            {
                copy_small = CopyQueue(small);
                int match = 0;
                if (copy_small.Head() == place.Head())
                {
                    copy_big = CopyQueue(place);
                    while (copy_small.Head() == copy_big.Head())
                    {
                        copy_small.Remove();
                        copy_big.Remove();
                        match++;
                    }
                    if (match == small_counter) return true;
                }
                counter++;
                place.Remove();
            }
            return false;
        }

        public static Queue<RezefTavim> CharsToRezef(Queue<char> queue) //פעולה המקבלת תור של תווים והופכת אותו לתור של רצף תווים
        {
            Queue<RezefTavim> rezef = new Queue<RezefTavim>();

            char current = 'a';
            int times = 0;

            while (!queue.IsEmpty())
            {
                char ot = queue.Remove();

                if (ot != current)
                {
                    rezef.Insert(new RezefTavim(ot, times));
                    times = 0;
                    current = queue.Remove();
                }
                times++;
            }
            return rezef;
        }

        public static bool IsTmora(Queue<int> q) //פעולה המקבלת תור ובודקת האם הוא תור תמורה
        {
            Queue<int> q1 = CopyQueue(q);
            int size = 0;
            while (!q1.IsEmpty())
            {
                size++;
                q1.Remove();
            }

            bool[] bools = new bool[size];

            while (!q.IsEmpty()) 
            {
                int x = q.Remove();

                if (bools[x])
                    return false;

                if (!bools[x])
                    bools[x] = true;
            }

            for (int i = 0; i < size; i++)
            {
                if (!bools[i])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Queue<int> testQueue = new Queue<int>();

            testQueue.Insert(1);
            testQueue.Insert(2);
            testQueue.Insert(-9);
            testQueue.Insert(3);
            testQueue.Insert(4);
            testQueue.Insert(-9);
            testQueue.Insert(5);
            testQueue.Insert(6);
                
            int result = ReturnMaxValue(testQueue);

            Console.WriteLine("Max value in the sequence: " + result);
            Console.ReadLine();
        }
    }
}