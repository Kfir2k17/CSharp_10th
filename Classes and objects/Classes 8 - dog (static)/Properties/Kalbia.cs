using Classes_8___dog__static_.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_8___dog__static_
{
    internal class Kalbia
    {
        private Dog[] clavim;
        private static int counter = 0;

        public Kalbia()
        {
            this.clavim = new Dog[100];
        }

        public void AddDog(Dog dog)
        {
            if(counter <= 100) 
            {
                clavim[counter] = dog;
                counter++;
            }
        }

        public void GrowAll()
        {
            for (int i = 0; i < counter; i++)
                clavim[i].Grow();
        }
    }
}
