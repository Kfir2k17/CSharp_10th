using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital___3
{
    internal class Program
    {
        public static void PrintSuperVisors(Employee[] employees)
        {
            for (int i = 0;  i < employees.Length; i++) 
            {
                if (employees[i] is Supervisor)
                    Console.WriteLine(employees[i].GetName());
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
