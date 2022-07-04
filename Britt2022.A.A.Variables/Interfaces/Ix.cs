namespace Britt2022.A.A.Variables.Interfaces
{
    using System;

    using Hl7.Fhir.Model;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.VariableElements.Structs;

    public interface Ix
    {
        ReadOnlySpan<xResultElement> GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            FhirDateTime[] planningHorizon,
            Location[] operatingRooms,
            Organization[] surgeons,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<xVariableElement> x);
    }
}