using System;

namespace MatematicaClassLibrary
{
    /// <summary>
    /// The main <c>Math</c> class.
    /// Contains all methods for performing basic math functions.
    /// <list type="table">
    /// <item>
    /// <term>Add</term>
    /// <description>Addition Operation</description>
    /// </item>
    /// <item>
    /// <term>Subtract</term>
    /// <description>Subtraction Operation</description>
    /// </item>
    /// <item>
    /// <term>Multiply</term>
    /// <description>Multiplication Operation</description>
    /// </item>
    /// <item>
    /// <term>Divide</term>
    /// <description>Division Operation</description>
    /// </item>
    /// </list>
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
        /// See <see cref="Matematica.Somma(double, double)"/> to add doubles.
        /// <seealso cref="Matematica.Sottrazione(int, int)"/>
        /// <seealso cref="Matematica.Moltipicazione(int, int)"/>
        /// <seealso cref="Matematica.Divisione(int, int)"/>
        public static int Somma(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
                throw new OverflowException();
                
            return a + b;
        }

        /// <summary>
        /// Adds two doubles <paramref name="a"/> and <paramref name="b"/> and returns the result.
        /// </summary>
        /// <returns>
        /// The sum of two doubles.
        /// </returns>
        /// <exception cref="System.OverflowException">Thrown when one parameter is max 
        /// and the other is greater than zero.</exception>
        /// See <see cref="Matematica.Somma(int, int)"/> to add integers.
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

        /// <summary>
        /// Divides an double by another and returns the result.
        /// </summary>
        /// <returns>
        /// The division of two double.
        /// </returns>
        /// <exception cref="System.DivideByZeroException">Thrown when a division by zero occurs.</exception>

        public static double Divisione(double a, double b)
        {
            return a / b;
        }


        /// <summary>
        /// Checks if an IComparable is greater than another.
        /// </summary>
        /// <typeparam name="T">A type that inherits from the IComparable interface.</typeparam>
        public static bool GreaterThan<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0;
        }

    }
}
