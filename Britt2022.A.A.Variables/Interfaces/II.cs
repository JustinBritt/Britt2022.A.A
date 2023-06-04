namespace Britt2022.A.A.Variables.Interfaces
{
    using System;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ResultElements.InterfacesFactories.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.VariableElements.Structs;

    public interface II : IDisposable
    {
        ReadOnlySpan<IResultElement> GetElementsAt(
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
            ReadOnlySpan<ΦParameterElement> Φ,
            Span<xVariableElement> x);

        Span<IVariableElement> GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<lIndexElement> l,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ilωCrossJoinElement> ilω,
            ReadOnlySpan<ΦParameterElement> Φ,
            Span<xVariableElement> x);
    }
}