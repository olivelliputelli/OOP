using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{
    public class Punto2D
    {
        public double X { get; set; } = 0;
        public double Y { get; set; } = 0;

        public Punto2D() { }

        public Punto2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"({this.X};{this.Y})"; 
        }

        public override bool Equals(object obj)
        {
            Punto2D p = obj as Punto2D;
            return (this.X == p.X) && (this.Y == p.Y);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
