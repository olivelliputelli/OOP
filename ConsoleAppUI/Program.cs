using ClassiUtiliClassLibrary;
using System.Collections.Generic;
using System;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main()
        {
            PuntoOrientato po1;
            po1 = new PuntoOrientato(1, 1, TOrientamento.D);
            var po2 = new PuntoOrientato(2, 2, TOrientamento.A);
            var po3 = new PuntoOrientato(po1);

            Console.WriteLine($"PO1 = {po1}");
            Console.WriteLine($"PO2 = {po2}");
            Console.WriteLine($"PO3 = {po3}");
            Console.WriteLine($"Distanza PO1-PO2 = {po1.Distanza(po2)}");

            Console.WriteLine($"Distanza PO1-PO3 = {po1.Distanza(po3)}");

            if(po1.Equals(po3))
                Console.WriteLine("PO1 e PO3 sono uguali!!");
            else
                Console.WriteLine("PO1 e PO3 NON sono uguali!!");

            po1.RuotaSinistra();
            Console.WriteLine($"PO1 = {po1}");
            po1.Sposta(10);
            Console.WriteLine($"PO1 = {po1}");

        }
    }
}
