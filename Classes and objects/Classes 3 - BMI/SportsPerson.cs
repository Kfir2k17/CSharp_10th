using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    internal class SportsPerson
    {
        public string name;
        public int birth_year;
        public int profession;
        public int tournaments;
    
        public SportsPerson(string name, int birth_year, int profession, int tournaments)
        {
            this.name = name;
            this.birth_year = birth_year;
            this.profession = profession;
            this.tournaments = tournaments;
        }

        public string GetName()
        {
             return name;
        }

        public int GetBirthYear()
        {
            return birth_year;
        }

        public int GetProfession()
        {
            return profession;
        }

        public int GetTournaments()
        {
            return tournaments;
        }

        public string WhatType()
        {
            if (profession == 1)
                return "personal sport";

            if (profession == 2)
                return "team sport";

            if (profession == 3)
                return "personal and team sport";

            return "error";
        }

        public override string ToString()
        {
            return "name: " + name + ", birth year: " + birth_year + ", profession: " + this.WhatType() + ", Tournaments number: " + tournaments;
        }

        public void AddTournament()
        {
            tournaments++;
        }

        public int GetAge(int this_year)
        {
            return this_year - birth_year;
        }

        public bool IsParticipated(int n)
        {
            if (tournaments >= n)
                return true;
            
            return false;
        }
    }
}
