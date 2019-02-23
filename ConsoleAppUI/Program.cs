using ClassiUtiliClassLibrary;
using System.Collections.Generic;
using System;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main()
        {
            var figure2D = new List<FiguraGeometrica2D>
            {
                new Cerchio(4),
                new Rettangolo(5),
                new Rettangolo(2,3),
                new Cerchio(1)
            };

            foreach (var f in figure2D)
            {
                Console.WriteLine($"{f.GetType()} - Area = {f.Area()} m^2");
            }

        }
    }
}
