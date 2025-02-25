using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_and_object_arr___5
{
    internal class Program
    {
        public static Sequence[] TransferToArr(Node<int> list)
        {
            int counter = 0;
            Node<int> p = list;

            while (p != null)
            {
                if(p.GetValue() != p.GetNext().GetValue())
                    counter++;
            }

            Sequence[] arr = new Sequence[counter];
            p = list;

            int i = 0;

            while(p.GetNext() != null) 
            {
                if (p.GetValue() == p.GetNext().GetValue())
                {
                    arr[i].SetNum(p.GetValue());
                    arr[i].SetTimes(arr[i].GetTimes() + 1);
                }

                if (p.GetValue() != p.GetNext().GetValue())
                    i++;
            }
            
            return arr;
        }
        static void Main(string[] args)
        {
        }
    }
}
