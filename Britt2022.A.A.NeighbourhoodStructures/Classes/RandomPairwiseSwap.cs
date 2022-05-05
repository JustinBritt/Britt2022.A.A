namespace Britt2022.A.A.NeighbourhoodStructures.Classes
{
    using System;

    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.NeighbourhoodStructures.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;

    public sealed class RandomPairwiseSwap : IRandomPairwiseSwap
    {
        public RandomPairwiseSwap()
        {
        }

        public bool SwapMade { get; set; }

        private int Offset1 { get; set; }

        private int Offset2 { get; set; }

        private int Offset3 { get; set; }

        private int Offset4 { get; set; }

        private int Status { get; set; }

        public unsafe void Swap(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            Span<xVariableElement> x)
        {
            fixed (xVariableElement * xPtr = x)
            {
                this.SwapMade = false;

                int m = i.Length - 1;
                int mn = (i.Length - 1) * (j.Length - 1);
                int T = k.Length - 1;

                Random randomUniform = new Random();

                // Select random surgical specialty
                int surgicalSpecialty = randomUniform.Next(1, r.Length);

                int iE = randomUniform.Next(B1[surgicalSpecialty].Value, F2[surgicalSpecialty].Value + 1);
                int jE = randomUniform.Next(1, j.Length);
                int kE = randomUniform.Next(1, k.Length);

                int i2 = randomUniform.Next(B1[surgicalSpecialty].Value, F2[surgicalSpecialty].Value + 1);
                int j2 = randomUniform.Next(1, j.Length);
                int k2 = randomUniform.Next(1, k.Length);

                // Swaps
                this.Offset1 = iE + (jE * m) + (kE * mn);
                this.Offset2 = i2 + (j2 * m) + (k2 * mn);

                if (
                    (*(xPtr + this.Offset1)).Value == 0
                    &&
                    (*(xPtr + this.Offset2)).Value == 1)
                {
                    this.Status = 1;

                    (*(xPtr + this.Offset1)).Value = 1;

                    (*(xPtr + this.Offset2)).Value = 0;

                    this.SwapMade = true;
                }
                else if (
                    (*(xPtr + this.Offset1)).Value == 1
                    &&
                    (*(xPtr + this.Offset2)).Value == 0)
                {
                    this.Status = 2;

                    (*(xPtr + this.Offset1)).Value = 0;

                    (*(xPtr + this.Offset2)).Value = 1;

                    this.SwapMade = true;
                }
                else if (
                    (*(xPtr + this.Offset1)).Value == 1
                    &&
                    (*(xPtr + this.Offset2)).Value == 1)
                {
                    this.Status = 3;

                    this.Offset3 = iE + (j2 * m) + (k2 * mn);
                    this.Offset4 = i2 + (jE * m) + (kE * mn);

                    (*(xPtr + this.Offset1)).Value = 0;
                    (*(xPtr + this.Offset2)).Value = 0;

                    (*(xPtr + this.Offset3)).Value = 1;
                    (*(xPtr + this.Offset4)).Value = 1;

                    this.SwapMade = true;
                }
                else if (
                    (*(xPtr + this.Offset1)).Value == 0
                    &&
                    (*(xPtr + this.Offset2)).Value == 0)
                {
                    this.Status = 4;

                    this.SwapMade = false;
                }
            }
        }

        public unsafe void UndoSwap(
            Span<xVariableElement> x)
        {
            fixed (xVariableElement * xPtr = x)
            {
                if (this.Status == 1)
                {
                    (*(xPtr + this.Offset1)).Value = 0;

                    (*(xPtr + this.Offset2)).Value = 1;
                }
                else if (this.Status == 2)
                {
                    (*(xPtr + this.Offset1)).Value = 1;

                    (*(xPtr + this.Offset2)).Value = 0;
                }
                else if (this.Status == 3)
                {
                    (*(xPtr + this.Offset3)).Value = 0;
                    (*(xPtr + this.Offset4)).Value = 0;

                    (*(xPtr + this.Offset1)).Value = 1;
                    (*(xPtr + this.Offset2)).Value = 1;
                }
            }
        }
    }
}