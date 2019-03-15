using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiUtiliClassLibrary
{

    public enum TOrientamento { A, D, B, S }
    public class PuntoOrientato : Punto
    {
        public TOrientamento Orientamento { get; set; }
            = TOrientamento.A;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="o"></param>
        public PuntoOrientato
            (double x, double y, TOrientamento o)
            : base(x, y)
        {
            this.Orientamento = o;
        }
        public PuntoOrientato() 
            : this(0, 0, TOrientamento.A)
        { }
        public PuntoOrientato(PuntoOrientato po)
            : this(po.X, po.Y, po.Orientamento) { }

        public void RuotaDestra()
        {
            switch (Orientamento)
            {
                case TOrientamento.A:
                    Orientamento = TOrientamento.D;
                    break;
                case TOrientamento.D:
                    Orientamento = TOrientamento.B;
                    break;
                case TOrientamento.B:
                    Orientamento = TOrientamento.S;
                    break;
                case TOrientamento.S:
                    Orientamento = TOrientamento.A;
                    break;
            }
        }
        public void RuotaSinistra()
        {
            switch (Orientamento)
            {
                case TOrientamento.A:
                    Orientamento = TOrientamento.S;
                    break;
                case TOrientamento.D:
                    Orientamento = TOrientamento.A;
                    break;
                case TOrientamento.B:
                    Orientamento = TOrientamento.D;
                    break;
                case TOrientamento.S:
                    Orientamento = TOrientamento.B;
                    break;
            }
        }
        public void Sposta(double distanza)
        {
            switch (Orientamento)
            {
                case TOrientamento.A:
                    Y += distanza;
                    break;
                case TOrientamento.D:
                    Y -= distanza;
                    break;
                case TOrientamento.B:
                    X -= distanza;
                    break;
                case TOrientamento.S:
                    Y += distanza;
                    break;
            }
        }

        public override bool Equals(object obj)
        {
            return
                base.Equals(obj as Punto) &&
                (obj as PuntoOrientato).Orientamento 
                == this.Orientamento;
        }
        public override string ToString()
        {
            return $"({X};{Y};{Orientamento})";
        }
    }
}
