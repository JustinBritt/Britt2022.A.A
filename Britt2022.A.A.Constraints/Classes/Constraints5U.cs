namespace Britt2022.A.A.Constraints.Classes
{
    using System;
    using System.Runtime.InteropServices;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class Constraints5U : IConstraints5U
    {
        public Constraints5U(
            ReadOnlySpan<iIndexElement> i)
        {
            // Sums
            this.SumsIntPtr = Marshal.AllocHGlobal(
                i.Length
                *
                sizeof(int));
        }

        private IntPtr SumsIntPtr { get; }

        public unsafe bool IsFeasible(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<HParameterElement> H,
            Span<xVariableElement> x)
        {
            bool feasible = true;

            Span<int> sumsSpan = new Span<int>(
                (void*)this.SumsIntPtr,
                i.Length);

            sumsSpan.Clear();

            fixed (HParameterElement * HPtr = H)
            fixed (xVariableElement * xPtr = x)
            fixed (int * sumsSpanPtr = sumsSpan)
            {
                for (int w = 1; w < ijk.Length; w = w + 1)
                {
                    *(sumsSpanPtr + ijk[w].iIndexElement) += (*(xPtr + ijk[w].ijkOI)).Value;
                }

                for (int iIndexElement = 1; iIndexElement <= (i.Length - 1); iIndexElement = iIndexElement + 1)
                {
                    if (*(sumsSpanPtr + iIndexElement) > (*(HPtr + iIndexElement)).Value)
                    {
                        feasible = false;

                        return feasible;
                    }
                }
            }

            return feasible;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                // Sums
                Marshal.FreeHGlobal(
                    this.SumsIntPtr);
            }
        }
    }
}