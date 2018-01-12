// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MovementEnum.cs" company="Farfetch, Lda">
//   Copyright (c) Farfetch. All rights reserved.
// </copyright>
// <summary>
// MovementEnum
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections;

namespace MovementsProject
{
    /// <summary>
    /// MovementEnum
    /// </summary>
    internal class MovementEnum : IEnumerator
    {
        public Movements[] _movements;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        private int position = -1;

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Movements Current
        {
            get
            {
                try
                {
                    return _movements[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _movements.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}