using System;
using System.Collections.Generic;
using System.Text;

namespace MatematicaClassLibrary.Geometria2D
{
    /// <summary>
    /// Classe utile per gestire cerchi geometrici.
    /// </summary>
    public class Cerchio
    {
        private double raggio;

        /// <value>
        /// get e set del raggio del cerchio.
        /// </value>
        /// 
        public double Raggio
        {
            get { return raggio; }
            set { raggio = value; }
        }

        /// <summary>
        /// Area del cerchio.
        /// </summary>
        /// <returns>Area del cerchio.</returns>
        public double Area()
        {
            return Math.PI * Math.Pow(Raggio, 2);
        }
    }
}
