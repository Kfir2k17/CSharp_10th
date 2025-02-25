using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_3._5
{
    internal class Program
    {
        //שאלה 1
        public static bool isCorrect(WordInSen[] arr) // פעולה המקבלת מערך של מהמחלקה ומחזירה אם מדובר במערך משפט תקין
        {
            bool[] check = new bool[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (check[arr[i].GetPlace()])
                    return false;
                check[arr[i].GetPlace()] = true;
            }

            for (int i = 0; i < check.Length; i++)
            {
                if (!check[i])
                    return false;
            }
            return true;
        }


        //שאלה 6
        public static int what1(Queue<int> q, int n, int a)
        {
            while (n > 0)
            {
                int b = q.Remove();
                n--;
                if (b < a)
                {
                    q.Insert(a);
                    a = b;
                }
                else
                    q.Insert(b);
            }
            return a;
        }

        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Insert(2);
            q.Insert(1);
            what1(q, 2, 0);
            Console.WriteLine(q);
        }
    }
}
