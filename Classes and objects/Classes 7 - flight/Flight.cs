using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Flight
    {
        private string origin;
        private string destination;

        public Flight(string origin, string destination)
        {
            this.origin = origin;
            this.destination = destination;
        }

        public string GetOrigin()
        {
            return origin;
        }

        public string GetDestination()
        {
            return destination;
        }

        public bool IsReturnFlight(Flight flight)
        {
            return this.origin == flight.destination && this.destination == flight.origin;
        }
    }
}
