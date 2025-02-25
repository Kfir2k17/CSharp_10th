using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yood_Alef
{
    internal class Program
    {
        //שאלה 1
        public static bool IsIndexSort(int[] A, int[] B) // פעולה המקבלת 2 מערכים ומחזירה אם מסריקת מערך א לפי ב מתקבלת סדרה עולה
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[B[i]] > A[B[i + 1]])
                    return false;
            }
            return true;
        }

        //שאלה 4
        public static int CQ(Queue<char> q) // פעולת עזר שמחזירה את אורך התור
        {
            Queue<char> tmp = new Queue<char>();
            int counter = 0;
            while (!q.IsEmpty())
            {
                counter++;
                tmp.Insert(q.Remove());
            }
            while (!tmp.IsEmpty())
            {
                q.Insert(tmp.Remove());
            }
            return counter;
        }

        public static void Reverse(Queue<char> q)
        {
            if (!q.IsEmpty())
            {
                char x = q.Remove();
                Reverse(q);
                q.Insert(x);
            }
        }

        public static bool IsTripleP(Queue<char> q) // פעולה שמחזירה אם התור עונה להגדרה של פלינדרום משולש
        {
            int len = CQ(q);
            Queue<char> temp = new Queue<char>();

            if (len % 3 != 0)
                return false;

            for (int i = 0; i < (len / (len / 3)) / 2 + 1; i++)
            {
                for (int k = 0; k < len / 3; k++)
                    temp.Insert(q.Remove());
                Reverse(temp);

                if (q.IsEmpty())
                    return true;


            }
        }

        static void Main(string[] args)
        {
            int[] A = { 81, -7, 15, 0, 2 };
            int[] B = { 1, 2, 4, 3, 0 };

            Console.WriteLine(IsIndexSort(A, B));
        }
    }
}