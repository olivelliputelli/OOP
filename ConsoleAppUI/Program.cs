using ClassiUtiliClassLibrary;
using System;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main()
        {
            var p = new Persona("Pippo");

            var p1 = new Persona
            {
                Nome = "Pluto",
                Sesso = Genere.M,
                Eta = 12,
                Professione = "Impiegato"
            };


            Console.WriteLine($"{p.ChiSei()}");
        }
    }
}
