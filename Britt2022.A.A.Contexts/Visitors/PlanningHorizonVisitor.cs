namespace Britt2022.A.A.Contexts.Visitors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.IndexElements.InterfacesFactories;

    public sealed class PlanningHorizonVisitor<TKey, TValue> : IPlanningHorizonVisitor<TKey, TValue>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        public PlanningHorizonVisitor()
        {
            this.Value = new List<FhirDateTime>();
        }

        public bool HasCompleted => false;

        private List<FhirDateTime> Value { get; }

        public FhirDateTime[] GetValue()
        {
            return this.Value
                .OrderBy(w => w.ToDateTimeOffset(TimeSpan.Zero).UtcDateTime.Date)
                .ToArray();
        }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            this.Value.Add(
                obj.Value);
        }
    }
}