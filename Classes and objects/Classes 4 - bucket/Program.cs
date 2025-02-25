using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.BucketLib;

namespace Classes_4___bucket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bucket[] arr = new Bucket[6];
            double fill = 60;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Bucket(60, "dlido "+(i+1));
                arr[i].Fill(fill);
                fill /= 2;
            }
        }
    }
}
