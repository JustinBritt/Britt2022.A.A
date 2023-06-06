namespace Britt2022.A.A.Contexts.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Contexts.Interfaces;

    public sealed class WGPMInputContext : IWGPMInputContext
    {
        public WGPMInputContext(
            ImmutableSortedSet<INullableValue<int>> clusters,
            Bundle surgeons,
            Bundle operatingRooms,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            ImmutableSortedSet<INullableValue<int>> scenarios,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            RedBlackTree<Organization, INullableValue<int>> surgicalSpecialtyStrategicTargetNumberTimeBlocks,
            ImmutableList<Tuple<Organization, PositiveInt, Duration>> surgeonClusterDurationMeans,
            ImmutableList<Tuple<Organization, PositiveInt, Duration>> surgeonClusterDurationStandardDeviations,
            ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> surgeonClusterFrequencies,
            RedBlackTree<Organization, INullableValue<int>> surgeonMaximumNumberTimeBlocks,
            RedBlackTree<Organization, INullableValue<int>> surgeonMaximumLengthsOfStay,
            RedBlackTree<Organization, INullableValue<int>> surgeonMinimumNumberTimeBlocks,
            RedBlackTree<Organization, INullableValue<int>> surgeonStrategicTargetNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> surgeonScenarioMaximumNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> surgeonClusterOverheadTimeFactors,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioLengthOfStayProbabilities,
            Duration timeBlockLength,
            INullableValue<decimal> goalWeight1,
            INullableValue<decimal> goalWeight2,
            INullableValue<decimal> goalWeight3,
            INullableValue<decimal> goalWeight4,
            ImmutableList<Tuple<Organization, Location, FhirBoolean>> surgeonOperatingRoomAvailabilities,
            ImmutableList<KeyValuePair<PositiveInt, FhirDecimal>> scenarioProbabilities,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioCumulativeNumberPatients,
            ImmutableList<Tuple<Organization, FhirDateTime, FhirBoolean>> surgeonDayAvailabilities)
        {
            // e
            this.Clusters = clusters;

            // i
            this.Surgeons = surgeons;

            // j
            this.OperatingRooms = operatingRooms;

            // k
            this.PlanningHorizon = planningHorizon;

            // l
            this.LengthOfStayDays = lengthOfStayDays;

            // r
            this.SurgicalSpecialties = surgicalSpecialties;

            // ω
            this.Scenarios = scenarios;

            // A(i, ω)
            if (surgeonScenarioWeightedAverageSurgicalDurations != null)
            {
                this.SurgeonScenarioWeightedAverageSurgicalDurations = surgeonScenarioWeightedAverageSurgicalDurations;
            }

            // B(r)
            this.SurgicalSpecialtyStrategicTargetNumberTimeBlocks = surgicalSpecialtyStrategicTargetNumberTimeBlocks;

            // D(i, e, ω) (Means)
            if (surgeonClusterDurationMeans != null)
            {
                this.SurgeonClusterDurationMeans = surgeonClusterDurationMeans;
            }

            // D(i, e, ω) (Standard deviations)
            if (surgeonClusterDurationStandardDeviations != null)
            {
                this.SurgeonClusterDurationStandardDeviations = surgeonClusterDurationStandardDeviations;
            }

            // f(i, e)
            if (surgeonClusterFrequencies != null)
            {
                this.SurgeonClusterFrequencies = surgeonClusterFrequencies;
            }

            // H(i)
            this.SurgeonMaximumNumberTimeBlocks = surgeonMaximumNumberTimeBlocks;

            // h(i)
            this.SurgeonMaximumLengthsOfStay = surgeonMaximumLengthsOfStay;

            // L(i)
            this.SurgeonMinimumNumberTimeBlocks = surgeonMinimumNumberTimeBlocks;

            // N(i)
            this.SurgeonStrategicTargetNumberPatients = surgeonStrategicTargetNumberPatients;

            // n(i, ω)
            this.SurgeonScenarioMaximumNumberPatients = surgeonScenarioMaximumNumberPatients;

            // O(i, e)
            if (surgeonClusterOverheadTimeFactors != null)
            {
                this.SurgeonClusterOverheadTimeFactors = surgeonClusterOverheadTimeFactors;
            }

            // p(i, l, ω)
            if (surgeonDayScenarioLengthOfStayProbabilities != null)
            {
                this.SurgeonDayScenarioLengthOfStayProbabilities = surgeonDayScenarioLengthOfStayProbabilities;
            }

            // v
            this.TimeBlockLength = timeBlockLength;

            // w1
            this.GoalWeight1 = goalWeight1;

            // w2
            this.GoalWeight2 = goalWeight2;

            // w3
            this.GoalWeight3 = goalWeight3;

            // w4
            this.GoalWeight4 = goalWeight4;

            this.SurgeonOperatingRoomAvailabilities = surgeonOperatingRoomAvailabilities;

            this.ScenarioProbabilities = scenarioProbabilities;

            this.SurgeonDayScenarioCumulativeNumberPatients = surgeonDayScenarioCumulativeNumberPatients;

            this.SurgeonDayAvailabilities = surgeonDayAvailabilities;
        }

        /// <summary>
        /// Gets the clusters.
        /// Parameter: e
        /// </summary>
        public ImmutableSortedSet<INullableValue<int>> Clusters { get; }

        /// <summary>
        /// Gets the surgeons.
        /// Parameter: i
        /// </summary>
        public Bundle Surgeons { get; }

        /// <summary>
        /// Gets the operating rooms.
        /// Parameter: j
        /// </summary>
        public Bundle OperatingRooms { get; }

        /// <summary>
        /// Gets the planning horizon.
        /// Parameter: k
        /// </summary>
        public RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        /// <summary>
        /// Gets the length of stay days.
        /// Parameter: l
        /// </summary>
        public ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        /// <summary>
        /// Gets the surgical specialties
        /// Parameter: r
        /// </summary>
        public RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        /// <summary>
        /// Gets the scenarios
        /// Parameter: ω
        /// </summary>
        public ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        /// <summary>
        /// 
        /// Parameter: A
        /// </summary>
        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        /// <summary>
        /// 
        /// Parameter: B
        /// </summary>
        public RedBlackTree<Organization, INullableValue<int>> SurgicalSpecialtyStrategicTargetNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: D (Means)
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, Duration>> SurgeonClusterDurationMeans { get; }

        /// <summary>
        /// 
        /// Parameter: D (Standard deviations)
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, Duration>> SurgeonClusterDurationStandardDeviations { get; }

        /// <summary>
        /// 
        /// Parameter: f
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonClusterFrequencies { get; }

        /// <summary>
        /// 
        /// Parameter: H
        /// </summary>
        public RedBlackTree<Organization, INullableValue<int>> SurgeonMaximumNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: h
        /// </summary>
        public RedBlackTree<Organization, INullableValue<int>> SurgeonMaximumLengthsOfStay { get; }

        /// <summary>
        /// 
        /// Parameter: L
        /// </summary>
        public RedBlackTree<Organization, INullableValue<int>> SurgeonMinimumNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: N
        /// </summary>
        public RedBlackTree<Organization, INullableValue<int>> SurgeonStrategicTargetNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: n
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> SurgeonScenarioMaximumNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: O
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, FhirDecimal>> SurgeonClusterOverheadTimeFactors { get; }

        /// <summary>
        /// 
        /// Parameter: p
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        /// <summary>
        /// Gets the time block length.
        /// Parameter: v
        /// </summary>
        public Duration TimeBlockLength { get; }

        /// <summary>
        /// 
        /// Parameter: w1
        /// </summary>
        public INullableValue<decimal> GoalWeight1 { get; }

        /// <summary>
        /// 
        /// Parameter: w2
        /// </summary>
        public INullableValue<decimal> GoalWeight2 { get; }

        /// <summary>
        /// 
        /// Parameter: w3
        /// </summary>
        public INullableValue<decimal> GoalWeight3 { get; }

        /// <summary>
        /// 
        /// Parameter: w4
        /// </summary>
        public INullableValue<decimal> GoalWeight4 { get; }

        /// <summary>
        /// 
        /// Parameter: Π
        /// </summary>
        public ImmutableList<Tuple<Organization, Location, FhirBoolean>> SurgeonOperatingRoomAvailabilities { get; }

        /// <summary>
        /// 
        /// Parameter: Ρ
        /// </summary>
        public ImmutableList<KeyValuePair<PositiveInt, FhirDecimal>> ScenarioProbabilities { get; }

        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: Ω
        /// </summary>
        public ImmutableList<Tuple<Organization, FhirDateTime, FhirBoolean>> SurgeonDayAvailabilities { get; }
    }
}