using System;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// Classe Cerchio 
    /// </summary>
    public class Cerchio
    {
        private double raggio;

        /// <summary>
        /// Proprietà Raggio
        /// </summary>
        public double Raggio
        {
            get => raggio;
            set => raggio = (value >= 0) ? value : throw new IndexOutOfRangeException();
        }

        /// <summary>
        /// Area del cerchio
        /// </summary>
        /// <returns>area del cerchio</returns>
        public double Area() => Math.PI * Math.Pow(this.Raggio, 2);

        /// <summary>
        /// Circonferenza del cerchio
        /// </summary>
        /// <returns>circonferenza del cerchio</returns>
        public double Circonferenza() => 2 * Math.PI * this.Raggio;

        /// <summary>
        /// Confronta il cerchio con un altro cerchio
        /// </summary>
        /// <param name="obj">Cerchio da confrontare</param>
        /// <returns>true se i cerchi sono uguali.</returns>
        public override bool Equals(object obj)
            => this.Raggio == (obj as Cerchio).Raggio;

        public override int GetHashCode() => base.GetHashCode();
    }
}
