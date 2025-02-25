using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LonaPark___4
{
    class Ride : Attraction
    {
        private int fearLevel; // דירוג רמת הפחד
        private int minHeight; // גובה מינימאלי מותר למבקר

        public Ride(int fearLevel, int minHeight, string name, int maxNum, int minAge) : base(name, maxNum, minAge)
        {
            this.fearLevel = fearLevel;
            this.minHeight = minHeight;
        }
        //Set
        public void SetFearLevel(int fearLevel) { this.fearLevel = fearLevel; }
        public void SetMinHeight(int minHeight) { this.minHeight = minHeight; }

        //Get
        public int GetfearLevel() { return this.fearLevel; }
        public int IsMinHeight() { return this.minHeight; }
    }
}
