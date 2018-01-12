﻿// --------------------------------------------------------------------------------------------------------------------
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
            Console.WriteLine("LONG:\n\t* Long is " + sizeof(long) + " Bytes long \n\t* Default Value is " + default(long) + "\n\t* Type is " + typeof(long));

            Console.WriteLine("\n");

            Console.WriteLine("DECIMAL:\n\t* Decimal is " + sizeof(decimal) + " Bytes long \n\t* Default Value is " + default(decimal) + "\n\t* Type is " + typeof(decimal));

            Console.WriteLine("\n");

            Console.WriteLine("DOUBLE:\n\t* Double is " + sizeof(double) + " Bytes long \n\t* Default Value is " + default(double) + "\n\t* Type is " + typeof(double));

            Console.WriteLine("\n");

            Console.WriteLine("OBJECT:\n\t* Object is 4" + " Bytes long \n\t* Default Value is " + default(Object) + "\n\t* Type is " + typeof(Object));

            Console.WriteLine("\n");

            Console.WriteLine("STRING:\n\t* String is 2" + " Bytes long \n\t* Default Value is " + default(string) + "\n\t* Type is " + typeof(string));

            Console.WriteLine("\n");

            Console.WriteLine("BOOLEAN:\n\t* Boolean is " + sizeof(bool) + " Bytes long \n\t* Default Value is " + default(bool) + "\n\t* Type is " + typeof(bool));

            Console.WriteLine("\n\nEncapsulation:\n");
            Console.WriteLine("Protected members are visible only in derived classes. " +
                "\nInternal members are visible only in derived classes that are located in the same assembly as the base class. " +
                "\nThey are not visible in derived classes located in a different assembly from the base class. " +
                "\nPublic members are visible in derived classes and are part of the derived class' public interface.");

            Movements sonOfMovemets = new Context();

            Console.WriteLine("\n\nThe characteristic of being able to assign a different meaning or " +
                "\nusage to something in different contexts " +
                "\n-specifically, to allow an entity such as a variable, a function, or an object to have more than one form.");

            Console.WriteLine("\n\nHere's a message: " + sonOfMovemets.showMessage());

            Console.WriteLine("\n\nAbstraction:\n" + "The abstraction is done when we need to only inherit from a certain class,\n but not need to instantiate objects of that class. In such case the base " + "\nclass can be regarded as 'Incomplete'. Such classes are known as an 'Abstract Base Class'");

            Console.WriteLine("\n\nYou're supposed to be Movements but you're different!\n" + sonOfMovemets.whatImI());

            Console.ReadLine();
        }
    }
}