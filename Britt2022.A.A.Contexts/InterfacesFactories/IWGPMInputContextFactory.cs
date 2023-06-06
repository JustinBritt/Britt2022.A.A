namespace Britt2022.A.A.Contexts.InterfacesFactories
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Contexts.Interfaces;

    public interface IWGPMInputContextFactory
    {
        IWGPMInputContext Create(
               ImmutableSortedSet<INullableValue<int>> clusters,
               Bundle surgeons,
               Bundle operatingRooms,
               RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
               ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
               RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
               ImmutableSortedSet<INullableValue<int>> scenarios,
               RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
               RedBlackTree<Organization, INullableValue<int>> surgicalSpecialtyStrategicTargetNumberTimeBlocks,
               ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumNumberTimeBlocks,
               ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumLengthsOfStay,
               ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMinimumNumberTimeBlocks,
               ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonStrategicTargetNumberPatients,
               ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> surgeonScenarioMaximumNumberPatients,
               ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioLengthOfStayProbabilities,
               Duration timeBlockLength,
               INullableValue<decimal> goalWeight1,
               INullableValue<decimal> goalWeight2,
               INullableValue<decimal> goalWeight3,
               INullableValue<decimal> goalWeight4,
               ImmutableList<Tuple<Organization, Location, FhirBoolean>> surgeonOperatingRoomAvailabilities,
               ImmutableList<KeyValuePair<PositiveInt, FhirDecimal>> scenarioProbabilities,
               ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioCumulativeNumberPatients,
               ImmutableList<Tuple<Organization, FhirDateTime, FhirBoolean>> surgeonDayAvailabilities);
    }
}