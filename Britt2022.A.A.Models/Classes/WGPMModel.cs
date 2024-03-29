﻿namespace Britt2022.A.A.Models.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.CrossJoinElements.InterfacesAbstractFactories;
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.CrossJoins.Interfaces.Mappings;
    using Britt2022.A.A.CrossJoins.InterfacesAbstractFactories;
    using Britt2022.A.A.CrossJoins.InterfacesFactories.Mappings;
    using Britt2022.A.A.IndexElements.InterfacesAbstractFactories;
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.StrategicTargets;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.Surgeries;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.SurgicalSpecialties;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.InterfacesAbstractFactories;
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;

    public unsafe sealed class WGPMModel : IWGPMModel
    {
        // Note: This assumes that indices have numbered Ids.
        public unsafe WGPMModel(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IVariableElementsAbstractFactory variableElementsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext)
        {  
            // i
            this.iIndexElementFactory = indexElementsAbstractFactory.CreateiIndexElementFactory();

            this.Surgeons = WGPMInputContext
                .Surgeons
                .Entry
                .Where(w => w.Resource is Organization)
                .Select(w => (Organization)w.Resource)
                .ToArray();

            this.SurgeonsIntPtr = Marshal.AllocHGlobal(
                (this.Surgeons.Count() + 1)
                *
                iIndexElement.SizeInBytes);

            // j
            this.jIndexElementFactory = indexElementsAbstractFactory.CreatejIndexElementFactory();

            this.OperatingRooms = WGPMInputContext
                .OperatingRooms
                .Entry
                .Where(w => w.Resource is Location)
                .Select(w => (Location)w.Resource)
                .ToArray();

            this.OperatingRoomsIntPtr = Marshal.AllocHGlobal(
               (this.OperatingRooms.Count() + 1)
               *
               jIndexElement.SizeInBytes);

            // k
            this.kIndexElementFactory = indexElementsAbstractFactory.CreatekIndexElementFactory();

            IPlanningHorizonVisitor<INullableValue<int>, FhirDateTime> planningHorizonVisitor = contextsAbstractFactory.CreatePlanningHorizonVisitorFactory().Create<INullableValue<int>, FhirDateTime>();

            WGPMInputContext.PlanningHorizon.AcceptVisitor(
                planningHorizonVisitor);

            this.PlanningHorizon = planningHorizonVisitor.GetValue();

            this.PlanningHorizonIntPtr = Marshal.AllocHGlobal(
               (this.PlanningHorizon.Count() + 1)
               *
               kIndexElement.SizeInBytes);

            // l
            this.lIndexElementFactory = indexElementsAbstractFactory.CreatelIndexElementFactory();

            this.LengthOfStayDays = WGPMInputContext
                .LengthOfStayDays
                .ToArray();

            this.LengthOfStayDaysIntPtr = Marshal.AllocHGlobal(
               (this.LengthOfStayDays.Count() + 1)
               *
               lIndexElement.SizeInBytes);

            // r
            this.rIndexElementFactory = indexElementsAbstractFactory.CreaterIndexElementFactory();

            this.SurgicalSpecialties = WGPMInputContext
                .SurgicalSpecialties
                .Select(w => w.Key)
                .OrderBy(w => int.Parse(w.Id))
                .ToArray();

            this.SurgicalSpecialtiesIntPtr = Marshal.AllocHGlobal(
               (this.SurgicalSpecialties.Count() + 1)
               *
               rIndexElement.SizeInBytes);

            // ω
            this.ωIndexElementFactory = indexElementsAbstractFactory.CreateωIndexElementFactory();

            this.Scenarios = WGPMInputContext
                .Scenarios
                .ToArray();

            this.ScenariosIntPtr = Marshal.AllocHGlobal(
               (this.Scenarios.Count() + 1)
               *
               ωIndexElement.SizeInBytes);

            // ij
            this.ijCrossJoinElementFactory = crossJoinElementsAbstractFactory.CreateijCrossJoinElementFactory();

            this.ijIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.OperatingRooms.Count() + 1)
               *
               ijCrossJoinElement.SizeInBytes);

            // ijk
            this.ijkCrossJoinElementFactory = crossJoinElementsAbstractFactory.CreateijkCrossJoinElementFactory();

            this.ijkIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.OperatingRooms.Count() + 1)
               *
               (this.PlanningHorizon.Count() + 1)
               *
               ijkCrossJoinElement.SizeInBytes);

            // ijkω
            this.ijkωCrossJoinElementFactory = crossJoinElementsAbstractFactory.CreateijkωCrossJoinElementFactory();

            this.ijkωIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.OperatingRooms.Count() + 1)
               *
               (this.PlanningHorizon.Count() + 1)
               *
               (this.Scenarios.Count() + 1)
               *
               ijkωCrossJoinElement.SizeInBytes);

            // ik
            this.ikCrossJoinElementFactory = crossJoinElementsAbstractFactory.CreateikCrossJoinElementFactory();

            this.ikIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.PlanningHorizon.Count() + 1)
               *
               ikCrossJoinElement.SizeInBytes);

            // ilω
            this.ilωCrossJoinElementFactory = crossJoinElementsAbstractFactory.CreateilωCrossJoinElementFactory();

            this.ilωIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.LengthOfStayDays.Count() + 1)
               *
               (this.Scenarios.Count() + 1)
               *
               ilωCrossJoinElement.SizeInBytes);

            // iω
            this.iωCrossJoinElementFactory = crossJoinElementsAbstractFactory.CreateiωCrossJoinElementFactory();

            this.iωIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.Scenarios.Count() + 1)
               *
               iωCrossJoinElement.SizeInBytes);

            // jk
            this.jkCrossJoinElementFactory = crossJoinElementsAbstractFactory.CreatejkCrossJoinElementFactory();

            this.jkIntPtr = Marshal.AllocHGlobal(
               (this.OperatingRooms.Count() + 1)
               *
               (this.PlanningHorizon.Count() + 1)
               *
               jkCrossJoinElement.SizeInBytes);

            // kω
            this.kωCrossJoinElementFactory = crossJoinElementsAbstractFactory.CreatekωCrossJoinElementFactory();

            this.kωIntPtr = Marshal.AllocHGlobal(
               (this.PlanningHorizon.Count() + 1)
               *
               (this.Scenarios.Count() + 1)
               *
               kωCrossJoinElement.SizeInBytes);

            this.abMappingFactory = crossJoinsAbstractFactory.CreateabMappingFactory();

            this.abcMappingFactory = crossJoinsAbstractFactory.CreateabcMappingFactory();

            this.abcdMappingFactory = crossJoinsAbstractFactory.CreateabcdMappingFactory();

            ReadOnlySpan<ijCrossJoinElement> ij = this.Getij();

            ReadOnlySpan<ikCrossJoinElement> ik = this.Getik();

            ReadOnlySpan<iωCrossJoinElement> iω = this.Getiω();

            // A(i, ω)
            this.AParameterElementFactory = parameterElementsAbstractFactory.CreateAParameterElementFactory();

            var AArraySize = 1 + iω.ToArray().Select(w => w.iωOI).Max();
            var AArray = new Tuple<Organization, INullableValue<int>, Duration>[AArraySize];

            for (int i = 1; i < iω.Length; i = i + 1)
            {
                Organization surgeon = this.Surgeons[iω[i].iIndexElement - 1];

                INullableValue<int> scenario = this.Scenarios[iω[i].ωIndexElement - 1];

                AArray[iω[i].iωZI] =
                    Tuple.Create(
                        surgeon,
                        scenario,
                        WGPMInputContext.SurgeonScenarioWeightedAverageSurgicalDurations[surgeon][scenario]);
            }

            this.SurgeonScenarioWeightedAverageSurgicalDurations = AArray;

            this.SurgeonScenarioWeightedAverageSurgicalDurationsIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.Scenarios.Count() + 1)
               *
               AParameterElement.SizeInBytes);

            // B(r)
            this.BParameterElementFactory = parameterElementsAbstractFactory.CreateBParameterElementFactory();

            this.SurgicalSpecialtyStrategicTargetNumberTimeBlocks = WGPMInputContext.SurgicalSpecialtyStrategicTargetNumberTimeBlocks
                .OrderBy(w => int.Parse(w.Key.Id))
                .ToArray();

            this.SurgicalSpecialtyStrategicTargetNumberTimeBlocksIntPtr = Marshal.AllocHGlobal(
               (this.SurgicalSpecialties.Count() + 1)
               *
               BParameterElement.SizeInBytes);

            // B1(r), F2(r)
            this.B1ParameterElementFactory = parameterElementsAbstractFactory.CreateB1ParameterElementFactory();

            this.F2ParameterElementFactory = parameterElementsAbstractFactory.CreateF2ParameterElementFactory();

            B1ParameterElement[] B1OI = new B1ParameterElement[this.SurgicalSpecialties.Count() + 1];

            B1ParameterElement[] B1ZI = new B1ParameterElement[this.SurgicalSpecialties.Count()];

            F2ParameterElement[] F2OI = new F2ParameterElement[this.SurgicalSpecialties.Count() + 1];

            F2ParameterElement[] F2ZI = new F2ParameterElement[this.SurgicalSpecialties.Count()];

            int[] items = WGPMInputContext
                .SurgicalSpecialties
                .Select(w => KeyValuePair.Create(w.Key, w.Value))
                .OrderBy(w => int.Parse(w.Key.Id))
                .Select(w => w.Value.Count())
                .ToArray();

            for (int r = 1; r <= this.SurgicalSpecialties.Count(); r = r + 1)
            {
                F2OI[r] = this.F2ParameterElementFactory.Create(
                    F2OI[r - 1].Value + items[r - 1]);

                B1OI[r] = this.B1ParameterElementFactory.Create(
                    F2OI[r - 1].Value + 1);
            }

            for (int r = 0; r < this.SurgicalSpecialties.Count(); r = r + 1)
            {
                B1ZI[r] = B1OI[r + 1];

                F2ZI[r] = F2OI[r + 1];
            }

            this.SurgicalSpecialtyLowerBounds = B1ZI;

            this.SurgicalSpecialtyUpperBounds = F2ZI;

            this.SurgicalSpecialtyLowerBoundsIntPtr = Marshal.AllocHGlobal(
               (this.SurgicalSpecialties.Count() + 1)
               *
               B1ParameterElement.SizeInBytes);

            this.SurgicalSpecialtyUpperBoundsIntPtr = Marshal.AllocHGlobal(
               (this.SurgicalSpecialties.Count() + 1)
               *
               F2ParameterElement.SizeInBytes);

            // H(i)
            this.HParameterElementFactory = parameterElementsAbstractFactory.CreateHParameterElementFactory();

            List<KeyValuePair<Organization, INullableValue<int>>> HList = new List<KeyValuePair<Organization, INullableValue<int>>>();

            foreach (Organization surgeon in WGPMInputContext.Surgeons.Entry.Where(i => i.Resource is Organization).Select(i => (Organization)i.Resource))
            {
                HList.Add(
                    KeyValuePair.Create(
                        surgeon,
                        WGPMInputContext.SurgeonMaximumNumberTimeBlocks[surgeon]));
            }

            this.SurgeonMaximumNumberTimeBlocks = HList
                .OrderBy(w => int.Parse(w.Key.Id))
                .ToArray();

            this.SurgeonMaximumNumberTimeBlocksIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               HParameterElement.SizeInBytes);

            // L(i)
            this.LParameterElementFactory = parameterElementsAbstractFactory.CreateLParameterElementFactory();

            this.SurgeonMinimumNumberTimeBlocks = WGPMInputContext
                .SurgeonMinimumNumberTimeBlocks
                .OrderBy(w => int.Parse(w.Key.Id))
                .ToArray();

            this.SurgeonMinimumNumberTimeBlocksIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               LParameterElement.SizeInBytes);

            // N(i)
            this.NParameterElementFactory = parameterElementsAbstractFactory.CreateNParameterElementFactory();

            this.SurgeonStrategicTargets = WGPMInputContext
                .SurgeonStrategicTargetNumberPatients
                .OrderBy(w => int.Parse(w.Key.Id))
                .ToArray();

            this.SurgeonStrategicTargetsIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               NParameterElement.SizeInBytes);

            // n(i, ω)
            this.nParameterElementFactory = parameterElementsAbstractFactory.CreateniωParameterElementFactory();

            var nArraySize = 1 + iω.ToArray().Select(w => w.iωOI).Max();
            var nArray = new Tuple<Organization, INullableValue<int>, INullableValue<int>>[nArraySize];

            for (int i = 1; i < iω.Length; i = i + 1)
            {
                Organization surgeon = this.Surgeons[iω[i].iIndexElement - 1];

                INullableValue<int> scenario = this.Scenarios[iω[i].ωIndexElement - 1];

                nArray[iω[i].iωZI] =
                    Tuple.Create(
                        surgeon,
                        scenario,
                        WGPMInputContext.SurgeonScenarioMaximumNumberPatients[surgeon][scenario]);
            }

            this.SurgeonScenarioMaximumNumberPatients = nArray;

            this.SurgeonScenarioMaximumNumberPatientsIntPtr = Marshal.AllocHGlobal(
               (1 + this.Surgeons.Count() + this.Surgeons.Count() * this.Scenarios.Count())
               *
               niωParameterElement.SizeInBytes);

            // v
            this.TimeBlockLength = WGPMInputContext
                .TimeBlockLength;

            // w1
            this.GoalWeight1 = WGPMInputContext
                .GoalWeight1;

            // w2
            this.GoalWeight2 = WGPMInputContext
                .GoalWeight2;

            // w3
            this.GoalWeight3 = WGPMInputContext
                .GoalWeight3;

            // w4
            this.GoalWeight4 = WGPMInputContext
                .GoalWeight4;

            // Π(i, j)
            this.ΠParameterElementFactory = parameterElementsAbstractFactory.CreateΠParameterElementFactory();

            var ΠArraySize = 1 + this.Surgeons.Count() + this.Surgeons.Count() * this.OperatingRooms.Count();
            var ΠArray = new Tuple<Organization, Location, INullableValue<bool>>[ΠArraySize];

            for (int i = 1; i < ij.Length; i = i + 1)
            {
                Organization surgeon = this.Surgeons[ij[i].iIndexElement - 1];

                Location operatingRoom = this.OperatingRooms[ij[i].jIndexElement - 1];

                ΠArray[ij[i].ijZI] =
                    Tuple.Create(
                        surgeon,
                        operatingRoom,
                        WGPMInputContext.SurgeonOperatingRoomAvailabilities[surgeon][operatingRoom]);
            }

            this.SurgeonOperatingRoomAvailabilities = ΠArray;

            this.SurgeonOperatingRoomAvailabilitiesIntPtr = Marshal.AllocHGlobal(
               (1 + this.Surgeons.Count() + this.Surgeons.Count() * this.OperatingRooms.Count())
               *
               ΠParameterElement.SizeInBytes);

            // Ρ(ω)
            this.ΡParameterElementFactory = parameterElementsAbstractFactory.CreateΡParameterElementFactory();

            this.ScenarioProbabilities = WGPMInputContext
                .ScenarioProbabilities
                .OrderBy(w => w.Key.Value.Value)
                .ToArray();

            this.ScenarioProbabilitiesIntPtr = Marshal.AllocHGlobal(
               (1 + this.Surgeons.Count() + this.Surgeons.Count() * this.Scenarios.Count())
               *
               ΡParameterElement.SizeInBytes);

            // Φ(i, l, ω)
            this.ΦParameterElementFactory = parameterElementsAbstractFactory.CreateΦParameterElementFactory();

            ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> surgeonDayScenarioCumulativeNumberPatientsOuterVisitor = contextsAbstractFactory.CreateSurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory().Create<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>(
                parameterElementsAbstractFactory.CreateΦParameterElementFactory());

            WGPMInputContext.SurgeonDayScenarioCumulativeNumberPatients.AcceptVisitor(
                surgeonDayScenarioCumulativeNumberPatientsOuterVisitor);

            this.SurgeonDayScenarioCumulativeNumberPatients = surgeonDayScenarioCumulativeNumberPatientsOuterVisitor.RedBlackTree;

            // Ω(i, k)
            this.ΩParameterElementFactory = parameterElementsAbstractFactory.CreateΩParameterElementFactory();

            var ΩArraySize = 1 + this.Surgeons.Count() + this.Surgeons.Count() * this.PlanningHorizon.Count();
            var ΩArray = new Tuple<Organization, FhirDateTime, INullableValue<bool>>[ΩArraySize];

            for (int i = 1; i < ik.Length; i = i + 1)
            {
                Organization surgeon = this.Surgeons[ik[i].iIndexElement - 1];

                FhirDateTime day = this.PlanningHorizon[ik[i].kIndexElement - 1];

                ΩArray[ik[i].ikZI] =
                    Tuple.Create(
                        surgeon,
                        day,
                        WGPMInputContext.SurgeonDayAvailabilities[surgeon][day]);
            }

            this.SurgeonDayAvailabilities = ΩArray;

            this.SurgeonDayAvailabilitiesIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.PlanningHorizon.Count() + 1)
               *
               ΩParameterElement.SizeInBytes);

            // d1Minus(i, ω)
            this.d1Minus = variablesAbstractFactory.Created1MinusFactory().Create(
                this.Geti(),
                this.Getω());

            // d1Plus(i, ω)
            this.d1Plus = variablesAbstractFactory.Created1PlusFactory().Create(
                this.Geti(),
                this.Getω());

            // d2Minus(i, j, k, ω)
            this.d2Minus = variablesAbstractFactory.Created2MinusFactory().Create(
                this.Geti(),
                this.Getj(),
                this.Getk(),
                this.Getω());

            // I(k, ω)
            this.I = variablesAbstractFactory.CreateIFactory().Create(
                this.Getk(),
                this.Getω());

            // IMax(ω)
            this.IMax = variablesAbstractFactory.CreateIMaxFactory().Create(
                this.Getω());

            // IMin(ω)
            this.IMin = variablesAbstractFactory.CreateIMinFactory().Create(
                this.Getω());

            // x(i, j, k)
            this.xVariableElementFactory = variableElementsAbstractFactory.CreatexVariableElementFactory();

            this.SurgeonOperatingRoomDayAssignmentsIntPtr = Marshal.AllocHGlobal(
               (this.Surgeons.Count() + 1)
               *
               (this.OperatingRooms.Count() + 1)
               *
               (this.PlanningHorizon.Count() + 1)
               *
               xVariableElement.SizeInBytes);

            this.x = variablesAbstractFactory.CreatexFactory().Create();

            if (WGPMInputContext.SurgeonOperatingRoomDayAssignments != null)
            {
                this.Setx(
                    WGPMInputContext.SurgeonOperatingRoomDayAssignments);
            }

            this.Constraints = constraintsAbstractFactory.CreateConstraintsFactory().Create(
                constraints1Factory: constraintsAbstractFactory.CreateConstraints1Factory(),
                constraints2Factory: constraintsAbstractFactory.CreateConstraints2Factory(),
                constraints3Factory: constraintsAbstractFactory.CreateConstraints3Factory(),
                constraints4Factory: constraintsAbstractFactory.CreateConstraints4Factory(),
                constraints5LFactory: constraintsAbstractFactory.CreateConstraints5LFactory(),
                constraints5UFactory: constraintsAbstractFactory.CreateConstraints5UFactory(),
                constraints9Factory: constraintsAbstractFactory.CreateConstraints9Factory(),
                i: this.Geti(),
                j: this.Getj(),
                k: this.Getk(),
                r: this.Getr());

            this.Goal1 = objectiveFunctionsAbstractFactory.CreateGoal1Factory().Create();

            this.Goal2 = objectiveFunctionsAbstractFactory.CreateGoal2Factory().Create();

            this.Goal3 = objectiveFunctionsAbstractFactory.CreateGoal3Factory().Create();

            this.Goal4 = objectiveFunctionsAbstractFactory.CreateGoal4Factory().Create();

            this.ObjectiveFunction = objectiveFunctionsAbstractFactory.CreateObjectiveFunctionFactory().Create();
        }

        private IiIndexElementFactory iIndexElementFactory { get; }

        private IjIndexElementFactory jIndexElementFactory { get; }

        private IkIndexElementFactory kIndexElementFactory { get; }

        private IlIndexElementFactory lIndexElementFactory { get; }

        private IrIndexElementFactory rIndexElementFactory { get; }

        private IωIndexElementFactory ωIndexElementFactory { get; }

        private IijCrossJoinElementFactory ijCrossJoinElementFactory { get; }

        private IijkCrossJoinElementFactory ijkCrossJoinElementFactory { get; }

        private IijkωCrossJoinElementFactory ijkωCrossJoinElementFactory { get; }

        private IikCrossJoinElementFactory ikCrossJoinElementFactory { get; }

        private IilωCrossJoinElementFactory ilωCrossJoinElementFactory { get; }

        private IiωCrossJoinElementFactory iωCrossJoinElementFactory { get; }

        private IjkCrossJoinElementFactory jkCrossJoinElementFactory { get; }

        private IkωCrossJoinElementFactory kωCrossJoinElementFactory { get; }

        private IabMappingFactory abMappingFactory { get; }

        private IabcMappingFactory abcMappingFactory { get; }

        private IabcdMappingFactory abcdMappingFactory { get; }

        private IAParameterElementFactory AParameterElementFactory { get; }

        private IBParameterElementFactory BParameterElementFactory { get; }

        private IB1ParameterElementFactory B1ParameterElementFactory { get; }

        private IF2ParameterElementFactory F2ParameterElementFactory { get; }

        private IHParameterElementFactory HParameterElementFactory { get; }

        private ILParameterElementFactory LParameterElementFactory { get; }

        private INParameterElementFactory NParameterElementFactory { get; }

        private IniωParameterElementFactory nParameterElementFactory { get; }

        private IΠParameterElementFactory ΠParameterElementFactory { get; }

        private IΡParameterElementFactory ΡParameterElementFactory { get; }

        private IΦParameterElementFactory ΦParameterElementFactory { get; }

        private IΩParameterElementFactory ΩParameterElementFactory { get; }

        private IxVariableElementFactory xVariableElementFactory { get; }

        // i
        public Organization[] Surgeons { get; }

        // j
        public Location[] OperatingRooms { get; }

        // k
        public FhirDateTime[] PlanningHorizon { get; }

        // l
        public INullableValue<int>[] LengthOfStayDays { get; }

        // r
        public Organization[] SurgicalSpecialties { get; }

        // ω
        public INullableValue<int>[] Scenarios { get; }

        // A(i, ω)
        public Tuple<Organization, INullableValue<int>, Duration>[] SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        // B(r)
        public KeyValuePair<Organization, INullableValue<int>>[] SurgicalSpecialtyStrategicTargetNumberTimeBlocks { get; }

        // B1(r)
        public B1ParameterElement[] SurgicalSpecialtyLowerBounds { get; }

        // F2(r)
        public F2ParameterElement[] SurgicalSpecialtyUpperBounds { get; }

        // H(i)
        public KeyValuePair<Organization, INullableValue<int>>[] SurgeonMaximumNumberTimeBlocks { get; }

        // h(i)
        public KeyValuePair<Organization, INullableValue<int>>[] SurgeonLengthOfStayMaximums { get; }

        // L(i)
        public KeyValuePair<Organization, INullableValue<int>>[] SurgeonMinimumNumberTimeBlocks { get; }

        // N(i)
        public KeyValuePair<Organization, INullableValue<int>>[] SurgeonStrategicTargets { get; }

        // n(i, ω)
        public Tuple<Organization, INullableValue<int>, INullableValue<int>>[] SurgeonScenarioMaximumNumberPatients { get; }

        // v
        public Duration TimeBlockLength { get; }

        // w1
        public INullableValue<decimal> GoalWeight1 { get; }

        // w2
        public INullableValue<decimal> GoalWeight2 { get; }

        // w3
        public INullableValue<decimal> GoalWeight3 { get; }

        // w4
        public INullableValue<decimal> GoalWeight4 { get; }

        public Tuple<Organization, Location, INullableValue<bool>>[] SurgeonOperatingRoomAvailabilities { get; }

        // Ρ(ω)
        public KeyValuePair<INullableValue<int>, INullableValue<decimal>>[] ScenarioProbabilities { get; }

        // Φ(i, l, ω)
        public RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        public Tuple<Organization, FhirDateTime, INullableValue<bool>>[] SurgeonDayAvailabilities { get; }

        // i
        private IntPtr SurgeonsIntPtr { get; }

        // j
        private IntPtr OperatingRoomsIntPtr { get; }

        // k
        private IntPtr PlanningHorizonIntPtr { get; }

        // l
        private IntPtr LengthOfStayDaysIntPtr { get; }

        // r
        private IntPtr SurgicalSpecialtiesIntPtr { get; }

        // ω
        private IntPtr ScenariosIntPtr { get; }

        // ij
        private IntPtr ijIntPtr { get; }

        // ijk
        private IntPtr ijkIntPtr { get; }

        // ijkω
        private IntPtr ijkωIntPtr { get; }

        // ik
        private IntPtr ikIntPtr { get; }

        // ilω
        private IntPtr ilωIntPtr { get; }

        // iω
        private IntPtr iωIntPtr { get; }

        // jk
        private IntPtr jkIntPtr { get; }

        // kω
        private IntPtr kωIntPtr { get; }

        // A(i, ω)
        private IntPtr SurgeonScenarioWeightedAverageSurgicalDurationsIntPtr { get; }

        // B(r)
        private IntPtr SurgicalSpecialtyStrategicTargetNumberTimeBlocksIntPtr { get; }

        // B1(r)
        private IntPtr SurgicalSpecialtyLowerBoundsIntPtr { get; }

        // F2(r)
        private IntPtr SurgicalSpecialtyUpperBoundsIntPtr { get; }

        // H(i)
        private IntPtr SurgeonMaximumNumberTimeBlocksIntPtr { get; }

        // h(i)
        private IntPtr SurgeonLengthOfStayMaximumsIntPtr { get; }

        // L(i)
        private IntPtr SurgeonMinimumNumberTimeBlocksIntPtr { get; }

        // N(i)
        private IntPtr SurgeonStrategicTargetsIntPtr { get; }

        // n(i, ω)
        private IntPtr SurgeonScenarioMaximumNumberPatientsIntPtr { get; }

        // p(i, l, ω)
        private IntPtr SurgeonDayScenarioLengthOfStayProbabilitiesIntPtr { get; }

        // Π(i, j)
        private IntPtr SurgeonOperatingRoomAvailabilitiesIntPtr { get; }

        // Ρ(ω)
        private IntPtr ScenarioProbabilitiesIntPtr { get; }

        // Φ(i, l, ω)
        private IntPtr SurgeonDayScenarioCumulativeNumberPatientsIntPtr { get; }

        // Ω(i, k)
        private IntPtr SurgeonDayAvailabilitiesIntPtr { get; }

        // x(i, j, k)
        private IntPtr SurgeonOperatingRoomDayAssignmentsIntPtr { get; }

        // d1Minus(i, ω)
        public Id1Minus d1Minus { get; }

        // d1Plus(i, ω)
        public Id1Plus d1Plus { get; }

        // d2Minus(i, j, k, ω)
        public Id2Minus d2Minus { get; }

        // I(k, ω)
        public II I { get; }

        // IMax(ω)
        public IIMax IMax { get; }

        // IMin(ω)
        public IIMin IMin { get; }

        public Ix x { get; }

        public IConstraints Constraints { get; }

        public IGoal1 Goal1 { get; }

        public IGoal2 Goal2 { get; }

        public IGoal3 Goal3 { get; }

        public IGoal4 Goal4 { get; }

        public IObjectiveFunction ObjectiveFunction { get; }

        public unsafe ReadOnlySpan<iIndexElement> Geti()
        {
            int iLowerBound = 1;

            int iUpperBound = this.Surgeons.Count();

            int offset = 1;

            Span<iIndexElement> iSpan = new Span<iIndexElement>(
                (void*)this.SurgeonsIntPtr,
                offset + iUpperBound);

            iSpan.Clear();

            for (int i = iLowerBound; i <= iUpperBound; i = i + 1)
            {
                iSpan[i] = this.iIndexElementFactory.Create(
                    i);
            }

            return iSpan;
        }

        public unsafe ReadOnlySpan<jIndexElement> Getj()
        {
            int jLowerBound = 1;

            int jUpperBound = this.OperatingRooms.Count();

            int offset = 1;

            Span<jIndexElement> jSpan = new Span<jIndexElement>(
                (void*)this.OperatingRoomsIntPtr,
                offset + jUpperBound);

            jSpan.Clear();

            for (int i = jLowerBound; i <= jUpperBound; i = i + 1)
            {
                jSpan[i] = this.jIndexElementFactory.Create(
                    i);
            }

            return jSpan;
        }

        public unsafe ReadOnlySpan<kIndexElement> Getk()
        {
            int kLowerBound = 1;

            int kUpperBound = this.PlanningHorizon.Count();

            int offset = 1;

            Span<kIndexElement> kSpan = new Span<kIndexElement>(
                (void*)this.PlanningHorizonIntPtr,
                offset + kUpperBound);

            kSpan.Clear();

            for (int i = kLowerBound; i <= kUpperBound; i = i + 1)
            {
                kSpan[i] = this.kIndexElementFactory.Create(
                    i);
            }

            return kSpan;
        }

        // One-indexed: 0, 0, 1, 2, ..., T
        public unsafe ReadOnlySpan<lIndexElement> Getl()
        {
            int lLowerBound = 1;

            int lUpperBound = this.LengthOfStayDays.Count();

            int offset = 1;

            Span<lIndexElement> lSpan = new Span<lIndexElement>(
                (void*)this.LengthOfStayDaysIntPtr,
                offset + lUpperBound);

            lSpan.Clear();

            for (int i = lLowerBound; i <= lUpperBound; i = i + 1)
            {
                // l is zero-indexed
                lSpan[i] = this.lIndexElementFactory.Create(
                    i - 1);
            }

            return lSpan;
        }

        public unsafe ReadOnlySpan<rIndexElement> Getr()
        {
            int rLowerBound = 1;

            int rUpperBound = this.SurgicalSpecialties.Count();

            int offset = 1;

            Span<rIndexElement> rSpan = new Span<rIndexElement>(
                (void*)this.SurgicalSpecialtiesIntPtr,
                offset + rUpperBound);

            rSpan.Clear();

            for (int i = rLowerBound; i <= rUpperBound; i = i + 1)
            {
                rSpan[i] = this.rIndexElementFactory.Create(
                    i);
            }

            return rSpan;
        }

        public unsafe ReadOnlySpan<ωIndexElement> Getω()
        {
            int ωLowerBound = 1;

            int ωUpperBound = this.Scenarios.Count();

            int offset = 1;

            Span<ωIndexElement> ωSpan = new Span<ωIndexElement>(
                (void*)this.ScenariosIntPtr,
                offset + ωUpperBound);

            ωSpan.Clear();

            for (int i = ωLowerBound; i <= ωUpperBound; i = i + 1)
            {
                ωSpan[i] = this.ωIndexElementFactory.Create(
                    i);
            }

            return ωSpan;
        }

        public unsafe ReadOnlySpan<ijCrossJoinElement> Getij()
        {
            IabMapping abMapping = this.abMappingFactory.Create();

            int iLowerBound = 1;

            int iUpperBound = this.Surgeons.Count();

            int jLowerBound = 1;

            int jUpperBound = this.OperatingRooms.Count();

            int offset = 1;

            Span<ijCrossJoinElement> ijSpan = new Span<ijCrossJoinElement>(
                (void*)this.ijIntPtr,
                offset + abMapping.SpanLength(
                    aUpperBound: iUpperBound,
                    bLowerBound: jLowerBound,
                    bUpperBound: jUpperBound));

            ijSpan.Clear();
            
            for (int i = iLowerBound; i <= iUpperBound; i = i + 1)
            {
                for (int j = jLowerBound; j <= jUpperBound; j = j + 1)
                {
                    ijSpan[abMapping.SpanIndex(
                        a: i,
                        aUpperBound: iUpperBound,
                        b: j,
                        bLowerBound: jLowerBound)] = this.ijCrossJoinElementFactory.Create(
                            iIndexElement: i,
                            jIndexElement: j,
                            ijOI: abMapping.abOI(
                                a: i,
                                aUpperBound: iUpperBound,
                                b: j),
                            ijZI: abMapping.abZI(
                                a: i,
                                aLowerBound: iLowerBound,
                                aUpperBound: iUpperBound,
                                b: j,
                                bLowerBound: jLowerBound));
                }
            }

            return ijSpan;
        }

        public unsafe ReadOnlySpan<ijkCrossJoinElement> Getijk()
        {
            IabcMapping abcMapping = this.abcMappingFactory.Create();

            int iLowerBound = 1;

            int iUpperBound = this.Surgeons.Count();

            int jLowerBound = 1;

            int jUpperBound = this.OperatingRooms.Count();

            int kLowerBound = 1;

            int kUpperBound = this.PlanningHorizon.Count();

            int offset = 1;

            Span<ijkCrossJoinElement> ijkSpan = new Span<ijkCrossJoinElement>(
                (void*)this.ijkIntPtr,
                offset + abcMapping.SpanLength(
                    aUpperBound: iUpperBound,
                    bLowerBound: jLowerBound,
                    bUpperBound: jUpperBound,
                    cLowerBound: kLowerBound,
                    cUpperBound: kUpperBound));

            ijkSpan.Clear();

            for (int i = iLowerBound; i <= iUpperBound; i = i + 1)
            {
                for (int j = jLowerBound; j <= jUpperBound; j = j + 1)
                {
                    for (int k = kLowerBound; k <= kUpperBound; k = k + 1)
                    {
                        ijkSpan[abcMapping.SpanIndex(
                            a: i,
                            aUpperBound: iUpperBound,
                            b: j,
                            bLowerBound: jLowerBound,
                            bUpperBound: jUpperBound,
                            c: k,
                            cLowerBound: kLowerBound)] = this.ijkCrossJoinElementFactory.Create(
                                iIndexElement: i,
                                jIndexElement: j,
                                kIndexElement: k,
                                ijOI: abcMapping.abOI(
                                    a: i,
                                    aUpperBound: iUpperBound,
                                    b: j),
                                ikOI: abcMapping.acOI(
                                    a: i,
                                    aUpperBound: iUpperBound,
                                    c: k),
                                ijkOI: abcMapping.abcOI(
                                    a: i,
                                    aUpperBound: iUpperBound,
                                    bUpperBound: jUpperBound,
                                    b: j,
                                    c: k),
                                ijkZI: abcMapping.abcZI(
                                    a: i,
                                    aLowerBound: iLowerBound,
                                    aUpperBound: iUpperBound,
                                    b: j,
                                    bLowerBound: jLowerBound,
                                    bUpperBound: jUpperBound,
                                    c: k,
                                    cLowerBound: kLowerBound),
                                jkOI: abcMapping.bcOI(
                                    b: j,
                                    bUpperBound: jUpperBound,
                                    c: k));
                    }
                }
            }

            return ijkSpan;
        }

        public unsafe ReadOnlySpan<ijkωCrossJoinElement> Getijkω()
        {
            IabcdMapping abcdMapping = this.abcdMappingFactory.Create();

            int iLowerBound = 1;

            int iUpperBound = this.Surgeons.Count();

            int jLowerBound = 1;

            int jUpperBound = this.OperatingRooms.Count();

            int kLowerBound = 1;

            int kUpperBound = this.PlanningHorizon.Count();

            int ωLowerBound = 1;

            int ωUpperBound = this.Scenarios.Count();

            int offset = 1;

            Span<ijkωCrossJoinElement> ijkωSpan = new Span<ijkωCrossJoinElement>(
                (void*)this.ijkωIntPtr,
                offset + abcdMapping.SpanLength(
                    aUpperBound: iUpperBound,
                    bLowerBound: jLowerBound,
                    bUpperBound: jUpperBound,
                    cLowerBound: kLowerBound,
                    cUpperBound: kUpperBound,
                    dLowerBound: ωLowerBound,
                    dUpperBound: ωUpperBound));

            ijkωSpan.Clear();

            for (int i = iLowerBound; i <= iUpperBound; i = i + 1)
            {
                for (int j = jLowerBound; j <= jUpperBound; j = j + 1)
                {
                    for (int k = kLowerBound; k <= kUpperBound; k = k + 1)
                    {
                        for (int ω = ωLowerBound; ω <= ωUpperBound; ω = ω + 1)
                        {
                            ijkωSpan[abcdMapping.SpanIndex(
                                a: i,
                                aUpperBound: iUpperBound,
                                b: j,
                                bLowerBound: jLowerBound,
                                bUpperBound: jUpperBound,
                                c: k,
                                cLowerBound: kLowerBound,
                                cUpperBound: kUpperBound,
                                d: ω,
                                dLowerBound: ωLowerBound)] = this.ijkωCrossJoinElementFactory.Create(
                                    iIndexElement: i,
                                    jIndexElement: j,
                                    kIndexElement: k,
                                    ωIndexElement: ω,
                                    ijkOI: abcdMapping.abcOI(
                                        a: i,
                                        aUpperBound: iUpperBound,
                                        bUpperBound: jUpperBound,
                                        b: j,
                                        c: k),
                                    ijkωOI: abcdMapping.abcdOI(
                                        a: i,
                                        aUpperBound: iUpperBound,
                                        b: j,
                                        bUpperBound: jUpperBound,
                                        c: k,
                                        cUpperBound: kUpperBound,
                                        d: ω),
                                    ijkωZI: abcdMapping.abcdZI(
                                        a: i,
                                        aLowerBound: iLowerBound,
                                        aUpperBound: iUpperBound,
                                        b: j,
                                        bLowerBound: jLowerBound,
                                        bUpperBound: jUpperBound,
                                        c: k,
                                        cLowerBound: kLowerBound,
                                        cUpperBound: kUpperBound,
                                        d: ω,
                                        dLowerBound: ωLowerBound),
                                    iωOI: abcdMapping.adOI(
                                        a: i,
                                        aUpperBound: iUpperBound,
                                        d: ω));
                        }
                    }
                }
            }

            return ijkωSpan;
        }

        public unsafe ReadOnlySpan<ikCrossJoinElement> Getik()
        {
            IabMapping abMapping = this.abMappingFactory.Create();

            int iLowerBound = 1;

            int iUpperBound = this.Surgeons.Count();

            int kLowerBound = 1;

            int kUpperBound = this.PlanningHorizon.Count();

            int offset = 1;

            Span<ikCrossJoinElement> ikSpan = new Span<ikCrossJoinElement>(
                (void*)this.ikIntPtr,
                offset + abMapping.SpanLength(
                    aUpperBound: iUpperBound,
                    bLowerBound: kLowerBound,
                    bUpperBound: kUpperBound));

            ikSpan.Clear();

            for (int i = iLowerBound; i <= iUpperBound; i = i + 1)
            {
                for (int k = kLowerBound; k <= kUpperBound; k = k + 1)
                {
                    ikSpan[abMapping.SpanIndex(
                        a: i,
                        aUpperBound: iUpperBound,
                        b: k,
                        bLowerBound: kLowerBound)] = this.ikCrossJoinElementFactory.Create(
                            iIndexElement: i,
                            kIndexElement: k,
                            ikOI: abMapping.abOI(
                                a: i,
                                aUpperBound: iUpperBound,
                                b: k),
                            ikZI: abMapping.abZI(
                                a: i,
                                aLowerBound: iLowerBound,
                                aUpperBound: iUpperBound,
                                b: k,
                                bLowerBound: kLowerBound));
                }
            }

            return ikSpan;
        }

        public unsafe ReadOnlySpan<ilωCrossJoinElement> Getilω()
        {
            IabcMapping abcMapping = this.abcMappingFactory.Create();

            int iLowerBound = 1;

            int iUpperBound = this.Surgeons.Count();

            int lLowerBound = 0;

            int lUpperBound = this.LengthOfStayDays.Count() - 1;

            int ωLowerBound = 1;

            int ωUpperBound = this.Scenarios.Count();

            int offset = 1;

            Span<ilωCrossJoinElement> ilωSpan = new Span<ilωCrossJoinElement>(
                (void*)this.ilωIntPtr,
                offset + abcMapping.SpanLength(
                    aUpperBound: iUpperBound,
                    bLowerBound: lLowerBound,
                    bUpperBound: lUpperBound,
                    cLowerBound: ωLowerBound,
                    cUpperBound: ωUpperBound));

            ilωSpan.Clear();

            for (int i = iLowerBound; i <= iUpperBound; i = i + 1)
            {
                for (int l = lLowerBound; l <= lUpperBound; l = l + 1)
                {
                    for (int ω = ωLowerBound; ω <= ωUpperBound; ω = ω + 1)
                    {
                        // l is zero-indexed
                        ilωSpan[abcMapping.SpanIndex(
                            a: i,
                            aUpperBound: iUpperBound,
                            b: l,
                            bLowerBound: lLowerBound,
                            bUpperBound: lUpperBound,
                            c: ω,
                            cLowerBound: ωLowerBound)] = this.ilωCrossJoinElementFactory.Create(
                                iIndexElement: i,
                                lIndexElement: l,
                                ωIndexElement: ω,
                                ilωOI: abcMapping.abcOI(
                                    a: i,
                                    aUpperBound: iUpperBound,
                                    bUpperBound: lUpperBound,
                                    b: l,
                                    c: ω),
                                ilωZI: abcMapping.abcZI(
                                    a: i,
                                    aLowerBound: iLowerBound,
                                    aUpperBound: iUpperBound,
                                    b: l,
                                    bLowerBound: lLowerBound,
                                    bUpperBound: lUpperBound,
                                    c: ω,
                                    cLowerBound: ωLowerBound));
                    }
                }
            }

            return ilωSpan;
        }

        public unsafe ReadOnlySpan<iωCrossJoinElement> Getiω()
        {
            IabMapping abMapping = this.abMappingFactory.Create();

            int iLowerBound = 1;

            int iUpperBound = this.Surgeons.Count();

            int ωLowerBound = 1;

            int ωUpperBound = this.Scenarios.Count();

            int offset = 1;

            Span<iωCrossJoinElement> iωSpan = new Span<iωCrossJoinElement>(
                (void*)this.iωIntPtr,
                offset + abMapping.SpanLength(
                    aUpperBound: iUpperBound,
                    bLowerBound: ωLowerBound,
                    bUpperBound: ωUpperBound));

            iωSpan.Clear();

            for (int i = iLowerBound; i <= iUpperBound; i = i + 1)
            {
                for (int ω = ωLowerBound; ω <= ωUpperBound; ω = ω + 1)
                {
                    iωSpan[abMapping.SpanIndex(
                        a: i,
                        aUpperBound: iUpperBound,
                        b: ω,
                        bLowerBound: ωLowerBound)] = this.iωCrossJoinElementFactory.Create(
                            iIndexElement: i,
                            ωIndexElement: ω,
                            iωOI: abMapping.abOI(
                                a: i,
                                aUpperBound: iUpperBound,
                                b: ω),
                            iωZI: abMapping.abZI(
                                a: i,
                                aLowerBound: iLowerBound,
                                aUpperBound: iUpperBound,
                                b: ω,
                                bLowerBound: ωLowerBound));
                }
            }

            return iωSpan;
        }

        public unsafe ReadOnlySpan<jkCrossJoinElement> Getjk()
        {
            IabMapping abMapping = this.abMappingFactory.Create();

            int jLowerBound = 1;

            int jUpperBound = this.OperatingRooms.Count();

            int kLowerBound = 1;

            int kUpperBound = this.PlanningHorizon.Count();

            int offset = 1;

            Span<jkCrossJoinElement> jkSpan = new Span<jkCrossJoinElement>(
                (void*)this.jkIntPtr,
                offset + abMapping.SpanLength(
                    aUpperBound: jUpperBound,
                    bLowerBound: kLowerBound,
                    bUpperBound: kUpperBound));

            jkSpan.Clear();

            for (int j = jLowerBound; j <= jUpperBound; j = j + 1)
            {
                for (int k = kLowerBound; k <= kUpperBound; k = k + 1)
                {
                    jkSpan[abMapping.SpanIndex(
                        a: j,
                        aUpperBound: jUpperBound,
                        b: k,
                        bLowerBound: kLowerBound)] = this.jkCrossJoinElementFactory.Create(
                            jIndexElement: j,
                            kIndexElement: k,
                            jkOI: abMapping.abOI(
                                a: j,
                                aUpperBound: jUpperBound,
                                b: k),
                            jkZI: abMapping.abZI(
                                a: j,
                                aLowerBound: jLowerBound,
                                aUpperBound: jUpperBound,
                                b: k,
                                bLowerBound: kLowerBound));
                }
            }

            return jkSpan;
        }

        // Gets kω.
        public unsafe ReadOnlySpan<kωCrossJoinElement> Getkω()
        {
            IabMapping abMapping = this.abMappingFactory.Create();

            int kLowerBound = 1;

            int kUpperBound = this.PlanningHorizon.Count();

            int ωLowerBound = 1;

            int ωUpperBound = this.Scenarios.Count();

            int offset = 1;

            Span<kωCrossJoinElement> kωSpan = new Span<kωCrossJoinElement>(
                (void*)this.kωIntPtr,
                offset + abMapping.SpanLength(
                    aUpperBound: kUpperBound,
                    bLowerBound: ωLowerBound,
                    bUpperBound: ωUpperBound));

            kωSpan.Clear();

            for (int k = kLowerBound; k <= kUpperBound; k = k + 1)
            {
                for (int ω = ωLowerBound; ω <= ωUpperBound; ω = ω + 1)
                {
                    kωSpan[abMapping.SpanIndex(
                        a: k,
                        aUpperBound: kUpperBound,
                        b: ω,
                        bLowerBound: ωLowerBound)] = this.kωCrossJoinElementFactory.Create(
                            kIndexElement: k,
                            ωIndexElement: ω,
                            kωOI: abMapping.abOI(
                                a: k,
                                aUpperBound: kUpperBound,
                                b: ω),
                            kωZI: abMapping.abZI(
                                a: k,
                                aLowerBound: kLowerBound,
                                aUpperBound: kUpperBound,
                                b: ω,
                                bLowerBound: ωLowerBound));
                }
            }

            return kωSpan;
        }

        public unsafe ReadOnlySpan<AParameterElement> GetA()
        {
            ReadOnlySpan<iωCrossJoinElement> iω = this.Getiω();

            Span<AParameterElement> ASpan = new Span<AParameterElement>(
                (void*)this.SurgeonScenarioWeightedAverageSurgicalDurationsIntPtr,
                1
                +
                iω.ToArray().Select(w => w.iωOI).Max());

            ASpan.Clear();

            for (int w = 1; w < iω.Length; w = w + 1)
            {
                ASpan[iω[w].iωOI] = this.AParameterElementFactory.Create(
                    iIndexElement: iω[w].iIndexElement,
                    ωIndexElement: iω[w].ωIndexElement,
                    value: (double)this.SurgeonScenarioWeightedAverageSurgicalDurations[iω[w].iωZI].Item3.Value.Value);
            }

            return ASpan;
        }

        public unsafe ReadOnlySpan<BParameterElement> GetB()
        {
            ReadOnlySpan<rIndexElement> r = this.Getr();

            Span<BParameterElement> BSpan = new Span<BParameterElement>(
                (void*)this.SurgicalSpecialtyStrategicTargetNumberTimeBlocksIntPtr,
                1 + this.SurgicalSpecialties.Count());

            BSpan.Clear();

            for (int w = 1; w < r.Length; w = w + 1)
            {
                BSpan[r[w].Value] = this.BParameterElementFactory.Create(
                    rIndexElement: r[w].Value,
                    value: this.SurgicalSpecialtyStrategicTargetNumberTimeBlocks[r[w].Value - 1].Value.Value.Value);
            }

            return BSpan;
        }

        public unsafe ReadOnlySpan<B1ParameterElement> GetB1()
        {
            ReadOnlySpan<rIndexElement> r = this.Getr();

            Span<B1ParameterElement> B1Span = new Span<B1ParameterElement>(
                (void*)this.SurgicalSpecialtyLowerBoundsIntPtr,
                1 + this.SurgicalSpecialties.Count());

            B1Span.Clear();

            for (int w = 1; w < r.Length; w = w + 1)
            {
                B1Span[r[w].Value] = this.B1ParameterElementFactory.Create(
                    this.SurgicalSpecialtyLowerBounds[r[w].Value - 1].Value);
            }

            return B1Span;
        }

        public unsafe ReadOnlySpan<F2ParameterElement> GetF2()
        {
            ReadOnlySpan<rIndexElement> r = this.Getr();

            Span<F2ParameterElement> F2Span = new Span<F2ParameterElement>(
                (void*)this.SurgicalSpecialtyUpperBoundsIntPtr,
                1 + this.SurgicalSpecialties.Count());

            F2Span.Clear();

            for (int w = 1; w < r.Length; w = w + 1)
            {
                F2Span[r[w].Value] = this.F2ParameterElementFactory.Create(
                    this.SurgicalSpecialtyUpperBounds[r[w].Value - 1].Value);
            }

            return F2Span;
        }

        public unsafe ReadOnlySpan<HParameterElement> GetH()
        {
            ReadOnlySpan<iIndexElement> i = this.Geti();

            Span<HParameterElement> HSpan = new Span<HParameterElement>(
                (void*)this.SurgeonMaximumNumberTimeBlocksIntPtr,
                1 + this.Surgeons.Count());

            HSpan.Clear();

            for (int w = 1; w < i.Length; w = w + 1)
            {
                HSpan[i[w].Value] = this.HParameterElementFactory.Create(
                    iIndexElement: i[w].Value,
                    value: this.SurgeonMaximumNumberTimeBlocks[i[w].Value - 1].Value.Value.Value);
            }

            return HSpan;
        }

        public unsafe ReadOnlySpan<LParameterElement> GetL()
        {
            ReadOnlySpan<iIndexElement> i = this.Geti();

            Span<LParameterElement> LSpan = new Span<LParameterElement>(
                (void*)this.SurgeonMinimumNumberTimeBlocksIntPtr,
                1 + this.Surgeons.Count());

            LSpan.Clear();

            for (int w = 1; w < i.Length; w = w + 1)
            {
                LSpan[i[w].Value] = this.LParameterElementFactory.Create(
                    iIndexElement: i[w].Value,
                    value: this.SurgeonMinimumNumberTimeBlocks[i[w].Value - 1].Value.Value.Value);
            }

            return LSpan;
        }

        public unsafe ReadOnlySpan<NParameterElement> GetN()
        {
            ReadOnlySpan<iIndexElement> i = this.Geti();

            Span<NParameterElement> NSpan = new Span<NParameterElement>(
                (void*)this.SurgeonStrategicTargetsIntPtr,
                1 + this.Surgeons.Count());

            NSpan.Clear();

            for (int w = 1; w < i.Length; w = w + 1)
            {
                NSpan[i[w].Value] = this.NParameterElementFactory.Create(
                    iIndexElement: i[w].Value,
                    value: this.SurgeonStrategicTargets[i[w].Value - 1].Value.Value.Value);
            }

            return NSpan;
        }

        public unsafe ReadOnlySpan<niωParameterElement> Getn()
        {
            ReadOnlySpan<iωCrossJoinElement> iω = this.Getiω();

            Span<niωParameterElement> nSpan = new Span<niωParameterElement>(
                (void*)this.SurgeonScenarioMaximumNumberPatientsIntPtr,
                1 + this.Surgeons.Count() + this.Surgeons.Count() * this.Scenarios.Count());

            nSpan.Clear();

            for (int w = 1; w < iω.Length; w = w + 1)
            {
                nSpan[iω[w].iωOI] = this.nParameterElementFactory.Create(
                    iIndexElement: iω[w].iIndexElement,
                    ωIndexElement: iω[w].ωIndexElement,
                    value: this.SurgeonScenarioMaximumNumberPatients[iω[w].iωZI].Item3.Value.Value);
            }

            return nSpan;
        }

        public double Getv()
        {
            return (double)this.TimeBlockLength.Value.Value;
        }

        public double Getw1()
        {
            return (double)this.GoalWeight1.Value.Value;
        }

        public double Getw2()
        {
            return (double)this.GoalWeight2.Value.Value;
        }

        public double Getw3()
        {
            return (double)this.GoalWeight3.Value.Value;
        }

        public double Getw4()
        {
            return (double)this.GoalWeight4.Value.Value;
        }

        public unsafe ReadOnlySpan<ΠParameterElement> GetΠ()
        {
            ReadOnlySpan<ijCrossJoinElement> ij = this.Getij();

            Span<ΠParameterElement> ΠSpan = new Span<ΠParameterElement>(
                (void*)this.SurgeonOperatingRoomAvailabilitiesIntPtr,
                1 + this.Surgeons.Count() + this.Surgeons.Count() * this.OperatingRooms.Count());

            ΠSpan.Clear();

            for (int w = 1; w < ij.Length; w = w + 1)
            {
                ΠSpan[ij[w].ijOI] = this.ΠParameterElementFactory.Create(
                    iIndexElement: ij[w].iIndexElement,
                    jIndexElement: ij[w].jIndexElement,
                    value: this.SurgeonOperatingRoomAvailabilities[ij[w].ijZI].Item3.Value.Value ? 1 : 0);
            }

            return ΠSpan;
        }

        public unsafe ReadOnlySpan<ΡParameterElement> GetΡ()
        {
            ReadOnlySpan<ωIndexElement> ω = this.Getω();

            Span<ΡParameterElement> ΡSpan = new Span<ΡParameterElement>(
                (void*)this.ScenarioProbabilitiesIntPtr,
                1 + this.ScenarioProbabilities.Count());

            ΡSpan.Clear();

            for (int w = 1; w < ω.Length; w = w + 1)
            {
                ΡSpan[ω[w].Value] = this.ΡParameterElementFactory.Create(
                    ωIndexElement: ω[w].Value,
                    value: (double)this.ScenarioProbabilities[ω[w].Value - 1].Value.Value.Value);
            }

            return ΡSpan;
        }

        public unsafe ReadOnlySpan<ΩParameterElement> GetΩ()
        {
            ReadOnlySpan<ikCrossJoinElement> ik = this.Getik();

            Span<ΩParameterElement> ΩSpan = new Span<ΩParameterElement>(
                (void*)this.SurgeonDayAvailabilitiesIntPtr,
                1 + this.Surgeons.Count() + this.Surgeons.Count() * this.PlanningHorizon.Count());

            ΩSpan.Clear();

            for (int w = 1; w < ik.Length; w = w + 1)
            {
                ΩSpan[ik[w].ikOI] = this.ΩParameterElementFactory.Create(
                    iIndexElement: ik[w].iIndexElement,
                    kIndexElement: ik[w].kIndexElement,
                    value: this.SurgeonDayAvailabilities[ik[w].ikZI].Item3.Value.Value ? 1 : 0);
            }

            return ΩSpan;
        }

        public unsafe Span<xVariableElement> Getx()
        {
            ReadOnlySpan<ijkCrossJoinElement> ijk = this.Getijk();

            Span<xVariableElement> xSpan = new Span<xVariableElement>(
                (void*)this.SurgeonOperatingRoomDayAssignmentsIntPtr,
                1 + ijk.ToArray().Select(w => w.ijkOI).Max());

            xSpan.Clear();

            for (int w = 1; w < ijk.Length; w = w + 1)
            {
                xSpan[ijk[w].ijkOI] = this.xVariableElementFactory.Create(
                    ijk[w].iIndexElement,
                    ijk[w].jIndexElement,
                    ijk[w].kIndexElement,
                    0);
            }

            return xSpan;
        }

        public unsafe Span<xVariableElement> GetxWithoutClearing()
        {
            ReadOnlySpan<ijkCrossJoinElement> ijk = this.Getijk();

            Span<xVariableElement> xSpan = new Span<xVariableElement>(
                (void*)this.SurgeonOperatingRoomDayAssignmentsIntPtr,
                1 + ijk.ToArray().Select(w => w.ijkOI).Max());

            return xSpan;
        }

        private void Setx(
            RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> surgeonOperatingRoomDayAssignments)
        {
            ReadOnlySpan<ijkCrossJoinElement> ijk = this.Getijk();
            
            for (int w = 1; w < ijk.Length; w = w + 1)
            {
                Organization surgeon = this.Surgeons[ijk[w].iIndexElement - 1];
                
                Location operatingRoom = this.OperatingRooms[ijk[w].jIndexElement - 1];
                
                FhirDateTime day = this.PlanningHorizon[ijk[w].kIndexElement - 1];
                
                Marshal.StructureToPtr(
                    this.xVariableElementFactory.Create(
                        ijk[w].iIndexElement,
                        ijk[w].jIndexElement,
                        ijk[w].kIndexElement,
                        surgeonOperatingRoomDayAssignments[surgeon][operatingRoom][day].Value.Value ? 1 : 0),
                    IntPtr.Add(
                        this.SurgeonOperatingRoomDayAssignmentsIntPtr, 
                        ijk[w].ijkOI * xVariableElement.SizeInBytes),
                    false);
            }
        }

        bool disposed;
        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;

                // i
                Marshal.FreeHGlobal(
                    this.SurgeonsIntPtr);

                // j
                Marshal.FreeHGlobal(
                    this.OperatingRoomsIntPtr);

                // k
                Marshal.FreeHGlobal(
                    this.PlanningHorizonIntPtr);

                // l
                Marshal.FreeHGlobal(
                    this.LengthOfStayDaysIntPtr);

                // r
                Marshal.FreeHGlobal(
                    this.SurgicalSpecialtiesIntPtr);

                // ω
                Marshal.FreeHGlobal(
                    this.ScenariosIntPtr);

                // ij
                Marshal.FreeHGlobal(
                    this.ijIntPtr);

                // ijk
                Marshal.FreeHGlobal(
                    this.ijkIntPtr);

                // ijkω
                Marshal.FreeHGlobal(
                    this.ijkωIntPtr);

                // ik
                Marshal.FreeHGlobal(
                    this.ikIntPtr);

                // ilω
                Marshal.FreeHGlobal(
                    this.ilωIntPtr);

                // iω
                Marshal.FreeHGlobal(
                    this.iωIntPtr);

                // jk
                Marshal.FreeHGlobal(
                    this.jkIntPtr);

                // kω
                Marshal.FreeHGlobal(
                    this.kωIntPtr);

                // A(i, ω)
                Marshal.FreeHGlobal(
                    this.SurgeonScenarioWeightedAverageSurgicalDurationsIntPtr);

                // B(r)
                Marshal.FreeHGlobal(
                    this.SurgicalSpecialtyStrategicTargetNumberTimeBlocksIntPtr);

                // B1(r)
                Marshal.FreeHGlobal(
                    this.SurgicalSpecialtyLowerBoundsIntPtr);

                // F2(r)
                Marshal.FreeHGlobal(
                    this.SurgicalSpecialtyUpperBoundsIntPtr);

                // H(i)
                Marshal.FreeHGlobal(
                    this.SurgeonMaximumNumberTimeBlocksIntPtr);

                // h(i)
                Marshal.FreeHGlobal(
                    this.SurgeonLengthOfStayMaximumsIntPtr);

                // L(i)
                Marshal.FreeHGlobal(
                    this.SurgeonMinimumNumberTimeBlocksIntPtr);

                // N(i)
                Marshal.FreeHGlobal(
                    this.SurgeonStrategicTargetsIntPtr);

                // n(i, ω)
                Marshal.FreeHGlobal(
                    this.SurgeonScenarioMaximumNumberPatientsIntPtr);

                // p(i, l, ω)
                Marshal.FreeHGlobal(
                    this.SurgeonDayScenarioLengthOfStayProbabilitiesIntPtr);

                // Π(i, j)
                Marshal.FreeHGlobal(
                    this.SurgeonOperatingRoomAvailabilitiesIntPtr);

                // Ρ(ω)
                Marshal.FreeHGlobal(
                    this.ScenarioProbabilitiesIntPtr);

                // Φ(i, l, ω)
                Marshal.FreeHGlobal(
                    this.SurgeonDayScenarioCumulativeNumberPatientsIntPtr);

                // Ω(i, k)
                Marshal.FreeHGlobal(
                    this.SurgeonDayAvailabilitiesIntPtr);

                // d1Minus(i, ω)
                this.d1Minus.Dispose();

                // d1Plus(i, ω)
                this.d1Plus.Dispose();

                // d2Minus(i, j, k, ω)
                this.d2Minus.Dispose();

                // I(k, ω)
                this.I.Dispose();

                // IMax(ω)
                this.IMax.Dispose();

                // IMin(ω)
                this.IMin.Dispose();

                // x(i, j, k)
                Marshal.FreeHGlobal(
                    this.SurgeonOperatingRoomDayAssignmentsIntPtr);

                // Constraints
                this.Constraints.Dispose();
            }
        }
    }
}