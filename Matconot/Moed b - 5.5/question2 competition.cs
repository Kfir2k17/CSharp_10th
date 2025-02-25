using System;
using Unit4.CollectionsLib;
namespace Moed_b___5._5
{
    class Judge
    {
        private int place1;    // מספר השיר שהשופט העניק לו מקום ראשון
        private int place2;    //  מספר השיר שהשופט העניק לו מקום שני
        private int place3;    //  מספר השיר שהשופט העניק לו מקום שלישי

        //Get
        public int GetPlace1() {  return place1; }
        public int GetPlace2() { return place2; }
        public int GetPlace3() { return place3; }

        //Set
        public void SetPlace1(int place1) { this.place1 = place1;}
        public void SetPlace2(int place2) {  this.place2 = place2; }
        public void SetPlace3(int place3) {  this.place3 = place3; }
    }
    class Song
    {
        private static int count = 0; // מספר השירים
        private int id;        //  מספר שיר הנקבע אוטומטי
        private int points;    //  הניקוד המצטבר

        //Get
        public int GetPoints() { return points; }
        public int GetID() { return id; }

        //Set
        public void SetPoints(int points) { this.points = points; }
        public void SetID(int Id) { this.id = Id; }


        public Song() // פעולה בונה
        {
            count++;
            this.id = count;
            this.points = 0;
        }

        public void AddPoints(int ps) // פעולה המקבלת מספר נקודות ומגדילה את מספר הנקודות של השיר בהן
        {
            this.points += ps;
        }
    }

    class Competition
    {
        private Song[] songs = new Song[24];
        private Judge[] votes = new Judge[15];

        public void UpdatePoints() // פעולה הסורקת מערך הצבעות ומעדכנת את הניקוד
        {
            for (int i = 0; i < votes.Length; i++)
            {
                songs[votes[i].GetPlace1()-1].AddPoints(12);
                songs[votes[i].GetPlace2()-1].AddPoints(7);
                songs[votes[i].GetPlace3()-1].AddPoints(4);
            }
        }

        public int Winner() // פעולה פנימית שמחזירה את מספר השיר המנצח
        {
            Song win = songs[0];
            for (int i = 0; i < songs.Length; i++)
            {
                if (songs[i].GetPoints() > win.GetPoints())
                    win = songs[i];
            }
            return win.GetID();
        }
    }

}
