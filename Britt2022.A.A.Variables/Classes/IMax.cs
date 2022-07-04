namespace Britt2022.A.A.Variables.Classes
{
    using System;
    using System.Runtime.InteropServices;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ResultElements.InterfacesFactories.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public sealed class IMax : IIMax
    {
        public IMax(
            ReadOnlySpan<ωIndexElement> ω)
        {
            // IMax
            this.IMaxIntPtr = Marshal.AllocHGlobal(
                ω.Length
                *
                IMaxVariableElement.SizeInBytes);

            // MaximumValues
            this.MaximumValuesIntPtr = Marshal.AllocHGlobal(
                ω.Length
                *
                sizeof(double));
        }

        private IntPtr IMaxIntPtr { get; }

        private IntPtr MaximumValuesIntPtr { get; }

        public unsafe ReadOnlySpan<IMaxResultElement> GetElementsAt(
            IIMaxResultElementFactory IMaxResultElementFactory,
            PositiveInt[] scenarios,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<kωCrossJoinElement> kω,
            ReadOnlySpan<IVariableElement> I)
        {
            ReadOnlySpan<IMaxVariableElement> IMaxVariableSpan = this.GetValue(
                i,
                j,
                k,
                ω,
                kω,
                I);

            Span<IMaxResultElement> IMaxResultSpan = (Span<IMaxResultElement>)Array.CreateInstance(
                typeof(IMaxResultElement),
                ω.Length - 1);

            IMaxResultSpan.Clear();

            for (int w = 1; w < ω.Length; w = w + 1)
            {
                IMaxResultSpan[ω[w].Value - 1] = IMaxResultElementFactory.Create(
                    scenario: scenarios[ω[w].Value - 1],
                    value: (decimal)IMaxVariableSpan[ω[w].Value].Value);
            }

            return IMaxResultSpan;
        }

        public unsafe Span<IMaxVariableElement> GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<kωCrossJoinElement> kω,
            ReadOnlySpan<IVariableElement> I)
        {
            Span<double> maximumValuesSpan = new Span<double>(
                (void*)this.MaximumValuesIntPtr,
                ω.Length);

            maximumValuesSpan.Clear();

            Span<IMaxVariableElement> IMaxSpan = new Span<IMaxVariableElement>(
                (void*)this.IMaxIntPtr,
                ω.Length);

            IMaxSpan.Clear();

            fixed (IVariableElement * IPtr = I)
            fixed (IMaxVariableElement * IMaxSpanPtr = IMaxSpan)
            fixed (double * maximumValuesSpanPtr = maximumValuesSpan)
            {
                for (int w = 1; w < kω.Length; w = w + 1)
                {
                    if ((*(IPtr + kω[w].kωOI)).Value >= *(maximumValuesSpanPtr + kω[w].ωIndexElement))
                    {
                        *(maximumValuesSpanPtr + kω[w].ωIndexElement) = (*(IPtr + kω[w].kωOI)).Value;
                    }
                }

                for (int ωIndexElement = 1; ωIndexElement <= (ω.Length - 1); ωIndexElement = ωIndexElement + 1)
                {
                    *(IMaxSpanPtr + ωIndexElement) = new IMaxVariableElement(
                        ωIndexElement,
                        *(maximumValuesSpanPtr + ωIndexElement));
                }
            }

            return IMaxSpan;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                // IMax
                Marshal.FreeHGlobal(
                    this.IMaxIntPtr);

                // MaximumValues
                Marshal.FreeHGlobal(
                    this.MaximumValuesIntPtr);
            }
        }
    }
}