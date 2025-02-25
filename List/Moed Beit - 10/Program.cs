using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        public static bool IsGrowingSeq(Node<double> list) //בודקת אם הרשימה היא רשימת רצפים הולכת וגדלה, סיבוכיות של O(n)
        {
            Node<double> p = list;
            int should = 1;
            
            while (p.GetValue() == p.GetNext().GetValue())
            {
                should++;
                p = p.GetNext();
            }

            int current = 0;

            while (p.HasNext())
            {
                p = p.GetNext();
                if (p.GetValue() != p.GetNext().GetValue())
                {
                    if (should != current)
                        return false;
                    current = 0;
                    should++;
                }
                current++;
            }

            if (should != current)
                return false;

            return true;
        }

        public static bool IsDecreasingSeq(int[] arr) //פעולת מעטפת
        {
            return IsDecreasingSeq(arr, arr[0] - arr[1], 1);    
        }

        public static bool IsDecreasingSeq(int[] arr, int def, int place)//פעולה רקורסיבית הבודקת האם הרשימה היא סדרה חשבונית יורדת
        {
            if (place == arr.Length)
                return true;

            if (arr[place] - arr[place + 1] != def)
                return false;

            return IsDecreasingSeq(arr, def, place + 1);
        }
        
        public static

        static void Main(string[] args)
        {
        }
    }
}
