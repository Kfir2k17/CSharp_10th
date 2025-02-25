using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Hozeret___8._5
{
    public class Book
    {
        private string name; // שם
        private int shelf; // מדף
        private bool interesting; // מעניין

        //Get
        public string GetName() { return name; }
        public int GetShelf() {  return shelf; }
        public bool IsInteresting() { return interesting; }
    }

    public class Library
    {
        private Book[] arr; // מערך ספרים

        public bool PopularShelf(int x) // פעולה המקבלת מספר ומחזירה אמת על המדף שמספרו איקס כמות הספרים המעניינים גדולה על הלא מעניינים
        {
            int[] interesting_or_not = new int[2];
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i].IsInteresting())
                    interesting_or_not[0]++;
                else
                    interesting_or_not[1]++;
            }
            return interesting_or_not[0] > interesting_or_not[1];
        }

        public int MaxShelf() // מחזירה את המדף עם הכי הרבה ספרים
        {
            int[] amount = new int[100];

            for (int i = 0; i < arr.Length; i++)
                amount[arr[i].GetShelf() - 1]++;

            int max_shelf = amount[0];
            int max_place = 0;

            for (int i = 0; i < amount.Length; i++)
            {
                if (max_shelf < amount[i])
                {
                    max_shelf = amount[i];
                    max_place = i;
                }
            }
            return max_place - 1;
        }
    }
}
