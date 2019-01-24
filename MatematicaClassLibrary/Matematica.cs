using System;
using System.Collections.Generic;
using System.Text;

namespace MatematicaClassLibrary
{
    /// <summary>
    /// La principale <c>Matematica</c> classe.
    /// Contiene metodi statici per eseguire funzioni matematiche.
    /// </summary>
    /// <remarks>
    /// <para>This class can add, subtract, multiply and divide.</para>
    /// <para>These operations can be performed on both integers and doubles.</para>
    /// </remarks>
    public class Matematica
    {

        /// <value>Ottiene il valore di Pi Greco.</value>
        public static double PI_GRECO { get; } = 3.141549;

        /// <summary>
        /// Somma due numeri interi e restituisce il risultato.
        /// </summary>
        /// <param name="a">Primo numero da sommare.</param>
        /// <param name="b">Secondo numero da sommare.</param>
        /// <returns>Restituisce la somma dei due numeri.</returns>
        /// <example>
        /// <code>
        /// int c = Matematica.Somma(4, 5);
        /// if (c > 10)
        /// {
        ///     Console.WriteLine(c);
        /// }
        /// </code>
        /// </example>
        /// <exception cref="OverflowException">Thrown when one parameter is max 
        /// and the other is greater than 0.</exception>
        public static int Somma(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new OverflowException();
                      
            return a + b;
        }

        public static double Somma(double a, double b)
        {
            if ((a == double.MaxValue && b > 0) || (b == double.MaxValue && a > 0))
                throw new OverflowException();

            return a + b;
        }

        public static int Sottrazione(int a, int b)
        {
            return a - b;
        }

        public static double Sottrazione(double a, double b)
        {
            return a - b;
        }

        public static int Moltipicazione(int a, int b)
        {
            return a * b;
        }

        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides an integer by another and returns the result.
        /// </summary>
        /// <returns>
        /// The division of two integers.
        /// </returns>
        /// <exception cref="DivideByZeroException">Thrown when a division by zero occurs.</exception>
        public static int Divisione(int a, int b)
        {
            return a / b;
        }

        public static double Divisione(double a, double b)
        {
            return a / b;
        }


    }
}
