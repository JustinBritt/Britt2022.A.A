namespace Britt2022.A.A.Results.Interfaces.ScenarioRecoveryWardCensuses
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.ScenarioRecoveryWardCensuses;

    public interface IIMin
    {
        RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<IMinResultElement> IMin);
    }
}