using System;

namespace Matconet2024
{
    class Sara
    {
        private int num;
        public static int min = 11;
        public Sara(int v)
        {
            this.num = v;
            if (this.num < min)
                min = this.num;
        }
        public virtual Sara GetWho(Sara a) // פעולה שמקבלת עצם מסוג שרה ומחזירה את השרה עם הנאם הנמוך
        {
            if (this.num < a.num)
                return this;
            return a;
        }
        public int GetNum() { return this.num; }
    }
    class Bibi : Sara
    {
        public Bibi() : base(Bibi.min - 2) { } // תקין, המחלקה ביבי יורשת את שרה ומין הוא פאבליק לכן ניתן לגשת אליו 
        public Bibi(int n) : base(Math.Abs(n)) { }
        public override Sara GetWho(Sara x) // פעולה שמקבלת עצם מסוג שרה ובמידה והיא ביבי מחזירה את השרה עם הערך הנמוך, אחרת את השרה הנוכחית
        {
            if (x is Bibi)
                return base.GetWho(x);
            else
                return this;
        }
    }
}
