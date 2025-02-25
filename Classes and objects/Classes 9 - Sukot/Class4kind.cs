using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_9___Sukot
{
    internal class Class4kind
    {
        private Student[] students;
        private int counter;

        public Class4kind()
        {
            students = new Student[35];
            counter = 0;
        }

        public string CommonKind()
        {
            int etrog = 0;
            int lulav = 0;
            int hadas = 0;
            int arava = 0;

            for (int i = 0; i < counter; i++)
            {
                if (students[i].GetKind() == "etrog")
                    etrog++;
                if (students[i].GetKind() == "lulav")
                    lulav++;
                if (students[i].GetKind() == "hadas")
                    hadas++;
                if (students[i].GetKind() == "arava")
                    arava++;
            }

            int max = 0;
            string max_type = "null";

            if (etrog > max)
            {
                max = etrog;
                max_type = "etrog";
            }

            if (lulav > max)
            {
                max = lulav;
                max_type = "lulav";
            }

            if (hadas > max)
            {
                max = hadas;
                max_type = "hadas";
            }

            if (arava > max)
            {
                max = arava;
                max_type = "arava";
            }

            return max_type;
        }

        public void AddStudent(Student student)
        {
            if (counter > 35)
            {
                students[counter] = student;
                counter++;
            }

            else
                Console.WriteLine("no place");
        }

        public void ExSt()
        {
            for (int i = 0; i < counter; i++)
            {
                if (students[i].GetKind() == "etrog" && students[i].Avg() >= 85)
                    Console.WriteLine(students[i].GetName());
            }
        }

        public void RemoveStudent(int n)
        {
            students[n] = null;
        }
    }
}
