using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace introduction___1
{
    internal class ZooGarden
    {
        private string zooName;
        private Animal[] animalList;
        private int animalCounter;

        public ZooGarden(string zooName)//פעולה בונה
        {
            this.zooName = zooName;
            this.animalList = new Animal[2000];
            this.animalCounter = 0;
        }

        public void AddAnimal(Animal animal)//פעולה המקבלת חיה ומוסיפה אותה לגן החיות
        {
            if (animalCounter < 2000)
            {
                this.animalList[animalCounter] = animal;
                this.animalCounter++;
            }
        }

        public bool IsThereAnimal(string name)//פעולה שמקבלת שם חיה ומחזירה אמת אם קיימת בגן החיות או לא
        {
            for (int i = 0; i < animalCounter; i++)
            {
                if (animalList[i].GetName() == name)
                    return true;
            }
            return false;
        }

        public string AreMoreSnakesOrMonkeys()
        {
            int snakes = 0;
            int monkeys = 0;

            for (int i = 0; i < animalCounter; i++)
            {
                if (animalList[i] is Monkey)
                    monkeys++;

                if (animalList[i] is Snake)
                    snakes++;
            }

            if (snakes > monkeys)
                return "Snakes";

            return "Monkeys";
        }
    }
}
