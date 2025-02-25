using System;
using Unit4.CollectionsLib;

namespace Matconet___1
{
    internal class Program
    {
        public static bool StrInArr(string str, char[] arr) // שאלה ראשונה, פעולה המקבלת מערך ומחרוזת ובודקת אם התווים של המחרוזת מופיעים ברצף במערך
        {
            for (int i = 0; i < arr.Length - str.Length; i++)
            {
                if (str[0] == arr[i])
                {
                    int count = 0;
                    while (count < str.Length && str[count] == arr[i + count])
                        count++;

                    if (count == str.Length)
                        return true;
                }
            }
            return false;
        }

        public static double OtherTotalPrice(Ticket[] arr, Ticket tic) // שאלה 2, הפעולה מקבלת מערך של כרטיסים ומחזירה את סהכ מחיר הכריטיסים במערך שאינם לאותה הופעה כמו הכרטיס
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (tic.Distance(arr[i]) == -1)
                    sum += arr[i].GetPrice();
            }
            return sum;
        }

        public static string PopulatedVillage(RabbitVillage[] vlgs) // פעולה המקבלת מערך של כפרי ארנבים ומחזירה את שמו של כפר הארנבים עם המספר הגבוה ביותר של משפחות עם מעל ל-8 צאצאים
        {
            int max = 0;
            int max_i = 0;

            for (int i = 0; i < vlgs.Length; i++)
            {
                int num = vlgs[i].BigF();
                if (num > max)
                {
                    max = num;
                    max_i = i;
                }
            }
            return vlgs[max_i].GetName();
        }

        public static Node<int> LastVals(Queue<Queue<int>> q) // שאלה 4, מקבלת תור של תורים ויוצרת רשימה שמכילה את הערך האחרון של כל אחד מהתורים של התור המקורי
        {
            Node<int> list = null, p = null;
            while (!q.IsEmpty())
            {
                Queue<int> q2 = q.Remove();
                int num = q2.Remove();

                while (!q2.IsEmpty())
                    num = q2.Remove();

                if (list == null)
                {
                    list = new Node<int>(num);
                    p = list;
                }

                else
                {
                    p.SetNext(new Node<int>(num));
                    p = p.GetNext();
                }
            }
            return list;
        }

        public static void DeleteNode(Node<kind> list, int value, int place)
        {
            int counter = 0;
            Node<kind> p = list;
            while (counter < place)
                p = p.GetNext(); // רצים עד לאיבר אותו אנו רוצים למחוק
            Node<kind> pos = p.GetNext();
            p.SetNext(pos.GetNext());
            pos.SetNext(null);
        }

        public static double OffRoadAndElectric(Vehicle[] vs) // שאלה 7, פעולה שמקבלת מערך של כלי רכב ומחזירה את סכום המחיר הסופי של כל אופנועי השטח החשמליים במערך
        {
            double price = 0;
            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] is Bike)
                {
                    Bike bike = (Bike)vs[i];
                    if (bike.GetStreet() && vs[i].GetElectric())
                        price += vs[i].FinalPrice();
                }

            }
            return price;
        }

        public static int What(int x, int y) // שאלה 6 סעיף א-ג, פעולה המחזירה את מכפלת שני המספרים שהיא מקבלת כפרמטר
        {
            if (y == 0)
                return 0;

            if (y % 2 == 0)
                return What(x + x, y / 2);

            return What(x + x, y / 2) + x;
        }

        public static int Why(int[] a, int n) // שאלה 7, סעיפים ד-ה, פעולה המחזירה את זוג המספרים בעל המכפלה הגדולה ביותר, כשהמספר שהיא מקבלת הוא האינדקס של המספר שממנו מתחילה הבדיקה        {
        {
            int p = a.Length - 2;
            if (n == p)
                return What(a[p], a[p+1]);
            int med = Why(a, n + 1);
            int res = What(a[n], a[n+1]);
            return Math.Max(med, res);
        }

        public static void UpPairs(int[] a, int n) // פעולה המדפיסה את הזוגות במערך שבהן האיבר הראשון קטן מן השני
        {
            if (n < a.Length - 1)
            {
                if (a[n] < a[n + 1])
                    Console.WriteLine("{0}, {1}", a[n], a[n + 1]);
                UpPairs(a, n + 1);
            }
        }

        static void Main(string[] args)
        {
            //שאלה 6
            int r1 = What(3, 5);

            int r2 = What(3, 4);

            Console.WriteLine(r1);
            Console.WriteLine(r2);

            //שאלה 6
            int[] arr = new int[]{ 7, 2, 8, 11, 9 };
            UpPairs(arr, 0);

            //שאלה 5
            //string str = "bce";
            //char[] arr = { 'a', 'b', 'c', 'd', 'e' };
            //Console.WriteLine(StrInArr(str, arr));

            //Queue<Queue<int>> q = new Queue<Queue<int>>();
            //for (int i = 0; i < 5; i++)
            //{
            //    Queue<int> q1 = new Queue<int>();
            //    for (int k = 0; k < 13; k++)
            //        q1.Insert(k);
            //    q.Insert(q1);
            //}

            //Console.WriteLine(LastVals(q));

            //שאלה 8
            A a1 = new A(2);
            Object[] objs = new object[6];
            objs[0] = new A();
            objs[1] = new A(7);
            objs[2] = new B();
            objs[3] = new B(7);
            objs[4] = new B(0, 2);
            objs[5] = a1;

            for (int i = 0; i < 6; i++)
                Console.WriteLine(objs[i]);

            Console.ReadLine();
        }
    }
}
