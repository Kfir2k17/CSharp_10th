using Classes_3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    internal class Program
    {
        public static void Info(Person[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("\nPerson " + i + 1);
                Console.WriteLine("ID: " + people[i].GetID());
                Console.WriteLine("BMI: " + people[i].GetBMI());
                Console.WriteLine("Recommended Calorie Intake" + people[i].GetRecommendedCalorieIntake());
            }
        }

        public static Person[] OnlyWomen(Person[] people)
        {
            int amount = 0;
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].GetGender() == 'f')
                    amount++;
            }

            Person[] women = new Person[amount];

            int count = 0;

            for (int t = 0; t < people.Length; t++) 
            {
                if (people[t].GetGender() == 'f')
                {
                    women[count].CopyInfo(people[t]);
                    count++;
                }
            }
            return women;
        }
        static void Main(string[] args)
        {
            SportsPerson john = new SportsPerson("John", 1998, 1, 2);
            SportsPerson mike = new SportsPerson("Mike", 2004, 2, 4);
            SportsPerson ben = new SportsPerson("Ben", 1995, 3, 8);

            john.AddTournament();
            int mikes_age = mike.GetAge(2023);
            Console.WriteLine(ben.ToString());

            Console.ReadLine();
        }
    }
}
