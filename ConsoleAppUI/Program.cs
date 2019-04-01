using ClassiUtiliClassLibrary;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main()
        {
            //Random rnd = new Random();
            //IFiguraSolida fs;
            //int nc =rnd.Next(10);

            //Console.WriteLine($"Numero casulae = {nc}");

            //if (nc > 5)
            //    fs = new Sfera(3, 0.4);
            //else
            //    fs = new Cubo(1, 1);

            //Console
            //    .WriteLine($"{fs.GetType()} - Volume = {fs.Volume()} m^3");

            //Console.WriteLine(typeof(Cubo));

            //Object obj22 = new Object();

            List<int> numeri = new List<int>();

            List<Solido> solidi = new List<Solido>();

            solidi.Add(new Cubo(3,0.7));
            solidi.Add(new Sfera(3,6));

            ArrayList lista = new ArrayList();

            lista[0] = "5";
            lista[1] = 5;
            lista[2] = new Cubo(2, 4);


            //List<Punto> punti = new List<Punto>();

            //punti.Add(new Punto(2, 4));
            //punti.Add(new PuntoOrientato(4, 4, TOrientamento.D));
            //punti.Add(new Punto(2, 21));

            //Console.WriteLine(typeof(Punto));
            //punti
            //    .Where(p => p.GetType() == typeof(Punto))
            //    .ToList()
            //    .ForEach(p => Console.WriteLine(p.ToString()));

            //Punto o1 = new PuntoOrientato(4, 1, TOrientamento.A);
            //Console.WriteLine(o1.GetType());

            //Punto pp1 = (PuntoOrientato) o1;
            //Console.WriteLine(pp1.X);
            //Object o;
            //Punto pA;            
            //PuntoOrientato poA;

            //poA = (PuntoOrientato) new Punto();

            //o = new PuntoOrientato();

            //PuntoOrientato po1;
            //po1 = new PuntoOrientato(1, 1, TOrientamento.D);
            //var po2 = new PuntoOrientato(2, 2, TOrientamento.A);
            //var po3 = new PuntoOrientato(po1);

            //Console.WriteLine($"PO1 = {po1}");
            //Console.WriteLine($"PO2 = {po2}");
            //Console.WriteLine($"PO3 = {po3}");
            //Console.WriteLine($"Distanza PO1-PO2 = {po1.Distanza(po2)}");

            //Console.WriteLine($"Distanza PO1-PO3 = {po1.Distanza(po3)}");

            //if (po1.Equals(po3))
            //    Console.WriteLine("PO1 e PO3 sono uguali!!");
            //else
            //    Console.WriteLine("PO1 e PO3 NON sono uguali!!");

            //po1.RuotaSinistra();
            //Console.WriteLine($"PO1 = {po1}");
            //po1.Sposta(10);
            //Console.WriteLine($"PO1 = {po1}");

        }
    }
}
