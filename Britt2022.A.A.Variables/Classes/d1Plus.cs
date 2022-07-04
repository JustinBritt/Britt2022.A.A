namespace Britt2022.A.A.Variables.Classes
{
    using System;
    using System.Runtime.InteropServices;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public sealed class d1Plus : Id1Plus
    {
        public d1Plus(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω)
        {
            // d1Plus
            this.d1PlusIntPtr = Marshal.AllocHGlobal(
                i.Length
                *
                ω.Length
                *
                d1MinusVariableElement.SizeInBytes);

            // Sums
            this.SumsIntPtr = Marshal.AllocHGlobal(
                i.Length
                *
                sizeof(int));
        }

        private IntPtr d1PlusIntPtr { get; }

        private IntPtr SumsIntPtr { get; }

        public unsafe ReadOnlySpan<d1PlusResultElement> GetElementsAt(
            Organization[] surgeons,
            PositiveInt[] scenarios,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            ReadOnlySpan<xVariableElement> x)
        {
            ReadOnlySpan<d1PlusVariableElement> d1PlusVariableSpan = this.GetValue(
                i,
                ω,
                ijk,
                iω,
                N,
                niω,
                x);

            Span<d1PlusResultElement> d1PlusResultSpan = (Span<d1PlusResultElement>)Array.CreateInstance(
                typeof(d1PlusResultElement),
                iω.Length - 1);

            d1PlusResultSpan.Clear();

            for (int w = 1; w < iω.Length; w = w + 1)
            {
                d1PlusResultSpan[iω[w].iωZI] = new d1PlusResultElement(
                    surgeon: surgeons[iω[w].iIndexElement - 1],
                    scenario: scenarios[iω[w].ωIndexElement - 1],
                    value: d1PlusVariableSpan[iω[w].iωOI].Value);
            }

            return d1PlusResultSpan;
        }

        public unsafe ReadOnlySpan<d1PlusVariableElement> GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            ReadOnlySpan<xVariableElement> x)
        {
            Span<int> sumsSpan = new Span<int>(
                (void*)this.SumsIntPtr,
                i.Length);

            sumsSpan.Clear();

            Span<d1PlusVariableElement> d1PlusSpan = new Span<d1PlusVariableElement>(
                (void*)this.d1PlusIntPtr,
                i.Length
                *
                ω.Length);

            d1PlusSpan.Clear();

            fixed (int * sumsSpanPtr = sumsSpan)
            {
                fixed (xVariableElement * xPtr = x)
                {
                    for (int w = 1; w < ijk.Length; w = w + 1)
                    {
                        *(sumsSpanPtr + ijk[w].iIndexElement) += (*(xPtr + ijk[w].ijkOI)).Value;
                    }
                }

                fixed (niωParameterElement * nPtr = niω)
                fixed (NParameterElement * NPtr = N)
                fixed (d1PlusVariableElement * d1PlusSpanPtr = d1PlusSpan)
                {
                    for (int w = 1; w < iω.Length; w = w + 1)
                    {
                        *(d1PlusSpanPtr + iω[w].iωOI) = new d1PlusVariableElement(
                            iω[w].iIndexElement,
                            iω[w].ωIndexElement,
                            Math.Max(
                                0,
                                (*(nPtr + iω[w].iωOI)).Value
                                *
                                *(sumsSpanPtr + iω[w].iIndexElement)
                                -
                                (*(NPtr + iω[w].iIndexElement)).Value));
                    }
                }
            }

            return d1PlusSpan;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                // d1Plus
                Marshal.FreeHGlobal(
                    this.d1PlusIntPtr);

                // Sums
                Marshal.FreeHGlobal(
                    this.SumsIntPtr);
            }
        }
    }
}