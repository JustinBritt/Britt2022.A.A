namespace Britt2022.A.A.Variables.Classes
{
    using System;
    using System.Runtime.InteropServices;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ResultElements.InterfacesFactories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public sealed class I : II
    {
        public I(
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω)
        {
            // I
            this.IIntPtr = Marshal.AllocHGlobal(
                k.Length
                *
                ω.Length
                *
                IVariableElement.SizeInBytes);

            // Sums
            this.SumsIntPtr = Marshal.AllocHGlobal(
                k.Length
                *
                ω.Length
                *
                sizeof(double));
        }

        private IntPtr IIntPtr { get; }

        private IntPtr SumsIntPtr { get; }

        public unsafe ReadOnlySpan<IResultElement> GetElementsAt(
            IIResultElementFactory IResultElementFactory,
            FhirDateTime[] planningHorizon,
            INullableValue<int>[] scenarios,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<lIndexElement> l,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ilωCrossJoinElement> ilω,
            ReadOnlySpan<kωCrossJoinElement> kω,
            RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>> Φ,
            Span<xVariableElement> x)
        {
            Span<IVariableElement> IVariableSpan = this.GetValue(
                i,
                j,
                k,
                l,
                ω,
                ilω,
                Φ,
                x);

            Span<IResultElement> IResultSpan = (Span<IResultElement>)Array.CreateInstance(
                typeof(IResultElement),
                kω.Length - 1);

            IResultSpan.Clear();

            for (int w = 1; w < kω.Length; w = w + 1)
            {
                IResultSpan[kω[w].kωZI] = IResultElementFactory.Create(
                    day: planningHorizon[kω[w].kIndexElement - 1],
                    scenario: scenarios[kω[w].ωIndexElement - 1],
                    value: (decimal)IVariableSpan[kω[w].kωOI].Value);
            }

            return IResultSpan;
        }

        public unsafe Span<IVariableElement> GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<lIndexElement> l,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ilωCrossJoinElement> ilω,
            RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>> Φ,
            Span<xVariableElement> x)
        {
            Span<double> sumsSpan = (Span<double>)Array.CreateInstance(
                typeof(double),
                k.Length
                *
                ω.Length);

            sumsSpan.Clear();

            Span<IVariableElement> ISpan = (Span<IVariableElement>)Array.CreateInstance(
                typeof(IVariableElement),
                k.Length
                *
                ω.Length);

            ISpan.Clear();

            fixed (double * sumsSpanPtr = sumsSpan)
            {
                fixed (xVariableElement * xPtr = x)
                {
                    for (int iIndexElement = 1; iIndexElement < i.Length; iIndexElement = iIndexElement + 1)
                    {
                        for (int jIndexElement = 1; jIndexElement < j.Length; jIndexElement = jIndexElement + 1)
                        {
                            for (int kIndexElement = 1; kIndexElement < k.Length; kIndexElement = kIndexElement + 1)
                            {
                                for (int lIndexElement = 1; lIndexElement <= kIndexElement; lIndexElement = lIndexElement + 1)
                                {
                                    if ((*(xPtr + iIndexElement + (jIndexElement * (i.Length - 1)) + (lIndexElement * (i.Length - 1) * (j.Length - 1)))).Value == 1)
                                    {
                                        for (int ωIndexElement = 1; ωIndexElement < ω.Length; ωIndexElement = ωIndexElement + 1)
                                        {
                                            *(sumsSpanPtr + kIndexElement + (ωIndexElement * (k.Length - 1))) += (double)Φ[iIndexElement][kIndexElement - lIndexElement][ωIndexElement].Value;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    for (int iIndexElement = 1; iIndexElement < i.Length; iIndexElement = iIndexElement + 1)
                    {
                        for (int jIndexElement = 1; jIndexElement < j.Length; jIndexElement = jIndexElement + 1)
                        {
                            for (int kIndexElement = 1; kIndexElement < k.Length; kIndexElement = kIndexElement + 1)
                            {
                                for (int lIndexElement = kIndexElement + 1; lIndexElement < k.Length; lIndexElement = lIndexElement + 1)
                                {
                                    if ((*(xPtr + iIndexElement + (jIndexElement * (i.Length - 1)) + (lIndexElement * (i.Length - 1) * (j.Length - 1)))).Value == 1)
                                    {
                                        for (int ωIndexElement = 1; ωIndexElement < ω.Length; ωIndexElement = ωIndexElement + 1)
                                        {
                                            *(sumsSpanPtr + kIndexElement + (ωIndexElement * (k.Length - 1))) += (double)Φ[iIndexElement][kIndexElement - lIndexElement + (k.Length - 1)][ωIndexElement].Value;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    fixed (IVariableElement * IPtr = ISpan)
                    {
                        for (int kIndexElement = 1; kIndexElement < k.Length; kIndexElement = kIndexElement + 1)
                        {
                            for (int ωIndexElement = 1; ωIndexElement < ω.Length; ωIndexElement = ωIndexElement + 1)
                            {
                                *(IPtr + kIndexElement + (ωIndexElement * (k.Length - 1))) = new IVariableElement(
                                    kIndexElement,
                                    ωIndexElement,
                                    *(sumsSpanPtr + kIndexElement + (ωIndexElement * (k.Length - 1))));
                            }
                        }
                    }
                }
            }

            return ISpan;
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                // I
                Marshal.FreeHGlobal(
                    this.IIntPtr);

                // Sums
                Marshal.FreeHGlobal(
                    this.SumsIntPtr);
            }
        }
    }
}