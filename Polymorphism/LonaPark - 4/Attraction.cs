using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonaPark___4
{
    class Attraction
    {
        private string name; // שם האטרקציה
        private int maxNum; // מספר מקסימלי של משתתפים
        private int minAge; // גיל מינימלי מותר למבקר

        public Attraction(string name, int maxNum, int minAge)
        {
            this.name = name;
            this.maxNum = maxNum;
            this.minAge = minAge;
        }

        //Get
        public string GetName() { return name; }
        public int GetMaxNum() { return maxNum; }
        public int GetMinAge() {  return minAge; }
        
        //Set
        public void SetMaxNum(int maxNum) { this.maxNum = maxNum; }
        public void SetName(string name) { this.name = name;}
        public void SetAge(int age) { this.minAge = age;}
    }
}
