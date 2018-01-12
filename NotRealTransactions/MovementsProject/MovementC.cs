// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MovementC.cs" company="Farfetch, Lda">
//   Copyright (c) Farfetch. All rights reserved.
// </copyright>
// <summary>
// MovementC
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace MovementsProject
{
    /// <summary>
    /// MovementC
    /// </summary>
    public class MovementC : Movements
    {
        public override void sayHello()
        {
            Console.WriteLine("Hello I am C");
        }

        public override string whatImI()
        {
            throw new System.NotImplementedException();
        }

        public override string whatsMyName()
        {
            return base.whatsMyName();
        }
    }
}