using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Classes___9
{
    class Trip
    {
        private int tripid;//מספר הזהות של הטיול
        private int registered; //כמות הרשומים
        private int minReg; //מינימום רשומים

        public Trip(int tripid, int registered, int minReg)//פעולה בונה
        {
            this.tripid = tripid;
            this.registered = registered;
            this.minReg = minReg;
        }

        //Get
        public int getTripid() { return tripid; }
        public int getRegistered() { return registered; }
        public int getMinReg() { return minReg; }

        public bool Enough()//הפעולה בודקת האם ישנם מספר רשומים לטיול
        {
            return registered >= minReg;
        }
    }
}
