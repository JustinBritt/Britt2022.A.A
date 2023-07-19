namespace Britt2022.A.A.Contexts.Visitors
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<TKey, TValue> : ISurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : RedBlackTree<INullableValue<int>, INullableValue<decimal>>
    {
        public SurgeonDayScenarioCumulativeNumberPatientsFirstInnerVisitor(
            IΦParameterElementFactory ΦParameterElementFactory,
            int iIndexElement)
        {
            this.ΦParameterElementFactory = ΦParameterElementFactory;

            this.iIndexElement = iIndexElement;

            this.RedBlackTree = new RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>();
        }

        private IΦParameterElementFactory ΦParameterElementFactory { get; }

        private int iIndexElement { get; }

        public bool HasCompleted => false;

        public RedBlackTree<int, RedBlackTree<int, ΦParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            int lIndexElement = obj.Key.Value.Value;

            RedBlackTree<INullableValue<int>, INullableValue<decimal>> value = obj.Value;

            var innerVisitor = new SurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<INullableValue<int>, INullableValue<decimal>>(
                this.ΦParameterElementFactory,
                iIndexElement,
                lIndexElement);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                lIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}