using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reservation res1 = new Reservation("Joe", "Mexico City", 300);
            Flight fl1 = new Flight("Tel Aviv", "Paris");
            res1.AddOutbond(fl1);

            double price = res1.GetPrice();
            bool sameroute = res1.IsReturnRoutine();
            
            

            //Israel Israeli
            Reservation israel = new Reservation("Israel Israeli", "London", 600);
            
            Flight out1 = new Flight("Tel Aviv", "Athens");
            israel.AddOutbond(out1);
            
            Flight out2 = new Flight("Athens", "London");
            israel.AddOutbond(out2);

            Flight return1 = new Flight("London", "Rome");
            israel.AddReturnflight(return1);

            Flight return2 = new Flight("Rome", "Tel Aviv");
            israel.AddReturnflight(return2);

            Console.WriteLine(israel.GetPrice());


            Console.ReadLine();
        }
    }
}
