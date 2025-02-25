using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moed_b___5._5
{
    class Block
    {
        private int len;        //אורך הרצף   
        private int min;        // המספר הכי קטן ברצף
        private bool isEven;    //אמת אם זוגי ושקר אם לא

        public Block(int len, int min, bool isEven)
        {
            this.len = len;
            this.min = min;
            this.isEven = isEven;
        }
    }
}
