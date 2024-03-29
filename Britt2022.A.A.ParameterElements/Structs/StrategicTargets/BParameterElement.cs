﻿namespace Britt2022.A.A.ParameterElements.Structs.StrategicTargets
{
    public readonly struct BParameterElement
    {
        public const int SizeInBytes = 2 * sizeof(int);

        public BParameterElement(
            int rIndexElement,
            int value)
        {
            this.rIndexElement = rIndexElement;

            this.Value = value;
        }

        public int rIndexElement { get; }

        public int Value { get; }
    }
}