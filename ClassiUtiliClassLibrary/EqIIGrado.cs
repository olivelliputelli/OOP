using System;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// Equazioni della forma aX^2+bX+c=0
    /// </summary>
    /// <remarks>
    /// </remarks>
    public class EqIIGrado
    {
        /// <summary>
        /// Parametro della X^2
        /// </summary>
        public double A { get; set; } = 0;
        public double B { get; set; } = 0;
        public double C { get; set; } = 0;

        /// <summary>
        /// Costruttore vuoto
        /// </summary>
        public EqIIGrado() { }

        public EqIIGrado(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        private double Delta()
        {
            return Math.Pow(B, 2) - 4 * A * C;
        }

        public double X1()
        {
            if (!this.HaSoluzioniReali())
                throw new Exception();
            return (-B + Math.Sqrt(Delta())) / (2 * A);
        }

        public double X2()
        {
            if (!this.HaSoluzioniReali())
                throw new Exception();
            return (-B - Math.Sqrt(Delta())) / (2 * A);
        }

        public bool HaSoluzioniReali()
        {
            return Delta() >= 0;
        }

        public bool IsPrimoGrado()
        {
            return A == 0;
        }

        public bool RadiciUguali(EqIIGrado eq)
        {
            if (!this.HaSoluzioniReali() || !eq.HaSoluzioniReali())
                throw new Exception();
            return this.X1() == eq.X1() && this.X2() == eq.X2();
        }

        public static bool RadiciUguali(EqIIGrado eq1, EqIIGrado eq2)
        {
            return eq1.RadiciUguali(eq2);
        }

        public override string ToString()
        {
            return $"{A} X^2 + {B} X + {C} = 0";
        }
    }
}
