using System;

namespace ClassiUtiliClassLibrary
{
    public class Vettore2D
    {
        public Punto2D P { get; set; } = new Punto2D();
        public Punto2D Q { get; set; } = new Punto2D();

        public Vettore2D() { }

        public Vettore2D(Punto2D p, Punto2D q)
        {
            this.P = p;
            this.Q = q;
        }

        public Vettore2D(Vettore2D v) : this(v.P, v.Q) { }

        public override string ToString()
        {
            return $"{this.P} --> {this.Q}";
        }

        public double Lunghezza()
        {
            return Math.Sqrt(Math.Pow(P.Y - Q.Y, 2) + Math.Pow(P.X - Q.X, 2));
        }

        public override bool Equals(object obj)
        {
            Vettore2D v = obj as Vettore2D;
            return (this.P == v.P) && (this.Q == v.Q);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
