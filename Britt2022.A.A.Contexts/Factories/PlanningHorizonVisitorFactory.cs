namespace Britt2022.A.A.Contexts.Factories
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.Contexts.InterfacesFactories;
    using Britt2022.A.A.Contexts.InterfacesVisitors;
    using Britt2022.A.A.Contexts.Visitors;

    internal sealed class PlanningHorizonVisitorFactory : IPlanningHorizonVisitorFactory
    {
        public PlanningHorizonVisitorFactory()
        {
        }

        public IPlanningHorizonVisitor<TKey, TValue> Create<TKey, TValue>()
            where TKey : INullableValue<int>
            where TValue : FhirDateTime
        {
            IPlanningHorizonVisitor<TKey, TValue> instance = null;

            try
            {
                instance = new PlanningHorizonVisitor<TKey, TValue>();
            }
            finally
            {
            }

            return instance;
        }
    }
}