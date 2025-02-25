using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tirgul_matconet
{
    class Program
    {
        static void Main(string[] args)
        {
            Kickbox kb1 = new Kickbox("Neli");
            Kickbox kb2 = new Kickbox("Yoav");
            kb1.Add(3);
            kb1.Move(kb2);
            kb1.Move(kb2);
            kb1.Add(2);
        }
    }
}