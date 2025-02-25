using Classes_6___Fire.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_6___Fire
{
    internal class Program
    {
        public bool Comperor(Fires fires1, Fires fires2)
        {
            return fires1.MostFiresMonth() == fires2.MostFiresMonth();
        }

        static void Main(string[] args)
        {
            Fires fire2023 = new Fires(2023);
            Fire f1 = new Fire(123, 9, 680);
            Fire f2 = new Fire(124, 10);

            fire2023.NewFire(f1);
            fire2023.NewFire(f2);

        }
    }
}
