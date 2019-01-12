using System;

namespace ClassiUtiliClassLibrary
{
    public class Cerchio
    {
        private double raggio;

        public double Raggio
        {
            get => raggio;
            set => raggio = (value >= 0) ? value : throw new IndexOutOfRangeException();
        }

        public double Area() => Math.PI * Math.Pow(this.Raggio, 2);

        public double Circonferenza() => 2 * Math.PI * this.Raggio;

        public override bool Equals(object obj)
            => this.Raggio == (obj as Cerchio).Raggio;

        public override int GetHashCode() => base.GetHashCode();
    }
}
