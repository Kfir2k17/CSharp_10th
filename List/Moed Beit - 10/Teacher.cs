using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Teacher
    {
        private string name;  //שם המורה
        private string subject;  // שם המקצוע
        private string replace;  //שם המורה המחליף
        private int age;  // גיל המורה

        public Teacher(string n, string sub, string rep, int a)//פעולה בונה
        {
            this.name = n;
            this.subject = sub;
            this.replace = rep;
            this.age = a;
        }
        
        //Get
        public string GetName() { return name; }
        public string GetSubject() { return subject; }
        public string GetReplace() { return replace; }
        public int GetAge() { return age; }

        //Set
        public void SetName(string name) { this.name = name; }
        public void SetSubject(string subject) { this.subject = subject; }
        public void SetReplace(string replace) { this.replace = replace; }
        public void SetAge(int age) { this.age = age; }
    }
}