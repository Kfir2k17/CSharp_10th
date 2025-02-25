using System;
using Unit4.CollectionsLib;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parkamada2021
{
    class Nums
    {
        private Node<int> pos;  //  רשימה של המספרים החיוביים
        private Node<int> neg; //  תור של המספרים השליליים
        private Node<int> last_neg; //  מצביע לסוף התור של המספרים השליליים

        public void Insert(int num)   //  פעולה המקבלת מספר ומכניסה אותו לאחת מן האוספים בהתאם
        {
            if (num > 0)
                pos = new Node<int>(num, pos);

            if (num < 0)
            {
                if (neg == null)
                {
                    neg = new Node<int>(num);
                    last_neg = neg;
                }

                else
                    neg = new Node<int>(num, neg);
            }
        }

        public int LastPositive()   //   פעולה המחזירה את ערך האיבר החיובי האחרון שהוכנס לאוסף
        {
            return pos.GetValue();
        }

        public int FirstNegative()  //  החזרת ערך האיבר השלילי הראשון שהוכנס לאוסף
        {
            return last_neg.GetValue();
        }

        public void Remove()    //   הוצאת המספר שהכי קרוב מהקבוצה המתאימה (חיובית או שלילית)
        {
            Node<int> p = pos;
            Node<int> close_node = pos;
            

            while (p.GetNext().HasNext())
            {
                if (p.GetNext().GetValue() < close_node.GetValue())
                    close_node = p;
            }

            p = neg;

            while (p.GetNext().HasNext())
            {
                if (Math.Abs(p.GetNext().GetValue()) < Math.Abs(close_node.GetValue()))
                    close_node = p;
            }

            Node<int> pos1 = p.GetNext();
            close_node.SetNext(pos1.GetNext());
            pos1.SetNext(null);
        }
        
    }
}
