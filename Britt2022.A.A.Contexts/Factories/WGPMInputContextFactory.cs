﻿namespace Britt2022.A.A.Contexts.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Contexts.Classes;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Contexts.InterfacesFactories;

    public sealed class WGPMInputContextFactory : IWGPMInputContextFactory
    {
        public WGPMInputContextFactory()
        {
        }

        public IWGPMInputContext Create(
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
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> surgeonDayScenarioCumulativeNumberPatients,
            RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> surgeonDayAvailabilities,
            RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> surgeonOperatingRoomDayAssignments = null)
        {
            IWGPMInputContext context = null;

            try
            {
                context = new WGPMInputContext(
                    clusters,
                    surgeons,
                    operatingRooms,
                    planningHorizon,
                    lengthOfStayDays,
                    surgicalSpecialties,
                    scenarios,
                    surgeonScenarioWeightedAverageSurgicalDurations,
                    surgicalSpecialtyStrategicTargetNumberTimeBlocks,
                    null,
                    null,
                    null,
                    surgeonMaximumNumberTimeBlocks,
                    surgeonMaximumLengthsOfStay,
                    surgeonMinimumNumberTimeBlocks,
                    surgeonStrategicTargetNumberPatients,
                    surgeonScenarioMaximumNumberPatients,
                    null,
                    surgeonDayScenarioLengthOfStayProbabilities,
                    timeBlockLength,
                    goalWeight1,
                    goalWeight2,
                    goalWeight3,
                    goalWeight4,
                    surgeonOperatingRoomAvailabilities,
                    scenarioProbabilities,
                    surgeonDayScenarioCumulativeNumberPatients,
                    surgeonDayAvailabilities,
                    surgeonOperatingRoomDayAssignments);
            }
            finally
            {
            }

            return context;
        }
    }
}