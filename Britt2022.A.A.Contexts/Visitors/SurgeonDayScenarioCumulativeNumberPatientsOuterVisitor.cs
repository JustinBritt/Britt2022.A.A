namespace Britt2022.A.A.Contexts.Visitors
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    
    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue> : ISurgeonDayScenarioCumulativeNumberPatientsOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>
    {
        public SurgeonDayScenarioCumulativeNumberPatientsOuterVisitor(
            IΦParameterElementFactory ΦParameterElementFactory)
        {
            this.ΦParameterElementFactory = ΦParameterElementFactory;

            this.RedBlackTree = new RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>>();
        }

        private IΦParameterElementFactory ΦParameterElementFactory { get; }

        public bool HasCompleted => false;

        public RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            int iIndexElement = int.Parse(
                obj.Key.Id);

            RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> value = obj.Value;

            var innerVisitor = new SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>(
                this.ΦParameterElementFactory,
                iIndexElement);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}