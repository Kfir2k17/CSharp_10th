using System;
using Unit4.CollectionsLib;

namespace Matconet2024
{
    class Worker
        {
            private int salary; // משכורת
            private int prof; // קוד מקצוע

            public Worker(int salary, int prof) // פעולה בונה
            {
                this.salary = salary;
                this.prof = prof;
            }

            //Get
            public int GetSalary() { return salary; }
            public int GetProf() { return prof; }

            //Set
            public void SetSalary(int salary) { this.salary = salary; }
            public void SetProf(int prof) { this.prof = prof; }
        } // שאלה 1
    class Dish
    {
        private string name; // שם
        private int id; // סוג המנה
        private int count; // כמות ההזמנות היומית של המנה

        public Dish(string name, int id) // פעולה בונה
        {
            this.name = name;
            this.id = id;
            this.count = 0;
        }

        //Get
        public string GetName() { return name; }
        public int GetId() { return id; }
        public int GetCount() { return count; }

        //Set
        public void SetCount(int count) { this.count = count; }
        public void SetName(string name) { this.name = name; }
        public void SetId(int id)
        {
            this.id = id;
        }
    } // שאלה 3
    class Restarurant
    {
        private Dish[] dishes; // מערך של מנות שהמסעדה מציאה

        public Restarurant(int x) // פעולה בונה
        {
            for (int i = 1; i <= x; i++)
                dishes[i-1] = new Dish("Dish " + i, i );
        }

        public void DailyOrders() // סעיף ג, פעולה המקבלת את ההזמנות שהלקוחות מבצעים ביום אחד ומעדכנת את המערך בהתאם
        {
            for (int i = 0; i < dishes.Length; i++)
                dishes[i].SetCount(0);

            int x = int.Parse(Console.ReadLine());
            while (x > 0 && x <= dishes.Length)
            {
                dishes[x].SetCount(dishes[x].GetCount() + 1);
                x = int.Parse(Console.ReadLine());
            }
        }
    } // שאלה 3
    class SmartC
        {
            public SmartC() { }
            public bool Sort() { return true; }
            public void Add(int x) { }
            public SmartC Clone() { return this; }
            public bool HasAtLeast(int x) { return true; }
            public int GetItem(int x) { return x; }
        } // שאלה 4
    internal class Program
    {
        // שאלה 1
        public static Worker[] ATW(int[] arr) // פעולה המקבלת מערך ומחזירה מערך של עובדים על בסיס המערך המקורי
        {
            Worker[] workers = new Worker[arr.Length / 2];
            for (int i = 0; i < arr.Length / 2; i += 2)
                workers[i / 2] = new Worker(arr[i], arr[i + 1]);
            return workers;
        }

        // שאלה 2
        public static double[] Averages(int[] A, int[] B) // פעולה המקבלת 2 מערכים המסמלים את זמני המסך של תלמידים שונים ומחזירה מערך עם הממוצע של כל תלמיד
        {
            double[] average = new double[A.Length];
            for (int i = 0, count = 0; i < A.Length; i++)
            {
                int sum = 0;
                for (int j = count; j < j + A[i]; j++)
                {
                    sum += B[j];
                }
                count += A[i];
                average[i] = sum / A[i];
            }
            return average;
        }

        // שאלה 4 סעיף א 
        public static SmartC Sums(SmartC sc1, SmartC sc2) // פעולה המקבלת 2 אוספים חכמים ומחזירה אוסף חכם חדש שאיבריו הם סכום כל 2 איברים באותו מקום באוספים השונים
        {
            SmartC sc3 = new SmartC();
            for (int i = 1; sc1.HasAtLeast(i); i++)
                sc3.Add(sc1.GetItem(i) + sc2.GetItem(i));
            return sc3;
        }
        // שאלה 4 סעיף ב
        public static SmartC Prods(SmartC sc) // פעולה המקבלת אוסף חכם ומחזירה אוסף חכם שבו האיברים הם מכפלת האיבר הראשון והאחרון בהתאמה באוסף המקורי
        {
            SmartC sc2 = new SmartC();
            int length = 0;
            while (sc.HasAtLeast(length))
                length++;

            for (int i = 0; i < length / 2; i++)
                sc2.Add(sc.GetItem(i) *  sc.GetItem(length - i + 1));
            return sc2;
        }

