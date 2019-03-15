using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{
    public class Cubo : Solido
    {
        public Cubo(double lato, double pesoSpecifico)
            : base(pesoSpecifico)
        {
            Lato = lato;
        }
        public double Lato { get; set; } = 0;
        public override double Superficie()
        {
            return 6 * Math.Pow(Lato, 2);
        }
        public override double Volume()
        {
            return Math.Pow(Lato, 3);
        }
    }
}
