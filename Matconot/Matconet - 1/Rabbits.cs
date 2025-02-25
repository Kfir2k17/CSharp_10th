using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Matconet___1
{
    class RabbitFamily
    {
        private string family; // שם המשפחה
        private int offspring; // מספר צאצאים

        public RabbitFamily(string family, int offspring) // פעולה בונה
        {
            this.family = family;
            this.offspring = offspring;
        }

        //Get
        public string GetFamily() { return family; }
        public int GetOffspring() { return offspring; }

        //Set
        public void SetFamily(string family) { this.family = family; }
        public void SetOffspring(int offspring) { this.offspring = offspring; }

        public bool AtLeast8()
        {
            return this.offspring >= 8;
        }
    }

    class RabbitVillage
    {
        private string name; // שם הכפר
        private int count; // מספר המשפחות המתגוררות בכפר
        private RabbitFamily[] families; // מערך של משפחות ארנבים

        public RabbitVillage(string name) // פעולה בונה
        {
            this.name = name;
            count = 0;
            families = new RabbitFamily[100];
        }

        //Get
        public string GetName() { return name; }
        public int GetCount() { return count; }
        public RabbitFamily[] GetFamilies() {  return families; }

        //Set
        public void SetName(string  name) { this.name = name; }
        public void SetCount(int count) { this.count = count; }
        public void SetFamilies(RabbitFamily[] families) { this.families =  families; }

        public void AddFamily(RabbitFamily rf) // פעולה המקבלת משפחת ארנבים ומוסיפה למערך
        {
            if (count >= 100)
                Console.WriteLine("There is no space left.");

            else
            {
                families[count] = rf;
                count++;
            }
        }

        public int BigF() // פעולה המחזירה את כמות המשפחות עם מעל ל-8 ילדים
        {
            int counter = 0;
            for (int i = 0; i < count; i++)
            {
                if (families[i].AtLeast8())
                    counter++;
            }
            return counter;
        }
    }
}
