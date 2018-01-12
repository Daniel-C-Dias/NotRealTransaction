// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Context.cs" company="Farfetch, Lda">
//   Copyright (c) Farfetch. All rights reserved.
// </copyright>
// <summary>
// Context
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MovementsProject
{
    /// <summary>
    /// Context
    /// </summary>
    public class Context : Movements
    {
        public int newValue() => value;

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