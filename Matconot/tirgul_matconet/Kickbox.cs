using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tirgul_matconet
{
    class Kickbox
    {
        private int capacity;   //  תפוסת משתתפים מקסימאלית
        private int numP;  //  מספר משתתפים בפועל
        private string name;    //  שם המאמן
        private Node<string> participants;  //  רשימת שמות המשתתפים בפועל בשיעור

        //Get
        public int GetCapacity() { return this.capacity; }
        public int GetNumP() { return this.numP; }
        public string GetName() { return this.name; }
        public Node<string> GetParticipants() { return this.participants;}

        //Set
        public void SetCapacity(int capacity) { this.capacity = capacity; }
        public void SetNumP(int numP) { this.numP = numP; }
        public void SetName(string name) { this.name = name; }
        public void SetParticpants(Node<string> participants) { this.participants = participants; }

        public Kickbox(string name)//פעולה בונה
        {
            this.capacity = 15;
            this.numP = 0;
            this.name = name;
            this.participants = null;
        }

        public void Move(Kickbox kb)//פעולה המטפלת בהעברת משתתפים מהקבוצה הנוכחית לקבוצה שהיא מקבלת כפרמטר
        {
            if (kb.capacity <= kb.numP)
                Console.WriteLine("השיעור מלא");

            else
            {
                Node<string> this_before_last = this.participants;
                while (this_before_last.GetNext().HasNext())
                    this_before_last = this_before_last.GetNext();
                Node<string> this_last = this_before_last.GetNext();

                this_before_last.SetNext(null);
                this_last.SetNext(null);

                if (kb.participants != null)
                {
                    Node<string> kb_last = this.participants;
                    while (kb_last.HasNext())
                        kb_last = kb_last.GetNext();
                    
                    kb_last.SetNext(this_last);
                }

                else
                    kb.participants = this_last;

                kb.numP++;
                this.numP--;
                Console.WriteLine("ההעברה בוצעה");
            }
        }

        public void Add(int num)
        {
            Node<string> last = this.participants;
            while (last.HasNext())
                last = last.GetNext();

            string[] names = new string[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Person number {1}, what is your name?", i+1);
                names[i] = Console.ReadLine();
            }

            int counter = 0;
            while (counter < num || this.numP <= this.capacity)
            {
                last = new Node<string>(names[counter], last);
                counter++;
                this.numP++;
            }

            if (counter < names.Length - 1)
            {
                while (counter < name.Length)
                {
                    Console.WriteLine("Sorry " + names[counter]);
                    counter++;
                }
            }
        }
        public override string ToString()
        {
            Node<string> p = this.participants;
            string parti = p.GetValue();
            p = p.GetNext();
            while (p != null)
            {
                parti += ", " + p.GetValue();
                p = p.GetNext();
            }

            return "Trainer: " + name + " Number of Participants: " + numP + " Particpants: " + parti;
        }
    }
}
