using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{
    public class Sfera : Solido
    {
        public double Raggio { get; set; } = 0;
        public Sfera(double raggio, double pesoSpecifico)
            : base(pesoSpecifico)
        {
            Raggio = raggio;
        }
        public override double Superficie()
        {
            return 4 * Math.PI * Math.Pow(Raggio, 2);
        }
        public override double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Raggio, 3);
        }
    }
}
