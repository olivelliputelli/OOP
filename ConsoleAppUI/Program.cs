using ClassiUtiliClassLibrary;
using System;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main()
        {

            
            

            NumeroComplesso z;

            double a =0;
            double b =0;

            Console.Write("Parte reale: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Parte immaginaria: ");
            b = double.Parse(Console.ReadLine());

            z = new NumeroComplesso(a, b);

            Console.WriteLine($"{z.ToString()}");
        }
    }
}
