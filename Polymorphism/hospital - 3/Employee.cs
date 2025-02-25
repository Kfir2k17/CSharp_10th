using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital___3
{
    class Employee
    {
        protected int num;
        protected string name;

        public Employee(int num, string name)
        {
            this.num = num;
            this.name = name;
        }

        public string GetName() { return name; }
    }
}
