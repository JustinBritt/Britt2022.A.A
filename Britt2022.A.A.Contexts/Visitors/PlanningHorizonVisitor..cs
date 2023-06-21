namespace Britt2022.A.A.Contexts.Visitors
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.IndexElements.InterfacesFactories;

    internal sealed class PlanningHorizonVisitor<TKey, TValue> : IPlanningHorizonVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        public PlanningHorizonVisitor(
            IkIndexElementFactory kIndexElementFactory)
        {
            this.kIndexElementFactory = kIndexElementFactory;

            this.Value = new List<FhirDateTime>();
        }

        private IkIndexElementFactory kIndexElementFactory { get; }

        public bool HasCompleted => false;

        private List<FhirDateTime> Value { get; }

        public FhirDateTime[] GetValue()
        {
            return this.Value.ToArray();
        }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.Value.Add(
                obj.Value);
        }
    }
}