namespace Britt2022.A.A.Results.Interfaces.SurgeonOperatingRoomDayScenarioDeviations
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;

    public interface Id2Minus
    {
        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<d2MinusResultElement> d2Minus);
    }
}