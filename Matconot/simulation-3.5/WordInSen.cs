using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulation_3._5
{
    internal class WordInSen
    {
        private string word;
        private int place;

        public WordInSen(string word, int place)
        {
            this.word = word;
            this.place = place;
        }

        //Get
        public string GetWord() { return word; }
        public int GetPlace() { return place; }

        //Set
        public void SetWord(string word) { this.word = word;}
        public void SetPlace(int place) {  this.place = place;}
    }
}
