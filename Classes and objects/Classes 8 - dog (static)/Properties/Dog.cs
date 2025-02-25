using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Classes_8___dog__static_.Properties
{
    internal class Dog
    {
        private string name;
        private int number = 1;
        private static int count = 0;
        private int age;
        private int child;

        public Dog(string name, int age, int child)
        {
            this.name = name;
            this.age = age;
            this.child = child;
            count++;
            this.number = count;
        }

        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.child = 0;
            count++;
            this.number = count;
        }

        public Dog(string name)
        {
            this.name = name;
            this.age = 0;
            this.child = 0;
            count++;
            this.number = count;
        }

        public Dog(Dog dog)
        {
            this.name = dog.name;
            this.age = dog.age;
            this.child = dog.child;
            count++; 
            this.number = count;
        }

        public void SetVoidName(string name)
        {
            this.name = name;
        }

        public string GetDogName()
        {
            return this.name;
        }

        public void Grow()
        {
            this.age++;
        }

        public int GetAge()
        {
            return this.age;
        }

        public override string ToString()
        {
            return "Name: " + name + " Number: " + number + " Age: " + age + " Number of children: " + child;
        }
    }
}
