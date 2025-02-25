using Classes_8___dog__static_.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_8___dog__static_
{
    internal class Program
    {
        public static void GetDogsOver10(Dog[] n)
        {
            for(int i = 0; i < n.Length; i++)
            {
                if (n[i].GetAge() > 10)
                    Console.WriteLine(n[i]);
            }
        }

        static void Main(string[] args)
        {
            Kalbia kal1 = new Kalbia();
            Dog d = new Dog("Kyle");
            kal1.AddDog(d);

            kal1.GrowAll();

            Dog d1 = new Dog(d);
            Console.WriteLine(d);

            Console.ReadLine();

        }
    }
}
