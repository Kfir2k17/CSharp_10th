using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hospital___3
{
    class Supervisor : Doctor
    {
        private int max_workers;
        private Employee[] employees;
        private int employee_num;

        public Supervisor(int max_workers, string specialization, string situation, int num, string name) : base(specialization, situation, num, name)
        {
            this.max_workers = max_workers;
            this.employees = new Employee[max_workers];
            this.employee_num = 0;
        }

        public void AddEmployee(Employee employee)
        {
            if (employee_num != employees.Length)
            {
                this.employees[employee_num] = employee;
                this.employee_num++;
            }
        }

        public int AuthorisedAcademicNurseNum()
        {
            int counter = 0;
            for (int i = 0; i <  this.employees.Length; i++)
            {
                if (employees[i] is Nurse && ((Nurse)employees[i]).IsAcademic() && ((Nurse)employees[i]).GetNurseType() == "qualified")
                    counter++;
            }
            return counter; 
        }
    }
}
