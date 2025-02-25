using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction___1
{
    internal class Flamingo : Birds
    {
        private string color;

        public Flamingo(string name, int age, int cal, int eggs, string color) : base(name, age, cal, eggs)
        {
            this.color = color;
        }

        public string GetColor() { return color; }  
    }
}
