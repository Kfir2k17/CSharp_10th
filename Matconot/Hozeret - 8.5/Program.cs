using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hozeret___8._5
{
    internal class Program
    {
        //שאלה 1
        public static bool IsIndexSort(int[] A, int[] B) // פעולה בוליאנית המקבלת שני מערכים ובודקת האם מתקבלת סדרה עולה של ערכים
        {
            for (int i = 0; i < B.Length - 1; i++)
            {
                if (A[B[i]] > A[B[i+1]])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
