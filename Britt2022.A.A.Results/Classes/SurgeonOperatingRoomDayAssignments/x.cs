namespace Britt2022.A.A.Results.Classes.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesFactories;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.Results.Interfaces.SurgeonOperatingRoomDayAssignments;

    public sealed class x : Ix
    {
        public x()
        {
        }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            ReadOnlySpan<xResultElement> x)
        {
            return x.ToArray().ToImmutableList()
                .Select(
                w => Tuple.Create(
                    w.Surgeon,
                    w.OperatingRoom,
                    w.Day,
                    nullableValueFactory.Create<bool>(
                        w.Value)))
                .ToImmutableList();
        }
    }
}