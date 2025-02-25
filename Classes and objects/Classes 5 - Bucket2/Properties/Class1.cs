using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.BucketLib;

namespace Classes_5___Bucket2
{
    internal class Bucket
    {
        private double capacity;
        private double currentAmount;
        public Bucket(int cap)
        {
            this.capacity = cap;
            this.currentAmount = 0;
        }
        public double GetCapacity()
        {
            return this.capacity;
        }
        public double GetCurrentAmount()
        {
            return this.currentAmount;
        }

        public void Empty()
        {
            this.currentAmount = 0;
        }
        public bool IsEmpty()
        {
            return this.currentAmount == 0;
        }
        public void fill(double x)
        {
            if (this.currentAmount + x >= this.capacity) this.currentAmount = this.capacity;
            else this.currentAmount += x;
        }
        public void PourInto(Bucket bucketinto)
        { 
            double space = bucketinto.capacity - bucketinto.currentAmount;

            if( this.currentAmount >= space) 
            {
                bucketinto.currentAmount += space;
                this.currentAmount -= space;
            }

            if ( this.currentAmount < space) 
            {
                bucketinto.currentAmount += this.currentAmount;
                this.currentAmount -= this.currentAmount;
            }
        }
    }
}
