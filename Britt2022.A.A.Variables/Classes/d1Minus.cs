namespace Britt2022.A.A.Variables.Classes
{
    using System;
    using System.Runtime.InteropServices;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    internal sealed class d1Minus : Id1Minus
    {
        public d1Minus(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω)
        {
            // d1Minus
            this.d1MinusIntPtr = Marshal.AllocHGlobal(
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

        private IntPtr d1MinusIntPtr { get; }

        private IntPtr SumsIntPtr { get; }

        public unsafe ReadOnlySpan<d1MinusResultElement> GetElementsAt(
            Id1MinusResultElementFactory d1MinusResultElementFactory,
            Organization[] surgeons,
            INullableValue<int>[] scenarios,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            Span<xVariableElement> x)
        {
            Span<d1MinusVariableElement> d1MinusVariableSpan = this.GetValue(
                i,
                ω,
                ijk,
                iω,
                N,
                niω,
                x);

            Span<d1MinusResultElement> d1MinusResultSpan = (Span<d1MinusResultElement>)Array.CreateInstance(
                typeof(d1MinusResultElement),
                iω.Length - 1);

            d1MinusResultSpan.Clear();

            for (int w = 1; w < iω.Length; w = w + 1)
            {
                d1MinusResultSpan[iω[w].iωZI] = d1MinusResultElementFactory.Create(
                    surgeon: surgeons[iω[w].iIndexElement - 1],
                    scenario: scenarios[iω[w].ωIndexElement - 1],
                    value: d1MinusVariableSpan[iω[w].iωOI].Value);
            }

            return d1MinusResultSpan;
        }

        public unsafe Span<d1MinusVariableElement> GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            Span<xVariableElement> x)
        {
            Span<int> sumsSpan = new Span<int>(
                (void*)this.SumsIntPtr,
                i.Length);

            sumsSpan.Clear();

            Span<d1MinusVariableElement> d1MinusSpan = new Span<d1MinusVariableElement>(
                (void*)this.d1MinusIntPtr,
                i.Length
                *
                ω.Length);

            d1MinusSpan.Clear();

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
                fixed (d1MinusVariableElement * d1MinusSpanPtr = d1MinusSpan)
                {
                    for (int w = 1; w < iω.Length; w = w + 1)
                    {
                        *(d1MinusSpanPtr + iω[w].iωOI) = new d1MinusVariableElement(
                            iω[w].iIndexElement,
                            iω[w].ωIndexElement,
                            Math.Max(
                                0,
                                (*(NPtr + iω[w].iIndexElement)).Value
                                -
                                (*(nPtr + iω[w].iωOI)).Value
                                *
                                *(sumsSpanPtr + iω[w].iIndexElement)));
                    }
                }
            }

            return d1MinusSpan;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                // d1Minus
                Marshal.FreeHGlobal(
                    this.d1MinusIntPtr);

                // Sums
                Marshal.FreeHGlobal(
                    this.SumsIntPtr);
            }
        }
    }
}