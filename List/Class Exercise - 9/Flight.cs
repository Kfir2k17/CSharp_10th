using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Classes___9
{
    class Flight
    {
        private string origin; // מחרוזת של מוצא
        private string destination; //מחרוזת של יעד
        public Flight(string origin, string destination)
        {
            this.origin = origin;
            this.destination = destination;
        }
        //Get
        public string GetOrigin()
        {
            return this.origin;
        }
        public string GetDestination()
        {
            return this.destination;
        }

        //פעולה המחזירה אמת אם הטיסה שהתקבלה הפוכה לטיסה הנוכחית ושקר אם לא
        public bool IsReturnFlight(Flight fl)
        {
            return this.origin == fl.destination && this.destination == fl.origin;
        }
    }
}
