using Unit4.CollectionsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Another_Classes___9
{
    class TripCollection
    {
        private Node<Trip> list; // רשימה של טיולים
        private int tripNum; //מספר הטיולים ברשימה

        public TripCollection(Node<Trip> list) //פעולה בונה, מקבלת רשימה וקובעת את המשתנה של כמות הטיולים לפי אורך הרשימה
        {
            this.list = list;
            Node<Trip> p = list;
            int counter = 0;
            while (p != null)
            {
                counter++;
                p = p.GetNext();
            }
            this.tripNum = counter;
        }

        public int HowManyArentEnough() //בודקת בכמה טיולים אין מספיק אנשים
        {
            Node<Trip> p = list;
            int counter = 0;

            while (p != null)
            {
                if (!p.GetValue().Enough())
                    counter++;
                p = p.GetNext();
            }
            return counter;
        }
    }
}
