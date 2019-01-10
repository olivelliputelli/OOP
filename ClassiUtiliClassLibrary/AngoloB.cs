using System;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// Classe Angolo con notazione classica.
    /// </summary>
    public class AngoloB
    {
        private int angoloInSecondi;

        public AngoloB(){  }

        public int AngoloInSecondi
        {
            get { return angoloInSecondi; }
            set { angoloInSecondi = value % (360 * 60 * 60); }
        }

        public AngoloB(int g, int p, int s)
        {
            if (g < 0 || p < 0 || s < 0)
                throw new IndexOutOfRangeException();

            AngoloInSecondi = g * (60 * 60) + p * 60 + s;
        }

        public AngoloB(AngoloB a)
        {
            this.AngoloInSecondi = a.AngoloInSecondi;
        }

        public int Gradi
        {
            get { return (AngoloInSecondi / (60 * 60)); }
        }

        public int Primi
        {
            get { return (AngoloInSecondi - Gradi * 3600) / 60; }
        }

        public int Secondi
        {
            get { return (AngoloInSecondi - Gradi * 3600 - Primi * 60); }
        }

        public void AggiungiGradi(int gradi)
        {
            AngoloInSecondi += (gradi * 60 * 60);
        }

        public void AggiungiPrimi(int primi)
        {
            AngoloInSecondi += (primi * 60);
        }

        public void AggiungiSecondi(int secondi)
        {
            AngoloInSecondi += secondi;
        }

        public int Differenza(AngoloB a)
        {
            return this.AngoloInSecondi - a.AngoloInSecondi;
        }

        public AngoloB Somma(AngoloB a)
        {
            return new AngoloB
            {
                AngoloInSecondi = AngoloInSecondi + a.AngoloInSecondi
            };        
        }

        public override string ToString()
        {
            return $"{Gradi}° {Primi}' {Secondi}\"";
        }

    }
}
