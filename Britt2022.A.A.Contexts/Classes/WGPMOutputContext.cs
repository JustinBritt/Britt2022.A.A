﻿namespace Britt2022.A.A.Contexts.Classes
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.ResultElements.Structs.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;

    public sealed class WGPMOutputContext : IWGPMOutputContext
    {
        public WGPMOutputContext(
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ReadOnlySpan<d1MinusResultElement> d1Minus,
            ReadOnlySpan<d1PlusResultElement> d1Plus,
            ReadOnlySpan<d2MinusResultElement> d2Minus,
            ReadOnlySpan<IResultElement> I,
            ReadOnlySpan<IMaxResultElement> IMax,
            ReadOnlySpan<IMinResultElement> IMin,
            decimal objectiveValue,
            TimeSpan overallWallTime,
            ReadOnlySpan<xResultElement> x)
        {
            // d1Minus(i, ω)
            this.SurgeonScenarioMinusDeviations = resultsAbstractFactory.Created1MinusFactory().Create().GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                d1Minus);

            // d1Plus(i, ω)
            this.SurgeonScenarioPlusDeviations = resultsAbstractFactory.Created1PlusFactory().Create().GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                d1Plus);

            // d2Minus(i, j, k, ω)
            this.SurgeonOperatingRoomDayScenarioDeviations = resultsAbstractFactory.Created2MinusFactory().Create().GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                d2Minus);

            // I(k, ω)
            this.DayScenarioRecoveryWardCensuses = resultsAbstractFactory.CreateIFactory().Create().GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                I);

            // IMax(ω)
            this.ScenarioRecoveryWardCensusMaximums = resultsAbstractFactory.CreateIMaxFactory().Create().GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                IMax);

            // IMin(ω)
            this.ScenarioRecoveryWardCensusMinimums = resultsAbstractFactory.CreateIMinFactory().Create().GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                IMin);

            // ObjectiveValue
            this.ObjectiveValue = dependenciesAbstractFactory.CreateNullableValueFactory().Create<decimal>(
                objectiveValue);

            // OverallWallTime
            this.OverallWallTime = overallWallTime;

            // x(i, j, k)
            this.SurgeonOperatingRoomDayAssignments = resultsAbstractFactory.CreatexFactory().Create().GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                x);
        }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioMinusDeviations { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> SurgeonScenarioPlusDeviations { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> SurgeonOperatingRoomDayScenarioDeviations { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioRecoveryWardCensusMaximums { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioRecoveryWardCensusMinimums { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> SurgeonOperatingRoomDayAssignments { get; }
    }
}