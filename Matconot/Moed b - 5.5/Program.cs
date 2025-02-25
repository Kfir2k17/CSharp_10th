using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Moed_b___5._5
{
    internal class Program
    {
        //שאלה 1
        public static bool IsValid(int[] arr) // סעיף א, מקבלת מערך בחירות רקדנים ומחזירה אמת אם הוא חוקי
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 || arr[i] > 19 || arr[i] == i)
                    return false;
            }
            return true;
        }
        public static void ShowMatch(int[] arr)// סעיף ב, מקבלת מערך חוקי ומחזירה ומדפיסה את כל הזיווגים
        {
            for (int i = 0; i < arr.Length; i++)
                if (i == arr[arr[i]] && i < arr[i])
                    Console.WriteLine("Match: 1st " + arr[i] + " 2nd " + i);
        }


        //שאלה 4
        public static Node<Node<string>> BreakRooms(Node<string> names, int maxInRoom) // פעולה שמקבלת רשימה של שמות ומספר ילדים בחדר ומחזירה שרשרת החדרים
        {
            Node<string> p_names = names; // pointer to names
            Node<Node<string>> roomList = new Node<Node<string>>(new Node<string>(""));
            Node<Node<string>> room_p = roomList;

            while (p_names != null)
            {
                Node<string> room = new Node<string>(p_names.GetValue());
                Node<string> p = room;
                for (int i = 0; i < maxInRoom || p_names != null; i++)
                {
                    p_names = p_names.GetNext();
                    p.SetNext(new Node<string> (p_names.GetValue()));
                    p = p.GetNext();
                }
                room_p.SetNext(new Node<Node<string>>(room));
                room_p = room_p.GetNext();
            }
            roomList = roomList.GetNext();
            return roomList;
        }

        //שאלה 6
        public static void Holiday(Node<string> list) // פעולה שמקבלת תור עם שמות של חיילים ומדפיסה את שמות 2 החיילים שנשארו
        {
            Node<string> p = list;
            int len = 1;
            while (p != null)
            {
                p = p.GetNext();
                len++;
            }
            p.SetNext(list);

            Random rnd = new Random();
            int num = rnd.Next(len - 1);
            p = list;

            int counter = 0;
            while (list.GetNext().GetNext() != list)
            {
                while (counter < num)
                {
                    p = p.GetNext();
                    counter++;
                }

                Node<string> temp = p.GetNext();
                p.SetNext(temp.GetNext());
                temp.SetNext(null);

                len--;
                num = rnd.Next(len - 1);
                p = list;
            }

            Console.WriteLine("The remaining soliders are: " + list.GetValue(), list.GetNext().GetValue());
        }

        //שאלה 7
        public static Queue<Block> BlockQueue(Queue<int> q) // פעולה המקבלת תור של מספרים, מוחקת את האפסים ומחזירה תור של בלוק על בסיס התור המקורי
        {
            Queue<Block> q_block = new Queue<Block>();
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                int x = q.Remove();
                if (x != 0)
                {
                    int len = 1;
                    int min = x;
                    bool even = IsEven(x);
                    temp.Insert(x);

                    while (IsEven(q.Head()) == even)
                    {
                        int y = q.Remove();
                        len++;
                        if (min > y)
                            min = y;
                        temp.Insert(y);
                    }

                    Block b = new Block(len, x, IsEven(x));
                    q_block.Insert(b);
                }
            }
            while (!temp.IsEmpty())
                q.Insert(temp.Remove());
            return q_block;
        }

        public static bool IsEven(int num) { return num % 2 == 0; } // פעולת עזר שמחזירה אם המספר זוגי או לא
        static void Main(string[] args)
        {
        }
    }
}
