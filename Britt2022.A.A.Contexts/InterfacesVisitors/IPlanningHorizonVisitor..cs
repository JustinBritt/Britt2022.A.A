namespace Britt2022.A.A.Contexts.InterfacesVisitors
{
    using System.Collections.Generic;

    using Hl7.Fhir.Model;

    using NGenerics.Patterns.Visitor;
    
    public interface IPlanningHorizonVisitor<TKey, TValue> : IVisitor<KeyValuePair<TKey, TValue>>
        where TKey : INullableValue<int>
        where TValue : FhirDateTime
    {
        FhirDateTime[] GetValue();
    }
}