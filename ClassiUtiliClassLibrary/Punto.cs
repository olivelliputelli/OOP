using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{
    public class Punto
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;
        /// <summary>
        /// Crea un punto.
        /// </summary>
        /// <param name="x">coordinata X</param>
        /// <param name="y">coordinata Y</param>
        public Punto(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Punto() : this(0, 0) { }
        public Punto(Punto p) : this(p.X, p.Y) { }
        public double Distanza(Punto p)
        {
            // Pitagora
            return Math.Sqrt(Math.Pow(this.X - p.X, 2) + Math.Pow(this.Y - p.Y, 2));
        }
        public override bool Equals(object obj)
        {
            return
                (this.X == (obj as Punto).X) &&
                (this.Y == (obj as Punto).Y);
        }
        public override string ToString()
        {
            return $"({X};{Y})";
        }
    }
}
