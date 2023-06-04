namespace Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;

    public interface Id2MinusResultElementFactory
    {
        d2MinusResultElement Create(
            Organization surgeon,
            Location operatingRoom,
            FhirDateTime day,
            INullableValue<int> scenario,
            decimal value);
    }
}