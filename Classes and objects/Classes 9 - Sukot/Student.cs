using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_9___Sukot
{
    internal class Student
    {
        private ZoomStudent kindzoom;
        private string name;
        private Date bday;
        private int[] grades;
        private int grade_count;

        public Student(ZoomStudent kindzoom, string name, Date bday)
        {
            this.kindzoom = kindzoom;
            this.name = name;
            this.bday = bday;
            this.grades = new int[20] ;
            this.grade_count = 0;
        }

        public void UpdateKind(int miccam)
        {
            if (miccam == 1)
                kindzoom.ChangeMice();

            if (miccam == 2)
                kindzoom.ChangeCam();
        }

        public string GetKind()
        {
            return kindzoom.GetKind();
        }

        public void AddGrade(int grade) 
        {
            grades[grade_count] = grade;
            grade_count++;
        }

        public double Avg()
        {
            int sum = 0;
            for (int i = 0; i < grade_count; i++)
                sum += grades[i];

            return sum / grade_count;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            string gradess = null;
            for (int i = 0; i < grade_count; i++)
            {
                gradess += grades[i] + ", ";
            }
                
            return "Student's name: " + name + ", Kind: " + kindzoom.GetKind() + ", Grades: " + gradess + ", Average: " + Avg();
        }
    }
}
