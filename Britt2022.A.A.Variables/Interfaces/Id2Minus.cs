﻿namespace Britt2022.A.A.Variables.Interfaces
{
    using System;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.VariableElements.Structs;

    public interface Id2Minus : IDisposable
    {
        ReadOnlySpan<d2MinusResultElement> GetElementsAt(
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
            Span<xVariableElement> x);

        Span<d2MinusVariableElement> GetValue(
            double v,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkωCrossJoinElement> ijkω,
            ReadOnlySpan<AParameterElement> A,
            ReadOnlySpan<niωParameterElement> niω,
            Span<xVariableElement> x);
    }
}