using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Reservation
    {
        private string name;
        private string end_destination;
        private double basic_cost;
        private Flight[] outbound;
        private int actual_outbound;
        private Flight[] returnf;
        private int actual_return;

        public Reservation(string name, string end_destination, double basic_cost)
        {
            this.name = name;
            this.end_destination = end_destination;
            this.basic_cost = basic_cost;
            this.outbound = new Flight[5];
            this.actual_outbound = 0;
            this.returnf = new Flight[5];
            this.actual_return = 0;
        }

        public void AddOutbond(Flight x)
        {
            outbound[actual_outbound] = x;
            actual_outbound++;
        }

        public void AddReturnflight(Flight x)
        {
            returnf[actual_return] = x;
            actual_return++;
        }

        public double GetPrice() 
        {
            return basic_cost - (0.06 * basic_cost) * (actual_outbound -1) - (0.04 * basic_cost) * (actual_return - 1);
        }

        public bool IsReturnRoutine()
        {
            if (actual_return != actual_outbound) 
               return false;

            for (int i = 0; i < actual_outbound; i++) 
            {
                if (returnf[i].IsReturnFlight(outbound[i]) != true)
                    return false;
            }
            
            return true;
        }
    }
}
