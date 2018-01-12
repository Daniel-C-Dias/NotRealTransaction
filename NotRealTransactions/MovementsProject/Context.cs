// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Context.cs" company="Farfetch, Lda">
//   Copyright (c) Farfetch. All rights reserved.
// </copyright>
// <summary>
// Context
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MovementsProject
{
    /// <summary>
    /// Context
    /// </summary>
    public class Context : Movements
    {
        public int newValue() => value;

        public override void sayHello()
        {
            Console.WriteLine("Hello I am Context");
        }

        public string showMessage()
        {
            return "Movements is dead, long live Context";
        }

        public override string whatImI()
        {
            return "It is I Context! I have return to finish the job!";
        }
    }
}