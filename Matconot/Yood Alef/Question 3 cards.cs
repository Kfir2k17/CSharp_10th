using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yood_Alef
{
    class Card
    {
        private int num;
        private string shape;

        //Get
        public int GetNum() { return num; }
        public string GetShape() { return shape; }
    }

    class Hand
    {
        private Card[] cards;

        public bool HasSequence() // פעולה המחזירה האם על כל הקלפים מופיעים מספרים עוקבים בסדר עולה ועל כולם מופיעה אותה צורה
        {
            string shape = cards[0].GetShape();
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i].GetNum() > cards[i + 1].GetNum() && shape != cards[i].GetShape())
                    return false;
            }
            return true;
        }

        public bool HasBunch() // פעולה המחזירה אם במערך הקלפים מופיע אותו מספר על שלושה קלפים או יותר
        {
            for (int i = 0; i < cards.Length;i++)
            {
                int c = 0;
                for (int j = 0; j < cards.Length; j++)
                {
                    if (cards[i].GetNum() == cards[j].GetNum())
                        c++;
                }
                if (c >= 3)
                    return true;
            }
            return false;
        }
    }
}
