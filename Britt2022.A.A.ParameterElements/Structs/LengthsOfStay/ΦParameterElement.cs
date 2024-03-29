﻿namespace Britt2022.A.A.ParameterElements.Structs.LengthsOfStay
{
    public readonly struct ΦParameterElement
    {
        public const int SizeInBytes = 3 * sizeof(int) + 1 * sizeof(double);

        public ΦParameterElement(
            int iIndexElement,
            int lIndexElement,
            int ωIndexElement,
            double value)
        {
            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int lIndexElement { get; }

        public int ωIndexElement { get; }

        public double Value { get; }
    }
}