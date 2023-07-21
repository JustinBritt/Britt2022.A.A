namespace Britt2022.A.A.Contexts.Interfaces
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IWGPMOutputContext
    {
        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMinusDeviations { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioPlusDeviations { get; }

        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<int>, INullableValue<decimal>>> SurgeonOperatingRoomDayScenarioDeviations { get; }

        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioRecoveryWardCensusMaximums { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioRecoveryWardCensusMinimums { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> SurgeonOperatingRoomDayAssignments { get; }
    }
}