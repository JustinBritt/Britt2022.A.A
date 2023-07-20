namespace Britt2022.A.A.Contexts.Factories
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Contexts.InterfacesFactories;
    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.Contexts.Visitors;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;

    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory : ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory
    {
        public SurgeonDayScenarioCumulativeNumberPatientsOuterVisitorFactory()
        {
        }

        public ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue> Create<TKey, TValue>(
            IΦParameterElementFactory ΦParameterElementFactory)
            where TKey : Organization
            where TValue : RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>
        {
            ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new SurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue>(
                    ΦParameterElementFactory);
            }
            finally
            {
            }

            return instance;
        }
    }
}