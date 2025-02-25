using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;

namespace Another_Classes___9
{
    class AllContests
    {
        private Contest[] conts; //מערך של התחרויות
        private Node<Sailor> allSaolors; //רשימה של המשתתפים

        public AllContests(Contest[] conts, Node<Sailor> allSaolors) //פעולה בונה
        {
            this.conts = conts;
            this.allSaolors = allSaolors;
        }

        //Get
        public Contest[] GetContests() { return this.conts; }
        public Node<Sailor> GetAllSaolors() { return this.allSaolors; }
        public bool DidHeWin(int id) //פעולה המחזירה אמת אם השחקן ניצח באחד המשחקים, ושקר אם לא
        {
            for (int i = 0; i < this.conts.Length; i++)
            {
                if (conts[i].GetWinner() == id)
                    return true;
            }
            return false;
        }

        public void PrintLosers() //הפעולה מדפיסה את כל המלחים שלא ניצחו במירוץ
        {
            Node<Sailor> p = allSaolors;
            while (p != null)
            {
                if (!DidHeWin(p.GetValue().getId()))
                    Console.WriteLine(p.GetValue().getId());
                p = p.GetNext();
            }
        }
    }
}
