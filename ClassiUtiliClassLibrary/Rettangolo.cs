using System;

namespace ClassiUtiliClassLibrary
{
    public class Rettangolo : FiguraGeometrica2D
    {
        private double _base;
        /// <summary>
        /// Proprietà Base.
        /// </summary>
        public double Base
        {
            get => _base;
            set => _base = (value >= 0) ? value : throw new ArgumentOutOfRangeException();
        }
        private double _altezza;
        /// <summary>
        /// Proprietà Altezza.
        /// </summary>
        public double Altezza
        {
            get => _altezza;
            set => _altezza = (value >= 0) ? value : throw new ArgumentOutOfRangeException();
        }

        public Rettangolo(double @base, double altezza)
        {
            Base = @base;
            Altezza = altezza;
        }
        /// <summary>
        /// Costruttore che permette di costruire quadrati.
        /// </summary>
        /// <param name="lato">Lato del quadrato.</param>
        public Rettangolo(double lato) : this(lato, lato) { }

        public Rettangolo() : this(0) { }

        public override double Area()
        {
            return Base * Altezza;
        }

        public override double Perimetro()
        {
            return 2 * (Base + Altezza);
        }
    }
}
