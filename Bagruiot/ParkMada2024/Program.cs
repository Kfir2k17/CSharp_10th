using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParkMada2024
{
    internal class Program
    {
        //שאלה 1
        public static string LongestHoliday(Holiday[] arr) // פעולה המקבלת מערך חגים ומחזירה את שם החג הכי ארוך
        {
            Holiday longest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (longest.GetDays() == arr[i].GetDays())
                    longest = arr[i];
            }
            return longest.GetName();
        }

        //שאלה 2
        public static void SpecialOffer(Robot[] arr) // סעיף ד, פעולה המעדכנת את מחירי הרובוטים בהתאם למבצע
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i].SetPrice(arr[i].GetPrice() - 200);
        }

        //

        static void Main(string[] args)
        {
            Robot[] arr =
            {
                new Robot("Ruby", true, 2017, 1500),
                new Robot(Console.ReadLine(), bool.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())),
                new Robot(Console.ReadLine(), bool.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()))
            };
        }
    }
}
