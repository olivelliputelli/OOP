using System;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// Classe Angolo con lambda expression.
    /// </summary>
    public class Angolo
    {
        private int angoloInSecondi;
        public int AngoloInSecondi
        {
            get => angoloInSecondi;
            set => angoloInSecondi = value % (360 * 60 * 60);       
        }

        public int Gradi => ((AngoloInSecondi / (60 * 60)));

        public int Primi => (AngoloInSecondi - Gradi * 3600) / 60;

        public int Secondi => (AngoloInSecondi - Gradi * 3600 - Primi * 60);

        public Angolo() {   }

        public Angolo(int g, int p, int s)
        {
            if (g < 0 || p < 0 || s < 0)
                throw new IndexOutOfRangeException();

            AngoloInSecondi = (g * (60 * 60) + p * 60 + s);
        }

        public void AggiungiGradi(int gradi)
            => AngoloInSecondi += (gradi * 60 * 60);

        public void AggiungiPrimi(int primi)
            => AngoloInSecondi += (primi * 60);

        public void AggiungiSecondi(int secondi)
            => AngoloInSecondi += secondi;

        public Angolo Somma(Angolo a) => new Angolo
        {
            AngoloInSecondi = AngoloInSecondi + a.AngoloInSecondi
        };

        public int Differenza(Angolo a)
            => AngoloInSecondi - a.AngoloInSecondi;

        public override string ToString()
            => $"{Gradi}° {Primi}' {Secondi}\"";
   
    }
}
