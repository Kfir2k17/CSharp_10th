using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Classes___9
{
    internal class Program
    {
        public static int HowManyFlightsToDestination(Node<Flight> list, string place)//פעולה המקבלת כפרמטר רשימה של טיסות ויעד, ובודקת כמה טיסות מיועדות לשם
        {
            int counter = 0;
            Node<Flight> p = list;
            while (p != null)
            {
                if (p.GetValue().GetDestination() == place)
                    counter++;
                p = p.GetNext();
            }
            return counter;
        }

        public static void ChangeOriginFromIsrael(Node<Flight> list)//פעולה המקבלת רשימה של טיסות ומשנה את המוצא של הטיסות מישראל מתל אביב ללרנקה
        {
            Node<Flight> p = list;
            while (p != null)
            {
                if (p.GetValue().GetOrigin() == "TLV")
                    p.SetValue(new Flight("LCA", p.GetValue().GetDestination()));

                p = p.GetNext();
            }
        }

        public static bool AreTwoOpposite(Node<Flight> list)//פעולה המקבלת רשימה של טיסות ובודקת האם קיים בה זוג של טיסות הפוכות
        {
            Node<Flight> p1 = list;
            while (p1 != null)
            {
                Node<Flight> p2 = p1.GetNext();
                while (p2 != null)
                {
                    if (p1.GetValue().GetOrigin() == p2.GetValue().GetDestination() && p1.GetValue().GetDestination() == p2.GetValue().GetOrigin())
                        return true;
                }
                p1 = p1.GetNext();
            }
            return false;
        }

        static void Main(string[] args)
        {

        }
    }
}
