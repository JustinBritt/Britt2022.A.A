namespace Britt2022.A.A.Variables.Interfaces
{
    using System;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;
    using Britt2022.A.A.VariableElements.Structs;

    public interface Id1Minus : IDisposable
    {
        ReadOnlySpan<d1MinusResultElement> GetElementsAt(
            Id1MinusResultElementFactory d1MinusResultElementFactory,
            Organization[] surgeons,
            PositiveInt[] scenarios,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            ReadOnlySpan<xVariableElement> x);

        ReadOnlySpan<d1MinusVariableElement> GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            ReadOnlySpan<xVariableElement> x);
    }
}