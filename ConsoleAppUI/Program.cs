using System;
using ClassiUtiliClassLibrary;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main()
        {
            var a = new Angolo(350, 40, 0);

            a.AggiungiGradi(45);
            a.AggiungiSecondi(100);

            Console.WriteLine($"{a.ToString()}");
        }
    }
}
