namespace Britt2022.A.A.Constraints.Classes
{
    using System;
    using System.Runtime.InteropServices;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class Constraints3 : IConstraints3
    {
        public Constraints3(
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k)
        {
            // Sums
            this.SumsIntPtr = Marshal.AllocHGlobal(
                j.Length
                *
                k.Length
                *
                sizeof(int));
        }

        private IntPtr SumsIntPtr { get; }

        public unsafe bool IsFeasible(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<jkCrossJoinElement> jk,
            Span<xVariableElement> x)
        {
            bool feasible = true;

            Span<int> sumsSpan = new Span<int>(
                (void*)this.SumsIntPtr,
                j.Length
                *
                k.Length);

            sumsSpan.Clear();

            fixed (xVariableElement * xPtr = x)
            fixed (int * sumsSpanPtr = sumsSpan)
            {
                for (int w = 1; w < ijk.Length; w = w + 1)
                {
                    *(sumsSpanPtr + ijk[w].jkOI) += (*(xPtr + ijk[w].ijkOI)).Value;
                }

                for (int w = 1; w < jk.Length; w = w + 1)
                {
                    if (*(sumsSpanPtr + jk[w].jkOI) > 1)
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