using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkMada2024
{
    class Holiday
    {
        private string name;
        private int days;

        //Get
        public string GetName() { return name; }
        public int GetDays() { return days; }

        //Set
        public void SetName(string name) { this.name = name;}
        public void SetDays(int days) {  this.days = days;}
    }
}
