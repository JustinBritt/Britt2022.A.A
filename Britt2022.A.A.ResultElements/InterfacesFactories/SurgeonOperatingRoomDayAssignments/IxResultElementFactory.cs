namespace Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayAssignments
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;

    public interface IxResultElementFactory
    {
        xResultElement Create(
            Organization surgeon,
            Location operatingRoom,
            FhirDateTime day,
            bool value);
    }
}