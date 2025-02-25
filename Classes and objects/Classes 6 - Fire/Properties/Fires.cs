using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Classes_6___Fire.Properties
{
    internal class Fires
    {
        private int year;
        private Fire[] arr;
        private int count;

        public Fires(int year)
        {
            this.year = year;
            this.arr = new Fire[5000];
            this.count = 0;
        }

        public void NewFire(Fire x)
        {
            if (count == 5000)
                Console.WriteLine("Error - Not enough space");

            else
            {
                arr[count] = x;
                count++;
            }
        }

        public void SetCost(int Firecode, int month, int cost)
        {
            bool found = false;
            int counter = 0;

            while (counter < 5000 && found == false)
            {
                if (this.arr[counter].firecode == Firecode && this.arr[counter].month == month)
                {
                    this.arr[counter].cost = cost;
                    found = true;
                }

                counter++;
            }

            if (counter == 5000)
            {
                Fire f = new Fire(Firecode, month, cost);
                NewFire(f);
            }
        }

        public int HowManyFires(int month)
        {
            int count = 0;
            for (int i = 0; i < 5000; i++)
            {
                if (this.arr[i].month == month)
                    count++;
            }
            return count;
        }

        public int MostFiresMonth()
        {
            int max = 0;
            int max_month = 0;
            int amount = 0;
            for (int i = 1; i <= 12; i++)
            {
                amount = this.HowManyFires(i);
                
                if (amount > max)
                {
                    max = amount;
                    max_month = i;
                }
            }
            return max_month;
        }
    }
}
