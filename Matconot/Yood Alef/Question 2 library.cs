using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yood_Alef
{
    class Book
    {
        private string name;
        private int shelf;
        private bool interesting;

        //Get
        public string GetName() { return name; }
        public int GetShelf() { return shelf; }
        public bool Interesting() { return interesting; }
    }

    class Library
    {
        private Book[] arr;

        public bool PopularShelf(int x) // פעולה שמקבלת מספר ומחזירה אם על המדף כמות הספרים המעניינים גדולה מהלא מעניינים
        {
            int inter = 0, no_inter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetShelf() == x)
                {
                    if (arr[i].Interesting())
                        inter++;
                    else
                        no_inter++;
                }
            }
            return inter > no_inter;
        }

        public int MaxShelf() // מחזירה את מספר המדף עם הכי הרבה ספרים
        {
            int[] shelfs = new int[100];
            for (int i = 0; i < shelfs.Length; i++)
                shelfs[i] = 0;

            for (int i = 0; i < arr.Length; i++)
                shelfs[arr[i].GetShelf() - 1] = 0;

            int max = 1, max_value = 0;
            for (int i = 0; i < shelfs.Length; i++)
            {
                if (shelfs[i] > max_value)
                {
                    max_value = shelfs[i];
                    max = i - 1;
                }
            }
            return max;
        }
    }
}
