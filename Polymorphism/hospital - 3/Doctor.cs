using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital___3
{
    class Doctor : Employee
    {
        protected string specialization;
        protected string situation;

        public Doctor (string specialization, string situation, int num, string name) : base(num, name )
        {
            this.specialization = specialization;
            this.situation = situation;
        }
    }
}
