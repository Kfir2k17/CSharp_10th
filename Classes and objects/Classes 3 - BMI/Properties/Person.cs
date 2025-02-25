using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3.Properties
{
    internal class Person
    {
        private string id;
        private char gender;
        private double weight;
        private double height;
        private int age;

        public Person(string id, char gender, double weight, double height, int age)
        {
            this.id = id;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
            this.age = age;
        }

        public double GetBMI()
        {
            return weight / Math.Pow(height, 2);
        }

        public double GetRecommendedCalorieIntake()
        {
            if (gender == 'm')
                return 1.5 * (66.5 + (13.75 * weight) + (5.003 * height) + (6.775 * age));
            return 1.5 * (65.5 + (9.563 * weight) + (1.85 * height) + (4.676 * age));
        }

        public bool IsObese() 
        {
            double bmi = GetBMI();

            return bmi >= 35;
        }

        public void CopyInfo(Person copyfrom) 
        {
            this.id = copyfrom.id;
            this.gender = copyfrom.gender;
            this.weight = copyfrom.weight;
            this.height = copyfrom.height;
            this.age = copyfrom.age;
        }

        public string GetID() { return id; }
        public char GetGender() { return gender; }
        public double GetWeight() { return weight; }
        public double GetHeight() { return height; }
        public double GetAge() { return age; }        
    }
}
