namespace Britt2022.A.A.Variables.Classes
{
    using System;
    using System.Runtime.InteropServices;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public sealed class d2Minus : Id2Minus
    {
        public d2Minus(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω)
        {
            // d2Minus
            this.d2MinusIntPtr = Marshal.AllocHGlobal(
                i.Length
                *
                j.Length
                *
                k.Length
                *
                ω.Length
                *
                d2MinusVariableElement.SizeInBytes);
        }

        private IntPtr d2MinusIntPtr { get; }

        public unsafe ReadOnlySpan<d2MinusResultElement> GetElementsAt(
            Id2MinusResultElementFactory d2MinusResultElementFactory,
            Organization[] surgeons,
            Location[] operatingRooms,
            FhirDateTime[] planningHorizon,
            INullableValue<int>[] scenarios,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkωCrossJoinElement> ijkω,
            ReadOnlySpan<AParameterElement> A,
            ReadOnlySpan<niωParameterElement> niω,
            double v,
            Span<xVariableElement> x)
        {
            Span<d2MinusVariableElement> d2MinusVariableSpan = this.GetValue(
                v,
                i,
                j,
                k,
                ω,
                ijkω,
                A,
                niω,
                x);

            Span<d2MinusResultElement> d2MinusResultSpan = (Span<d2MinusResultElement>)Array.CreateInstance(
                typeof(d2MinusResultElement),
                ijkω.Length - 1);

            d2MinusResultSpan.Clear();

            for (int w = 1; w < ijkω.Length; w = w + 1)
            {
                d2MinusResultSpan[ijkω[w].ijkωZI] = d2MinusResultElementFactory.Create(
                    surgeon: surgeons[ijkω[w].iIndexElement - 1],
                    operatingRoom: operatingRooms[ijkω[w].jIndexElement - 1],
                    day: planningHorizon[ijkω[w].kIndexElement - 1],
                    scenario: scenarios[ijkω[w].ωIndexElement - 1],
                    value: (decimal)d2MinusVariableSpan[ijkω[w].ijkωOI].Value);
            }

            return d2MinusResultSpan;
        }

        public unsafe Span<d2MinusVariableElement> GetValue(
            double v,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkωCrossJoinElement> ijkω,
            ReadOnlySpan<AParameterElement> A,
            ReadOnlySpan<niωParameterElement> niω,
            Span<xVariableElement> x)
        {
            Span<d2MinusVariableElement> d2MinusSpan = new Span<d2MinusVariableElement>(
                (void*)this.d2MinusIntPtr,
                i.Length
                *
                j.Length
                *
                k.Length
                *
                ω.Length);

            d2MinusSpan.Clear();

            fixed (AParameterElement * APtr = A)
            fixed (niωParameterElement * nPtr = niω)
            fixed (xVariableElement * xPtr = x)
            fixed (d2MinusVariableElement * d2MinusPtr = d2MinusSpan)
            {
                for (int w = 1; w < ijkω.Length; w = w + 1)
                {
                    if ((*(xPtr + ijkω[w].ijkOI)).Value == 1)
                    {
                        *(d2MinusPtr + ijkω[w].ijkωOI) = new d2MinusVariableElement(
                            ijkω[w].iIndexElement,
                            ijkω[w].jIndexElement,
                            ijkω[w].kIndexElement,
                            ijkω[w].ωIndexElement,
                            v
                            -
                            ((*(APtr + ijkω[w].iωOI)).Value
                            *
                            (*(nPtr + ijkω[w].iωOI)).Value));
                    }
                }
            }

            return d2MinusSpan;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                // d2Minus
                Marshal.FreeHGlobal(
                    this.d2MinusIntPtr);
            }
        }
    }
}