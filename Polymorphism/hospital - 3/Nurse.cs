using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital___3
{
    class Nurse : Employee
    {
        private string type;
        private bool academic;

        public Nurse(string type, bool academic, int num, string name) : base(num, name)
        {
            this.type = type;
            this.academic = academic;
        }

        public string GetNurseType() { return type; }
        public bool IsAcademic() { return academic; }
    }
}
