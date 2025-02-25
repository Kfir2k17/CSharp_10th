using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Recoursion_Exercises___6
{
    internal class Program
    {
        //Exercise 1
        public static int GetBiggestNode(Node<int> list, int max)
        {
            if (list == null)
                return max;

            if (list.GetValue() > max)
                return GetBiggestNode(list.GetNext(), list.GetValue());

            return GetBiggestNode(list.GetNext(), max);
        }
        public static int GetBiggestNode(Node<int> list)
        {
            return GetBiggestNode(list, list.GetValue());
        }

        //Exercise 2
        public static Node<int> GetMinNode(Node<int> list, Node<int> min)
        {
            if (list == null)
                return min;

            if (list.GetValue() > min.GetValue())
                return GetMinNode(list.GetNext(), list);

            return GetMinNode(list.GetNext(), min);
        }
        public static Node<int> GetMinNode(Node<int> list)
        {
            return GetMinNode(list, list);
        }

        //Exercise 3
        public static int GetEvenSum(Node<int> list, int sum)
        {
            if (list == null)
                return sum;

            if (list.GetValue() / 2 == 0)
                return GetEvenSum(list.GetNext(), sum + list.GetValue());

            return GetEvenSum(list.GetNext(), sum);
        }

        public static int GetEvenSum(Node<int> list)
        {
            return GetEvenSum(list, 0);
        }

        //Exercise 4
        public static int GetOddPlaceSum(Node<int> list, int sum, int counter)
        {
            if (list == null)
                return sum;

            if (counter / 2 != 0)
                return GetOddPlaceSum(list.GetNext(), sum + list.GetValue(), counter + 1);

            return GetOddPlaceSum(list.GetNext(), sum, counter + 1);
        }

        public static int GetOddPlaceSum(Node<int> list)
        {
            return GetOddPlaceSum(list, 0, 0);
        }

        //Exercise 5
        public static int HowManyNumInList(Node<int> list, int num, int counter)
        {
            if (list == null)
                return counter;

            if (list.GetValue() == num)
                return HowManyNumInList(list.GetNext(), num, counter + 1);

            return HowManyNumInList(list.GetNext(), num, counter);
        }
        public static int HowManyNumInList(Node<int> list, int num)
        {
            return HowManyNumInList(list, num, 0);
        }

        //Exercise 6
        public static bool IsThereNum(Node<int> list, int num)
        {
            if (list == null)
                return false;

            if (list.GetValue() == num)
                return true;

            return IsThereNum(list.GetNext(), num);
        }

        //Exercise 7
        public static bool IsItSidra(Node<int> list, int dif)
        {
            if (list == null)
                return true;

            if (list.GetValue() - list.GetNext().GetValue() != dif)
                return false;

            return IsItSidra(list.GetNext(), dif);
        }

        public static bool IsItSidra(Node<int> list)
        {
            return IsItSidra(list, list.GetValue() - list.GetNext().GetValue());
        }

        //Exercise 8
        public static bool DoesDecrease(Node<int> list)
        {
            if (list.GetNext() == null)
                return true;

            if (list.GetValue() <= list.GetNext().GetValue())
                return false;

            return DoesDecrease(list.GetNext());
        }

        //Exercise 9
        public static Node<int> HowManyJunctions(Node<int> list, int steps, int counter)
        {
            if (counter == steps)
                return list;

            if (list == null)
                return null;

            return HowManyJunctions(list.GetNext(), steps, counter + 1);
        }

        public static Node<int> HowManyJunctions(Node<int> list, int steps)
        {
            return HowManyJunctions(list, steps, 0);
        }

        //Exercise 10
        public static Node<int> LastNode(Node<int> list)
        {
            if (list == null)
                return null;

            if (list.GetNext() == null)
                return list;

            return LastNode(list.GetNext());
        }

        //Exercise 11
        public static Node<int> GetNumNode(Node<int> list, int num)
        {
            if (list == null)
                return null;

            if (list.GetValue() == num)
                return list;

            return GetNumNode(list.GetNext(), num);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
