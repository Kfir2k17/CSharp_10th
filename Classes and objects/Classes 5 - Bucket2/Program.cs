using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.BucketLib;

namespace Classes_5___Bucket2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Unit4.BucketLib.Bucket b1 = new Unit4.BucketLib.Bucket(120, "buck22");
            Unit4.BucketLib.Bucket b2 = new Unit4.BucketLib.Bucket(120, "buck22");
            
            b1.Fill(30);
            b1.PourInto(b2);
            //Bucket b1 = new Bucket(120);
        }
    }
}
