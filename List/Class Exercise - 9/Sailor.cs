using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Classes___9
{
    class Sailor
    {
        private int id;//מספר הזהות של השייט
        private string name;//מחרוזת של שם השייט
        private string club;//מחרוזת של שם המועדון

        private Sailor(int id, string name, string club)//פעולה בונה
        {
            this.id = id;
            this.name = name;
            this.club = club;
        }

        //Get
        public int getId() { return id; }
        public string getName() { return name; }
        public string getClub() { return club; }

        //Set
        public void setId(int id) { this.id = id; }
        public void setName(string name) { this.name = name; }
        public void setClub(string club) { this.club = club; }
    }
}
