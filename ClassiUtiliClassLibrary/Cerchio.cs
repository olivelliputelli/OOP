using System;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// Classe Cerchio.
    /// </summary>
    public class Cerchio : FiguraGeometrica2D
    {
        private double _raggio;
        /// <summary>
        /// Proprietà Raggio.
        /// </summary>
        public double Raggio
        {
            get => _raggio;
            set => _raggio = (value >= 0) ? value : throw new ArgumentOutOfRangeException();
        }
        /// <summary>
        /// Costruttore.
        /// </summary>
        /// <param name="raggio">Il raggio</param>
        public Cerchio(double raggio)
        {
            Raggio = raggio;
        }

        /// <summary>
        /// Cerchio di raggio 0.
        /// </summary>
        public Cerchio() : this(0) { }

        /// <summary>
        /// Area del cerchio
        /// </summary>
        /// <returns>area del cerchio</returns>
        public override double Area() => Math.PI * Math.Pow(this.Raggio, 2);

        /// <summary>
        /// Circonferenza del cerchio
        /// </summary>
        /// <returns>circonferenza del cerchio</returns>
        public override double Perimetro() => 2 * Math.PI * this.Raggio;

        /// <summary>
        /// Confronta il cerchio con un altro cerchio
        /// </summary>
        /// <param name="obj">Cerchio da confrontare</param>
        /// <returns>true se i cerchi sono uguali.</returns>
        public override bool Equals(object obj)
            => this.Raggio == (obj as Cerchio).Raggio;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => base.GetHashCode();
    }
}
