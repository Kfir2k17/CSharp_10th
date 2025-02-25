using System;

namespace Matconet2024
{
    class Device
    {
        protected string pwd; // סיסמת הפעלה
        protected bool working; // האם המכשיר דולק

        public Device(string pwd)
        {
            this.pwd = pwd;
            working = false;
        }

        public virtual bool SwitchOn(string p)
        {
            if (pwd == p)
            {
                Console.WriteLine("Swtiched On.");
                working = true;
                return true;
            }
            return false;
        }
        public virtual bool SwitchOff(string p)
        {
            if (pwd == p)
            {
                Console.WriteLine("Swtiched Off.");
                working = true;
                return true;
            }
            return false;
        }
    }

    class AC : Device
    {
        private int max; // משך הזמן המירבי שהוא יכול לפעול

        public AC(int max, string pwd) : base(pwd)
        {
            this.max = max;
        }

        public bool SwitchOn(string p, int time)
        {
            if (pwd == p && time <= max)
            {
                Console.WriteLine("Swtiched On.");
                return true;
            }
            return false;
        }
    }

    //class Lamp : Device
    //{
    //    public override bool SwitchOff(string p)
    //    {
    //        if (base.SwitchOff(p))
    //        {
    //            Console.WriteLine("Dimming...");
    //            return true;
    //        }
    //        return false;
    //    }
    //}

    //class TV : Device
    //{

    //}
}
