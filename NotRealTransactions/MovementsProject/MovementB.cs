// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MovementB.cs" company="Farfetch, Lda">
//   Copyright (c) Farfetch. All rights reserved.
// </copyright>
// <summary>
// MovementB
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MovementsProject
{
    /// <summary>
    /// MovementB
    /// </summary>
    internal class MovementB : Movements
    {
        public override void sayHello()
        {
            Console.WriteLine("Hello I am B");
        }

        public override string whatImI()
        {
            throw new System.NotImplementedException();
        }

        public override string whatsMyName()
        {
            return "My name is B";
        }
    }
}