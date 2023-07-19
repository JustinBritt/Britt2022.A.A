namespace Britt2022.A.A.Contexts.Visitors
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.ParameterElements.InterfacesFactories.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;

    internal sealed class SurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<TKey, TValue> : ISurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : INullableValue<decimal>
    {
        public SurgeonDayScenarioCumulativeNumberPatientsSecondInnerVisitor(
            IΦParameterElementFactory ΦParameterElementFactory,
            int iIndexElement,
            int lIndexElement)
        {
            this.ΦParameterElementFactory = ΦParameterElementFactory;

            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;

            this.RedBlackTree = new RedBlackTree<int, ΦParameterElement>();
        }

        private IΦParameterElementFactory ΦParameterElementFactory { get; }

        private int iIndexElement { get; }

        private int lIndexElement { get; }

        public bool HasCompleted => false;

        public RedBlackTree<int, ΦParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            int ωIndexElement = obj.Key.Value.Value;

            this.RedBlackTree.Add(
                ωIndexElement,
                this.ΦParameterElementFactory.Create(
                    this.iIndexElement,
                    this.lIndexElement,
                    ωIndexElement,
                    (double)obj.Value.Value.Value));
        }
    }
}