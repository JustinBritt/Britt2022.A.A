namespace Britt2022.A.A.Contexts.InterfacesFactories
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;

    public interface ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory
    {
        ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            IΦParameterElementFactory ΦParameterElementFactory)
            where TKey : Organization
            where TValue : RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>;
    }
}