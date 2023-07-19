namespace Britt2022.A.A.Contexts.InterfacesVisitors
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    public interface ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>
    {
        RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>> RedBlackTree { get; }
    }
}