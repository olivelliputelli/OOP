using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Solido 
        : ICorpoSolido, IFiguraSolida
    {
        public double PesoSpecifico { get; set; } = 0;
        public Solido(double pesoSpecifico)
        {
            PesoSpecifico = pesoSpecifico;
        }
        /// <summary>
        /// Metodo astratto, non so la formula giusta..
        /// </summary>
        /// <returns></returns>
        public abstract double Volume();
        public abstract double Superficie();

        public double Peso()
        {
            return PesoSpecifico * Volume();
        }
    }  
}
