// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MovementA.cs" company="Farfetch, Lda">
//   Copyright (c) Farfetch. All rights reserved.
// </copyright>
// <summary>
// MovementA
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MovementsProject
{
    /// <summary>
    /// MovementA
    /// </summary>
    public class MovementA : Movements
    {
        public override void sayHello()
        {
            Console.WriteLine("Hello I am A");
        }

        public override string whatImI()
        {
            throw new System.NotImplementedException();
        }

        public override string whatsMyName()
        {
            return "My name is A";
        }
    }
}