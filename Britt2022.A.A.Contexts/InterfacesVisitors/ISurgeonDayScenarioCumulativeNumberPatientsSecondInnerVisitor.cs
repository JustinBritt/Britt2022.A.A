namespace Britt2022.A.A.Contexts.InterfacesVisitors
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    public interface ISurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        RedBlackTree<int, ΦParameterElement> RedBlackTree { get; }
    }
}