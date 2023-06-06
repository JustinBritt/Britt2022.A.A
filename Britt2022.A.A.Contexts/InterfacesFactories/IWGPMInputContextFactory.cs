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
               RedBlackTree<Organization, INullableValue<int>> surgeonMaximumNumberTimeBlocks,
               RedBlackTree<Organization, INullableValue<int>> surgeonMaximumLengthsOfStay,
               RedBlackTree<Organization, INullableValue<int>> surgeonMinimumNumberTimeBlocks,
               RedBlackTree<Organization, INullableValue<int>> surgeonStrategicTargetNumberPatients,
               RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
               RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> surgeonDayScenarioLengthOfStayProbabilities,
               Duration timeBlockLength,
               INullableValue<decimal> goalWeight1,
               INullableValue<decimal> goalWeight2,
               INullableValue<decimal> goalWeight3,
               INullableValue<decimal> goalWeight4,
               RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> surgeonOperatingRoomAvailabilities,
               RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
               ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioCumulativeNumberPatients,
               ImmutableList<Tuple<Organization, FhirDateTime, FhirBoolean>> surgeonDayAvailabilities);
    }
}