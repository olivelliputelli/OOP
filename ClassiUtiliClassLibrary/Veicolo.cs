using System;

namespace ClassiUtiliClassLibrary
{
    /// <summary>
    /// Classe Veicolo.
    /// </summary>
    public class Veicolo
    {
        public string Targa { get; set; }
        public string Marca { get; set; }
        public string Modello { get; set; }
        public string Cilindrata { get; set; }

        public DateTime Data { get; set; }

        private int anno;

        public int Anno
        {
            get { return anno; }
            set { anno = (value>1800 && value<DateTime.Now.Year)?value:throw new Exception(); }
        }

        private int numeroPosti;

        public int NumeroPosti
        {
            get { return numeroPosti; }
            set { numeroPosti = (value > 0) ? value : throw new Exception(); }
        }

        public Veicolo(){}

        public Veicolo(string marca, string modello, int anno)
        {
            this.Marca = marca;
            this.Modello = modello;
            this.Anno = anno;
        }

        /// <summary>
        /// Confronta il veicolo con un altro veicolo.
        /// </summary>
        /// <param name="ve">Veicolo da confrontare</param>
        /// <returns>Numero anni di differenza</returns>
        public int ConfrontaAnno(Veicolo ve) => Math.Abs(this.Anno - ve.Anno);

        public static int ConfrontaAnno(Veicolo v1, Veicolo v2) => v1.ConfrontaAnno(v2);

        public override string ToString()
        {
            TimeSpan tempo = DateTime.Now - Data;
            return $"{Marca} {Modello}, anno: {Anno}";
        }
    }
}
