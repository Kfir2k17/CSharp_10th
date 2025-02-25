using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ParkMada2024
{
    class Robot
    {
        private string name;
        private bool canTalk;
        private int year;
        private double price;
        
        //Get
        public string GetName() { return name; }
        public bool CanTalk() { return canTalk; }
        public int GetYear() { return year; }
        public double GetPrice() { return price; }

        //Set
        public void SetName(string name) { this.name = name; }
        public void SetCanTalk(bool canTalk) { this.canTalk = canTalk; }
        public void SetYear(int year) { this.year = year; }
        public void SetPrice(double price) { this.price = price; }
        
        public Robot(string name, bool canTalk, int year, double price) // סעיף א, פעולה בונה
        {
            this.name = name;
            this.canTalk = canTalk;
            this.year = year;
            this.price = price;
        }

        public void AddMoney(double y) // סעיף ב, פעולה המוסיפה וואי שקלים למחיר הרובוט
        {
            price += y;
        }

        public bool Comp(Robot r) // סעיף ג, פעולה המחזירה אמת אם הרובוט המתקבל, בעל יכולת דיבור זהה לרובוט הנוכחי, בנוסף ההפרש בין שנות הייצור שלהם הוא לכל היותר 3 שנים
        {
            return this.canTalk == r.canTalk && Math.Abs(r.year - this.year) >= 3;
        }
    }
}
