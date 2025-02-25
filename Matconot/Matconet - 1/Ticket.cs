using System;

namespace Matconet___1
{
    class Ticket
    {
        private string city; // העיר בה מתקיימת ההופעה
        private double time; // זמן ההתחלה של ההופעה
        private double price; // מחיר
        private int row; // מספר השורה של הצופה

        public Ticket(string city, double time, double price, int row) // פעולה בונה
        {
            this.city = city;
            this.time = time;
            this.price = price;
            this.row = row;
        }

        public int Distance(Ticket tic) // פעולה המקבלת כרטיס ואם הכרטיס מתייחס לאותה הופעה של הכרטיס הנוכחי יוחזר המרחק בין השורות, אחרת יוחזר -1
        {
            if (this.city == tic.city && this.time == tic.time)
                return Math.Abs(this.row - tic.row);
            return -1;
        }

        //Get
        public string GetCity() { return this.city; }
        public double GetTime() { return this.time;}
        public double GetPrice() { return this.price;}
        public int GetRow() { return this.row;}

        //Set
        public void SetCity(string city) { this.city = city;}
        public void SetTime(double time) {  this.time = time;}
        public void SetPrice(double price) {  this.price = price;}
        public void SetRow(int row) {  this.row = row;}
    }
}