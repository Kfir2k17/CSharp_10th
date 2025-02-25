namespace Matconet___1
{
    class A
    {
        private int x;
        public A() { this.x = 5; }
        public A(int x) { this.x = x; }
        public virtual int GetX() { return this.x; }
        public void DoSomething() { this.x = 1 + this.GetX(); }
        public virtual void Add() { this.x = this.x + 1; }
        public override string ToString() { return "x in A: " + this.x; }
    }

    class B : A
    {
        private int x;
        public B() : base() { this.x = 2; }
        public B(int x) : base(x) { this.x = x - 2; }
        public B(int x1, int x2) : base (x1) { this.x = x2; }
        public override int GetX() { return x; }
        public override void Add() { this.x = this.x + 5; }
        public int FlowerOfBase() { return base.GetX(); }
        public override string ToString() { return base.ToString() + " x in B: " + this.x; }
    }
}
