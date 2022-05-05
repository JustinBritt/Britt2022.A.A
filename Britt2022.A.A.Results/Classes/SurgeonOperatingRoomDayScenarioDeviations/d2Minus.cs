namespace Britt2022.A.A.Results.Classes.SurgeonOperatingRoomDayScenarioDeviations
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.Results.Interfaces.SurgeonOperatingRoomDayScenarioDeviations;

    public sealed class d2Minus : Id2Minus
    {
        public d2Minus()
        {
        }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<d2MinusResultElement> d2Minus)
        {
            return d2Minus.ToArray().ToImmutableList()
                .Select(
                w => Tuple.Create(
                    w.Surgeon,
                    w.OperatingRoom,
                    w.Day,
                    (INullableValue<int>)w.Scenario,
                    nullableValueFactory.Create<decimal>(
                        w.Value)))
                .ToImmutableList();
        }
    }
}