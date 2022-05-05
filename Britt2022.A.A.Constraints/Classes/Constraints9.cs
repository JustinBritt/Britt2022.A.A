namespace Britt2022.A.A.Constraints.Classes
{
    using System;
    using System.Runtime.InteropServices;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;

    internal sealed class Constraints9 : IConstraints9
    {
        public Constraints9(
            ReadOnlySpan<rIndexElement> r)
        {
            // Sums
            this.SumsIntPtr = Marshal.AllocHGlobal(
                r.Length
                *
                sizeof(int));
        }

        private IntPtr SumsIntPtr { get; }

        public unsafe bool IsFeasible(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            ReadOnlySpan<BParameterElement> B,
            Span<xVariableElement> x)
        {
            bool feasible = true;

            Span<int> sumsSpan = new Span<int>(
                (void*)this.SumsIntPtr,
                r.Length);

            sumsSpan.Clear();

            fixed (ijkCrossJoinElement * ijkPtr = ijk)
            fixed (BParameterElement * BPtr = B)
            fixed (xVariableElement * xPtr = x)
            fixed (int * sumsSpanPtr = sumsSpan)
            {
                for (int rIndexElement = 1; rIndexElement <= (r.Length - 1); rIndexElement = rIndexElement + 1)
                {
                    for (int iIndexElement = B1[rIndexElement].Value; iIndexElement <= F2[rIndexElement].Value; iIndexElement = iIndexElement + 1)
                    {
                        for (int jIndexElement = 1; jIndexElement <= (j.Length - 1); jIndexElement = jIndexElement + 1)
                        {
                            for (int kIndexElement = 1; kIndexElement <= (k.Length - 1); kIndexElement = kIndexElement + 1)
                            {
                                *(sumsSpanPtr + rIndexElement) += (*(xPtr + iIndexElement + (jIndexElement * (i.Length - 1)) + (kIndexElement * (i.Length - 1) * (j.Length - 1)))).Value;
                            }
                        }
                    }

                    if (*(sumsSpanPtr + rIndexElement) != (*(BPtr + rIndexElement)).Value)
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