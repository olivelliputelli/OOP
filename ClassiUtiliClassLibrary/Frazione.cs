using System;

namespace ClassiUtiliClassLibrary
{
    public class Frazione
    {
        public int Numeratore { get; private set; }
        public int Denominatore { get; private set; }

        public Frazione() : this(0, 1) { }

        public Frazione(int n, int d)
        {
            int segno = Math.Sign(n * d);
            n = Math.Abs(n);
            d = Math.Abs(d);
            this.Numeratore = segno * n / MCD(n, d);
            this.Denominatore = d / MCD(n, d);
        }

        private static int MCD(int a, int b)
        {
            // Da fare
            return 1;
        }

        private static int mcm(int a, int b)
        {
            // Da fare
            return 1;
        }

        public Frazione Somma(Frazione f)
        {
            int den = mcm(this.Denominatore, f.Denominatore);
            int num = (den / this.Denominatore * this.Numeratore) + (den / f.Denominatore * f.Numeratore);
            return new Frazione(num, den);
        }

        public static Frazione operator +(Frazione f1, Frazione f2)
        {
            return f1.Somma(f2);
        }

        // overload operator +
        //public static Frazione operator +(Frazione a, Frazione b)
        //{
        //    return new Frazione(a.Numeratore * b.Denominatore + b.Numeratore * a.Denominatore,
        //       a.Denominatore * b.Denominatore);
        //}

        public Frazione Moltiplica(Frazione f)
        {
            int den = this.Denominatore * f.Denominatore;
            int num = this.Numeratore * f.Numeratore;
            return new Frazione(num, den);
        }

        public static Frazione operator *(Frazione f1, Frazione f2)
        {
            return f1.Moltiplica(f2);
        }

        public override string ToString()
        {
            return $"{this.Numeratore}{((this.Denominatore != 1) ? "/" + this.Denominatore : "")}";
        }

        public override bool Equals(object obj)
        {
            return this.Numeratore == (obj as Frazione).Numeratore && this.Denominatore == (obj as Frazione).Denominatore;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
