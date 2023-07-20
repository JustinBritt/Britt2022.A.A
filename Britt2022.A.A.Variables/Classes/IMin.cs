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

    public sealed class IMin : IIMin
    {
        public IMin(
            ReadOnlySpan<ωIndexElement> ω)
        {
            // IMin
            this.IMinIntPtr = Marshal.AllocHGlobal(
                ω.Length
                *
                IMinVariableElement.SizeInBytes);

            // MinimumValues
            this.MinimumValuesIntPtr = Marshal.AllocHGlobal(
                ω.Length
                *
                sizeof(double));
        }

        private IntPtr IMinIntPtr { get; }

        private IntPtr MinimumValuesIntPtr { get; }

        public unsafe ReadOnlySpan<IMinResultElement> GetElementsAt(
            IIMinResultElementFactory IMinResultElementFactory,
            INullableValue<int>[] scenarios,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<kωCrossJoinElement> kω,
            Span<IVariableElement> I)
        {
            Span<IMinVariableElement> IMinVariableSpan = this.GetValue(
                i,
                j,
                k,
                ω,
                kω,
                I);

            Span<IMinResultElement> IMinResultSpan = (Span<IMinResultElement>)Array.CreateInstance(
                typeof(IMinResultElement),
                ω.Length - 1);

            IMinResultSpan.Clear();

            for (int w = 1; w < ω.Length; w = w + 1)
            {
                IMinResultSpan[ω[w].Value - 1] = IMinResultElementFactory.Create(
                    scenario: scenarios[ω[w].Value - 1],
                    value: (decimal)IMinVariableSpan[ω[w].Value].Value);
            }

            return IMinResultSpan;
        }

        public unsafe Span<IMinVariableElement> GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<kωCrossJoinElement> kω,
            Span<IVariableElement> I)
        {
            Span<double> minimumValuesSpan = (Span<double>)Array.CreateInstance(
                typeof(double),
                ω.Length);

            minimumValuesSpan.Clear();

            minimumValuesSpan.Fill(
                double.MaxValue);

            Span<IMinVariableElement> IMinSpan = (Span<IMinVariableElement>)Array.CreateInstance(
                typeof(IMinVariableElement),
                ω.Length);

            IMinSpan.Clear();

            fixed (IVariableElement * IPtr = I)
            fixed (IMinVariableElement * IMinSpanPtr = IMinSpan)
            fixed (double * minimumValuesSpanPtr = minimumValuesSpan)
            {
                for (int w = 1; w < kω.Length; w = w + 1)
                {
                    if ((*(IPtr + kω[w].kωOI)).Value <= *(minimumValuesSpanPtr + kω[w].ωIndexElement))
                    {
                        *(minimumValuesSpanPtr + kω[w].ωIndexElement) = (*(IPtr + kω[w].kωOI)).Value;
                    }
                }

                for (int ωIndexElement = 1; ωIndexElement <= (ω.Length - 1); ωIndexElement = ωIndexElement + 1)
                {
                    *(IMinSpanPtr + ωIndexElement) = new IMinVariableElement(
                        ωIndexElement,
                        *(minimumValuesSpanPtr + ωIndexElement));
                }
            }

            return IMinSpan;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                // IMin
                Marshal.FreeHGlobal(
                    this.IMinIntPtr);

                // MinimumValues
                Marshal.FreeHGlobal(
                    this.MinimumValuesIntPtr);
            }
        }
    }
}