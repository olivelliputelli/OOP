using System;

namespace ClassiUtiliClassLibrary
{
    public enum SistemaOperativo { Windows, MACOS, Linux, Android }

    public class ProgrammaPC
    {
        public string Denominazione { get; set; }
        public string Produttore { get; set; }
        public string Versione { get; set; } = "1.0.0";
        public SistemaOperativo SO { get; set; } = SistemaOperativo.Windows;

        private int anno;

        public int Anno
        {
            get { return anno; }
            set { anno = (value > 1950 && value <= DateTime.Now.Year) ? value : throw new System.Exception(); }
        }

        public ProgrammaPC() { }

        public ProgrammaPC(string denominazione, string produttore, int anno)
        {
            this.Denominazione = denominazione;
            this.Produttore = produttore;
            this.Anno = anno;
        }

        public int ConfrontaAnno(ProgrammaPC pPC)
        {
            return this.Anno - pPC.Anno;
        }

        public static int ConfrontaAnno(ProgrammaPC pr1, ProgrammaPC pr2)
        {
            return pr1.ConfrontaAnno(pr2);
        }

        public override string ToString()
        {
            return $"{Denominazione} - {Produttore} ( {Versione} del {Anno}) - {SO}";
        }
    }
}
