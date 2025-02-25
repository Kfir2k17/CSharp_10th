using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduction___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Descartes", 2, 200);
            Mammal mammal = new Mammal("Plato", 13, 500, 50);
            Monkey monkey = new Monkey("Omer", -4, 200, 10000);

            monkey.SetBanana(5); //הבעיה שנוצרה היא שבמחלקות האחרות לא קיים עצם של בננות

            ZooGarden ohelZoo = new ZooGarden("Ohel-Zoo");
            ohelZoo.AddAnimal(animal);
            ohelZoo.AddAnimal(mammal);
            ohelZoo.AddAnimal(monkey);
            ohelZoo.AddAnimal(new Snake("Eli", 1, 1000, 8, true));
            ohelZoo.AddAnimal(new Cow("Hodaya", 1000, 2000, 100, 7));

            Console.WriteLine(ohelZoo.IsThereAnimal("Eli"));

            Console.ReadLine(); 
        }
    }
}
