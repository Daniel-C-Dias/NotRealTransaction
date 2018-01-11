// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Main.cs" company="Farfetch, Lda">
//   Copyright (c) Farfetch. All rights reserved.
// </copyright>
// <summary>
// Main
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MovementsProject
{
    using System;

    /// <summary>
    /// Main
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("LONG:\n\t * Long is " + sizeof(long) + "Bytes long \n\t* Default Value is " + default(long) + "\n\t* Type is " + typeof(long));

            Console.WriteLine("\n");

            Console.WriteLine("DECIMAL:\n\t * Decimal is " + sizeof(decimal) + "Bytes long \n\t* Default Value is " + default(decimal) + "\n\t* Type is " + typeof(decimal));

            Console.WriteLine("\n");

            Console.WriteLine("DOUBLE:\n\t * Double is " + sizeof(double) + "Bytes long \n\t* Default Value is " + default(double) + "\n\t* Type is " + typeof(double));

            Console.WriteLine("\n");

            Console.WriteLine("OBJECT:\n\t * Double is 32" + "Bytes long \n\t* Default Value is " + default(Object) + "\n\t* Type is " + typeof(Object));

            Console.ReadLine();
        }
    }
}