namespace Britt2022.A.A.Results.Interfaces.SurgeonScenarioDeviations
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonScenarioDeviations;

    public interface Id1Plus
    {
        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<d1PlusResultElement> d1Plus);
    }
}