        //שאלה 5
        public static Queue<int> Serial(Queue<int> q) // פעולה המקבלת תור ומחזירה תור נוסף שבו נמצאים לפי סדר האיבר הראשון, ההפרש בין הערכים ומספר האיברים בתור במידה והתור לא ריק, אחרת יוחזר ריק
        {
            Queue<int> q1 = new Queue<int> ();
            int first = q.Remove();
            int x = q.Remove();
            int dif = first - x;
            int counter = 2;

            while (!q.IsEmpty())
            {
                if (x - q.Head() != dif)
                    return null;
                counter++;
                x = q.Remove();
            }

            q1.Insert(first);
            q1.Insert(dif);
            q1.Insert(counter);
            return q;
        }

        // שאלה 6
        public static int Sod(Queue<int> q, int s) // פעולה רקורסיבית שמקבלת תור ואת המספר 0 ומחזירה את סכום הספרות של האיברים בתור
        {
            if (q.IsEmpty())
                return s;
            int x = q.Remove();
            s += x % 10;
            x /= 10;
            if (x > 0)
                q.Insert(x);
            return Sod(q, s);
        }
        public static int What(int[] a, Queue<int> q) // פעולה רקורסיבית המקבלת מערך ותור ומחזירה את סכום הספרות של כל האיברים (חוץ מהראשון המשמש כאינדקס) במערך
        {
            if (a[0] >= a.Length)
                return 0;
            int v = a[a[0]];
            a[0]++;
            int res = What(a, q);
            q.Insert(v);
            res += Sod(q, 0);
            return res;
        }
        
        //שאלה 7 סעיף א
        public static int[] GetSides(int x) // פעולה המקבלת מספר ומחזירה מערך עם ספרות הקיצון שלו
        {
            int[] a = new int[2];
            a[1] = x % 10;
            while (x / 10 > 0)
                x /= 10;
            a[0] = x;
            return a;
        }
        //שאלה 7 סעיף ב
        public static void ModifyByX(Node<int> ls, int x) // פעולה מקבלת מספר ורשימה ומוציאה מהרשימה כל חוליה שאחת מספרות הקיצון בה הם המספר שהפעולה מקבלת
        {
            ls = new Node<int>(-1, ls);
            Node<int> p = ls;
            int x1 = x;
            int[] x_edge = GetSides(x);
            int[] arr = new int[2];
            int length = 0;
            bool deleted = false;
            while (p.GetNext().HasNext())
            {
                arr = GetSides(p.GetNext().GetValue());
                if (x_edge[0] == arr[0] && x_edge[1] == arr[1])
                {
                    Node<int> pos = p.GetNext();
                    p.SetNext(pos.GetNext());
                    pos.SetNext(null);
                    deleted = true;
                }
                p = p.GetNext();
                length++;
            }

            Node<int> prev = ls;
            ls = ls.GetNext();
            prev.SetNext(null);

            p = ls;

            if (!deleted)
            {
                for (int i = 0; i < length / 2; i++)
                    p = p.GetNext();

                p.SetNext(new Node<int>(x1, p.GetNext()));
            }
        }

        // שאלה 8 סעיף ד
        public static bool F1(Device[] arr, string pwd) // מנסה להפעיל את המזגנים במערך עם סיסמה ל5 ותחזיר אמת אם הצליחה להדליק אחד מהם ושקר אם אחרת
        {
            bool turn = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (((AC)arr[i]).SwitchOn(pwd, 5))
                    turn = true;
            }
            return turn;
        }

        public static bool F2(Device[] arr, string pwd) //  מנסה לכבות את מכשירי החשמל ותחזיר אמת אם הצליחה להדליק אחד מהם ושקר אם אחרת
        {
            bool turn = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].SwitchOff(pwd))
                    turn = true;
            }
            return turn;
        }

        static void Main(string[] args)
        {
            //שאלה 6
            int[] A = { 1, 52, 8 };
            Queue<int> Q = new Queue<int>();
            int T = What(A, Q);
            Console.WriteLine(T);
            
            //שאלה 7
            int x = 1234;
            int[] arrr = GetSides(x);
            Console.ReadLine();

            //שאלה 9
            Sara[] arr = new Sara[5];
            arr[0] = new Bibi(-4);
            arr[1] = new Sara(10);
            arr[2] = new Bibi();
            arr[3] = arr[0].GetWho(arr[1]); // המרה למעלה
            arr[4] = arr[2].GetWho(arr[3]);
            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i].GetNum()); // המרה למעלה
        }
    }
}