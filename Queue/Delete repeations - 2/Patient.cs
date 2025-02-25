using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delete_repeations___2
{
    internal class Patient
    {
        private string name; //שם החולה
        private string blood; //סוג הדם
        private int emergency; //רמת דחיפות (לניתוח)
        
        public Patient(string n, string blood, int emergency)
        {
            this.name = n;
            this.blood = blood;
            this.emergency = emergency;
        }

        //Get
        public string GetName() { return name; }
        public string GetBlood() {  return blood; }
        public int GetEmergency() {  return emergency; }

        //Set
        public void SetName(string n) {  name = n; }
        public void SetBlood(string n) {  blood = n; }
        public void SetEmergency(int n) {  emergency = n; }
    }
}
