namespace Britt2022.A.A.Contexts.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;
    using NGenerics.DataStructures.Trees;

    public interface IWGPMInputContext
    {
        ImmutableSortedSet<INullableValue<int>> Clusters { get; }

        Bundle Surgeons { get; }

        Bundle OperatingRooms { get; }

        RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        ImmutableList<PositiveInt> Scenarios { get; }

        ImmutableList<Tuple<Organization, PositiveInt, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgicalSpecialtyStrategicTargetNumberTimeBlocks { get; }

        ImmutableList<Tuple<Organization, PositiveInt, Duration>> SurgeonClusterDurationMeans { get; }

        ImmutableList<Tuple<Organization, PositiveInt, Duration>> SurgeonClusterDurationStandardDeviations { get; }

        ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonClusterFrequencies { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumLengthsOfStay { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMinimumNumberTimeBlocks { get; }

        ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonStrategicTargetNumberPatients { get; }

        ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> SurgeonScenarioMaximumNumberPatients { get; }

        ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonClusterOverheadTimeFactors { get; }

        ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        Duration TimeBlockLength { get; }

        INullableValue<decimal> GoalWeight1 { get; }

        INullableValue<decimal> GoalWeight2 { get; }

        INullableValue<decimal> GoalWeight3 { get; }

        INullableValue<decimal> GoalWeight4 { get; }

        ImmutableList<Tuple<Organization, Location, FhirBoolean>> SurgeonOperatingRoomAvailabilities { get; }

        ImmutableList<KeyValuePair<PositiveInt, FhirDecimal>> ScenarioProbabilities { get; }

        ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        ImmutableList<Tuple<Organization, FhirDateTime, FhirBoolean>> SurgeonDayAvailabilities { get; }
    }
}