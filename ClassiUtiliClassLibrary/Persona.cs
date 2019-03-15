using System;

namespace ClassiUtiliClassLibrary
{
    public enum Genere { F, M, N }

    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nome { get; set; }
        public Genere Sesso { get; set; } = Genere.N;

        private int eta;

        public int Eta
        {
            get { return eta; }
            set { eta = (value >= 0 && value < 200) 
                    ? value 
                    : throw new IndexOutOfRangeException(); }
        }

        public string Professione { get; set; }

        public Persona() { }

        public Persona(string nome)
        {
            this.Nome = nome;
        }

        public string ChiSei()
        {
            return $"Sono una persona di nome: {Nome}, sesso: {Sesso}, età: {Eta}, professione: {Professione}. ";
        }

        public static int DifferenzaEta(Persona a, Persona b)
        {
            return Math.Abs(a.Eta - b.Eta);
        }

        public int DifferenzaEta(Persona p)
        {
            return Math.Abs(this.Eta - p.Eta);
        }
    }
}
