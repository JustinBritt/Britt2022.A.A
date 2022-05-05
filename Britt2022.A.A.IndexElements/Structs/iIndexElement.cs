﻿namespace Britt2022.A.A.IndexElements.Structs
{
    public readonly struct iIndexElement
    {
        public const int SizeInBytes = 4;

        public iIndexElement(
            int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the surgeon.
        /// </summary>
        public int Value { get; }
    }
}