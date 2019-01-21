using System;

namespace ClassiUtiliClassLibrary
{
    public class Timer
    {
        private int secondiTotali;

        public int SecondiTotali
        {
            get { return secondiTotali; }
            set { secondiTotali = (value >= 0) ? value : throw new ArgumentOutOfRangeException(); }
        }

        public int Secondi => SecondiTotali % 60;
        public int Minuti => SecondiTotali / 60 % 60;
        public int Ore => SecondiTotali / 3600;

        public Timer() : this(0, 0, 0) { }

        public Timer(int secondiTotali) => SecondiTotali = secondiTotali;

        public Timer(int h, int m, int s) => SecondiTotali = h * 3600 + m * 60 + s;

        public void AggiungiSecondi(int s) => SecondiTotali += s;
        public void AggiungiMinuti(int m) => SecondiTotali += m * 60;
        public void AggiungiOre(int h) => SecondiTotali += h * 3600;

        public static Timer SommaTimer(Timer t1, Timer t2) => new Timer(t1.SecondiTotali + t2.SecondiTotali);

        public void SommaTimer(Timer t)
        {
            this.SecondiTotali += t.SecondiTotali;
        }

        public override bool Equals(object obj)
        {
            return this.SecondiTotali == (obj as Timer).SecondiTotali;
        }

        public static bool MinoreDi(Timer t1, Timer t2)
            => t1.SecondiTotali < t2.SecondiTotali;

        public static bool MaggioreDi(Timer t1, Timer t2)
            => t1.SecondiTotali > t2.SecondiTotali;

        public static bool operator <=(Timer t1, Timer t2)
            => t1.SecondiTotali < t2.SecondiTotali;

        public static bool operator >=(Timer t1, Timer t2)
            => t2 <= t1;

        public static Timer operator +(Timer t1, Timer t2)
            => new Timer(t1.SecondiTotali + t2.SecondiTotali);

        public override string ToString() => $"{Ore}:{Minuti}:{Secondi}";

    }
}
