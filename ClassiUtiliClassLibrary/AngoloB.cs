using System;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// Classe Angolo con notazione classica.
    /// </summary>
    public class AngoloB
    {
        private int angoloInSecondi;

        /// <summary>
        /// bgn h
        /// </summary>
        public AngoloB(){  }

        /// <summary>
        /// dfbfd
        /// </summary>
        public int AngoloInSecondi
        {
            get { return angoloInSecondi; }
            set { angoloInSecondi = value % (360 * 60 * 60); }
        }

        /// <summary>
        /// bfdbdf h
        /// </summary>
        /// <param name="g">dfgfd</param>
        /// <param name="p">dgdf</param>
        /// <param name="s">fdgfd</param>
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

        /// <summary>
        /// eytry
        /// </summary>
        /// <param name="a">rey</param>
        /// <returns>eryrt</returns>
        public int Differenza(AngoloB a)
        {
            return this.AngoloInSecondi - a.AngoloInSecondi;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
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
