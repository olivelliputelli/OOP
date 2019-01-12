using System;

namespace ClassiUtiliClassLibrary
{
    public class Frazione
    {
        public int Numeratore { get; }
        public int Denominatore { get; }

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
