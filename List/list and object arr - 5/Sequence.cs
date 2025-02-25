using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_and_object_arr___5
{
    class Sequence
    {
        private int num;
        private int times;
        public Sequence(int num, int times)
        {
            this.num = num;
            this.times = times;
        }

        public int GetNum() { return num; }
        public int GetTimes() { return times; }

        public void SetNum(int num) { this.num = num; }
        public void SetTimes(int times) { this.times = times; }

    }
}
