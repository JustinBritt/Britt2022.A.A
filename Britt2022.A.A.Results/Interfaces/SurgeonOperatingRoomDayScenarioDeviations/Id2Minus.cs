namespace Britt2022.A.A.Results.Interfaces.SurgeonOperatingRoomDayScenarioDeviations
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;

    public interface Id2Minus
    {
        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<d2MinusResultElement> d2Minus);
    }
}