using System;

namespace ClassiUtiliClassLibrary
{
    public class NumeroComplesso
    {
        // parte reale
        public double A { get; set; } = 0;

        // parte immaginaria
        public double B { get; set; } = 0;

        public NumeroComplesso() : this(0, 0) { }

        public NumeroComplesso(double a, double b)
        {
            this.A = a;
            this.B = b;
        }

        public NumeroComplesso Somma(NumeroComplesso c)
        {
            return new NumeroComplesso(this.A + c.A, this.B + c.B);
        }

        public double Modulo()
        {
            return Math.Sqrt(Math.Pow(this.A, 2) + Math.Pow(this.B, 2));
        }

        public NumeroComplesso Coniugato()
        {
            return new NumeroComplesso(this.A, -this.B);
        }

        public override string ToString()
        {
            if (this.B == 0)
                return $"{this.A}";
            return $"{this.A} {((this.B > 0) ? " + " : " - ")} {Math.Abs(this.B)} j";
        }

        public override bool Equals(object obj)
        {
            NumeroComplesso z = obj as NumeroComplesso;
            return (this.A == z.A) && (this.B == z.B);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
