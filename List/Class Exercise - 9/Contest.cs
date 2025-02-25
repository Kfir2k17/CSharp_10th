using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace Another_Classes___9
{
    class Contest
    {
        private string date; //מחרוזת של תאריך
        private Node<Sailor> sailorLst; //רשימה של השייטים המשתתפים
        private int winner; //מספר הזהות של המנצח

        public bool InContest(int id) //פעולה המקבלת מספר זהות, ובודקת האם הוא משתתף בתחרות
        {
            Node<Sailor> p = sailorLst;
            while (p != null)
            {
                if (p.GetValue().getId() == id)
                    return true;
                p = p.GetNext();
            }
            return false;
        }
        public int HowManySailorsOnThisClub(string club)//פעולה המקבלת מחרוזת של שם מועדון, ומחזירה כמה שייטים נמצאים בו
        {
            Node<Sailor> p = sailorLst;
            int counter = 0;
            while (p != null)
            {
                if (p.GetValue().getClub() == club)
                    counter++;
                p = p.GetNext();
            }
            return counter;
        }
        //Get
        public string GetDate() { return date; }
        public Node<Sailor> GetSailorList() { return sailorLst; }
        public int GetWinner() { return winner; }
    }
}
