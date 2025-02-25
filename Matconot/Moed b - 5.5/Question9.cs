using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moed_b___5._5
{
    class Car
    {
        private string type; // סוג רכב
        private double price; // מחיר לשיעור
        private int min; // מינימום שיעורים לטסט

        //Get
        public string Gettype() { return type; }
        public double GetPrice() { return price; }
        public int GetMin() { return min; }

        //Set
        public void SetType(string type) { this.type = type; }
        public void SetPrice(double price) { this.price = price; }
        public void SetMin(int min) { this.min = min; }
    }

    class School
    {
        private Person[] persons; // מערך של כלל המורים והתלמידים בבית ספר
        private int count; // מונה של הכמות הנוכחית של מורים ותלמידים

        public School(int maxTeachers, int maxStudents) // פעולה בונה
        {
            this.persons = new Person[maxTeachers + maxStudents];
            this.count = 0;
        }

        public void NoTestCost() // םעולה שמדפיסה עבור כל הילדים שאינם יכולים לגשת לטסט את העלות
        {
            for (int i = 0; i < count; i++)
            {
                if (persons[i] is Student && !((Student)persons[i]).CanGoToTest())
                    Console.WriteLine("Name: " + persons[i].GetName() + ", Cost: " + ((Student)persons[i]).GetCost());
            }
        }

        public int TenPlusSeniority() // פעולה שמחזירה את כמות המורים עם ותק של מעל ל-10 שנים
        {
            int counter = 0;
            for (int i = 0; i < count; i++) 
            {
                if (persons[i] is Teacher && ((Teacher)persons[i]).GetSeniority() > 10)
                    counter++;
            }
            return counter;
        }
    }


    class Person
    {
        private string name; //שם
        private int phone_num; // מספר טלפון
        protected Car car; // רכב עליו לומד/מלמד

        public Person(string name, int phone_num, Car car) // פעולה בונה
        {
            this.name = name;
            this.phone_num = phone_num;
            this.car = car;
        }

        //Get
        public string GetName() { return name; }
        public int GetPhone() { return phone_num; }
        public Car GetCar() { return car; }

        //Set
        public void SetName(string name) { this.name = name; }
        public void SetPhone(int phone_num) { this.phone_num = phone_num; }
        public void SetCar(Car car) { this.car = car; }
    }

    class Student : Person
    {
        private int lessons; // שיעורים שלקח עד כה
        private Teacher teacher; // המורה אצלו הוא לומד

        public Student(string name, int num, Car car, Teacher teacher) : base(name, num, car) // פעולה בונה
        {
            this.teacher = teacher;
            this.lessons = 0;
        }

        public bool CanGoToTest()
        {
            return this.lessons >= this.car.GetMin();
        }

        public double GetCost() //מחזירה את העלות המינימלית של השיעורים שנותרו עד לטסט
        {
            return (this.car.GetMin() - this.lessons) * this.car.GetPrice();
        }
    }

    class Teacher : Person
    {
        private int seniority;
        public Teacher(string name, int num, Car car, int seniority) : base(name, num, car) // פעולה בונה
        {
            this.seniority = seniority;
        }

        //Get And Set
        public int GetSeniority() { return this.seniority; }
        public void SetSeniority(int seniority) { this.seniority = seniority; }
    }
}
