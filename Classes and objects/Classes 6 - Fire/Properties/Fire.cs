using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes_6___Fire.Properties
{
    internal class Fire
    {
        public int firecode;
        public int month;
        public int cost;

        public Fire(int firecode, int month, int cost) 
        {
            this.firecode = firecode;
            this.month = month;
            this.cost = cost;
        }

        public Fire(int firecode, int month)
        {
            this.firecode = firecode;
            this.month = month;
            this.cost = 0;
        }
        
        public int GetFirecode()
        {
            return this.firecode;
        }

        public void SetFirecode(int firecode)
        {
            this.firecode = firecode;
        }

        public int GetMonth()
        {
            return this.month;
        }

        public void SetMonth(int month)
        {
            this.month = month;
        }

        public int GetCost()
        {
            return this.cost;
        }
        public void SetCost(int cost)
        {
            this.cost = cost;
        }

        public Fire(Fire x)
        {
            this.firecode = x.firecode;
            this.month = x.month;
            this.cost = x.cost;
        }

        public override string ToString()
        {
            string fire = "Fire code: " + this.firecode + ", Month: " + this.month + ", Cost:" + this.cost;
            return fire;
        }

    }                         
}
