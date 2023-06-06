namespace Britt2022.A.A.Models.Interfaces
{
    using System;
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public interface IWGPMModel : IDisposable
    {
        Organization[] Surgeons { get; }

        Location[] OperatingRooms { get; }

        FhirDateTime[] PlanningHorizon { get; }

        INullableValue<int>[] LengthOfStayDays { get; }

        Organization[] SurgicalSpecialties { get; }

        INullableValue<int>[] Scenarios { get; }

        Tuple<Organization, INullableValue<int>, Duration>[] SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        KeyValuePair<Organization, INullableValue<int>>[] SurgicalSpecialtyStrategicTargetNumberTimeBlocks { get; }

        B1ParameterElement[] SurgicalSpecialtyLowerBounds { get; }

        F2ParameterElement[] SurgicalSpecialtyUpperBounds { get; }

        KeyValuePair<Organization, INullableValue<int>>[] SurgeonMaximumNumberTimeBlocks { get; }

        KeyValuePair<Organization, INullableValue<int>>[] SurgeonLengthOfStayMaximums { get; }

        KeyValuePair<Organization, INullableValue<int>>[] SurgeonMinimumNumberTimeBlocks { get; }

        KeyValuePair<Organization, INullableValue<int>>[] SurgeonStrategicTargets { get; }

        Tuple<Organization, INullableValue<int>, INullableValue<int>>[] SurgeonScenarioMaximumNumberPatients { get; }

        Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>[] SurgeonDayScenarioLengthOfStayProbabilities { get; }

        Duration TimeBlockLength { get; }

        Tuple<Organization, Location, INullableValue<bool>>[] SurgeonOperatingRoomAvailabilities { get; }

        KeyValuePair<INullableValue<int>, INullableValue<decimal>>[] ScenarioProbabilities { get; }

        Tuple<Organization, INullableValue<int>, INullableValue<int>, INullableValue<decimal>>[] SurgeonDayScenarioCumulativeNumberPatients { get; }

        Tuple<Organization, FhirDateTime, FhirBoolean>[] SurgeonDayAvailabilities { get; }

        Id1Minus d1Minus { get; }

        Id1Plus d1Plus { get; }

        Id2Minus d2Minus { get; }

        II I { get; }

        IIMax IMax { get; }

        IIMin IMin { get; }

        Ix x { get; }

        IConstraints Constraints { get; }

        IGoal1 Goal1 { get; }

        IGoal2 Goal2 { get; }

        IGoal3 Goal3 { get; }

        IGoal4 Goal4 { get; }

        IObjectiveFunction ObjectiveFunction { get; }

        ReadOnlySpan<iIndexElement> Geti();

        ReadOnlySpan<jIndexElement> Getj();

        ReadOnlySpan<kIndexElement> Getk();

        ReadOnlySpan<lIndexElement> Getl();

        ReadOnlySpan<rIndexElement> Getr();

        ReadOnlySpan<ωIndexElement> Getω();

        ReadOnlySpan<ijCrossJoinElement> Getij();

        ReadOnlySpan<ijkCrossJoinElement> Getijk();

        ReadOnlySpan<ijkωCrossJoinElement> Getijkω();

        ReadOnlySpan<ikCrossJoinElement> Getik();

        ReadOnlySpan<ilωCrossJoinElement> Getilω();

        ReadOnlySpan<iωCrossJoinElement> Getiω();

        ReadOnlySpan<jkCrossJoinElement> Getjk();

        ReadOnlySpan<kωCrossJoinElement> Getkω();

        ReadOnlySpan<AParameterElement> GetA();

        ReadOnlySpan<BParameterElement> GetB();

        ReadOnlySpan<B1ParameterElement> GetB1();

        ReadOnlySpan<F2ParameterElement> GetF2();

        ReadOnlySpan<HParameterElement> GetH();

        ReadOnlySpan<hiParameterElement> Geth();

        ReadOnlySpan<LParameterElement> GetL();

        ReadOnlySpan<NParameterElement> GetN();

        ReadOnlySpan<niωParameterElement> Getn();

        ReadOnlySpan<pParameterElement> Getp();

        double Getv();

        double Getw1();

        double Getw2();

        double Getw3();

        double Getw4();

        ReadOnlySpan<ΠParameterElement> GetΠ();

        ReadOnlySpan<ΡParameterElement> GetΡ();

        ReadOnlySpan<ΦParameterElement> GetΦ();

        ReadOnlySpan<ΩParameterElement> GetΩ();

        Span<xVariableElement> Getx();

        Span<xVariableElement> GetxWithoutClearing();
    }
}