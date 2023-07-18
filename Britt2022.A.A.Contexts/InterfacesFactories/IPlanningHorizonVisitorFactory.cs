namespace Britt2022.A.A.Contexts.InterfacesFactories
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.Contexts.InterfacesVisitors;

    public interface IPlanningHorizonVisitorFactory
    {
        IPlanningHorizonVisitor<TKey, TValue> Create<TKey, TValue>()
            where TKey : INullableValue<int>
            where TValue : FhirDateTime;
    }
}