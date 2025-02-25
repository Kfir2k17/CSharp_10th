using System;

namespace Aba
{
    internal class Program
    {
        public static int GoodChildren(object[] b)
        {
            int counter = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] is Child && ((Child)b[i]).IsGood())
                    counter++;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            object[] b =
                {
                new Child(12),
                new Child(-4),
                new Child(14),
                new Person(3, "John Fortnite"),
                new Person(5, "Nigger")
                };
            Console.WriteLine(GoodChildren(b));
            Console.ReadLine();
        }
        class Person
        {
            protected int z;
            protected static int year;
            public Person(double d, string s1, string s2) { }
            public Person(double d, string s) { }
            public int P() { return 3; }
            public virtual double Calculate(double d)
            {
                return d * 2;
            }
            public virtual void Print()
            {
                Console.WriteLine("Every person is born a good one");
            }

        }
        class Child : Person
        {
            private int y;
            public Child(string name, double x) : base(x, name) { this.y = 10; }

            public Child(int y) : base(6.5, "Nelson", "Mandela") { this.y = y; }

            private int Sum()
            {
                return this.y + this.z + this.P();
            }

            public int GetYear()
            {
                return Person.year;
            }
            public override double Calculate(double d)
            {
                return d * base.Calculate(5);
            }
            public bool IsGood() { return this.y > 0; }

            public override void Print()
            {
                base.Print();
                Console.WriteLine("Child");
            }
        }
    }
}