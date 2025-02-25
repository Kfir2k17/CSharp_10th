using System.CodeDom;
using System.Threading;

namespace Matconet___1
{
    class Vehicle
    {
        private string model;
        private double bPrice;
        private bool electric;

        public Vehicle(string m, double bP, bool e)
        {
            this.model = m;
            this.bPrice = bP;
            this.electric = e;
        }

        public virtual double FinalPrice()
        {
            if (electric)
                return 1.1 * bPrice;
            return bPrice;
        }

        public string GetModel() { return model; }
        public void SetModel(string m) { model = m; }
        public double GetBPrice() { return bPrice; }
        public void SetBPrice(double bPrice) { this.bPrice = bPrice; }
        public bool GetElectric() { return this.electric; }
        public void SetElectric(bool electric) { this.electric = electric; }
    }

    class Car : Vehicle
    {
        private bool automatic;
        public Car(string m, double bP, bool e, bool automatic) : base(m, bP, e)
        {
            this.automatic = automatic;
        }
        
        public override double FinalPrice()
        {
            if (automatic)
                return base.FinalPrice() + 0.2 * GetBPrice();
            return base.FinalPrice();
        }

        public bool GetAutomatic() { return automatic; }
        public void SetAutomatic(bool automatic) { this.automatic = automatic; }
    }

    class Bike : Vehicle
    {
        private bool street;
        public Bike(string m, double bPrice, bool electric, bool street) : base(m, bPrice, electric)
        {
            this.street = street;
        }
        public bool GetStreet() { return street;}
        public void SetStreet(bool street) {  this.street = street; }
    }
}
