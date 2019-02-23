using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// Classe astratta che rappresenta tutte le figure geometriche della geometria piana.
    /// </summary>
    public abstract class FiguraGeometrica2D
    {
        public abstract double Area();
        public abstract double Perimetro();
    }
}
