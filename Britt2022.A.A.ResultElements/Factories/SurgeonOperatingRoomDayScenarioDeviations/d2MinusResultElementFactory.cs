namespace Britt2022.A.A.ResultElements.Factories.SurgeonOperatingRoomDayScenarioDeviations
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2MinusResultElementFactory : Id2MinusResultElementFactory
    {
        public d2MinusResultElementFactory()
        {
        }

        public d2MinusResultElement Create(
            Organization surgeon,
            Location operatingRoom,
            FhirDateTime day,
            INullableValue<int> scenario,
            decimal value)
        {
            d2MinusResultElement resultElement = default;

            try
            {
                resultElement = new d2MinusResultElement(
                    surgeon: surgeon,
                    operatingRoom: operatingRoom,
                    day: day,
                    scenario: scenario,
                    value: value);
            }
            finally
            {
            }

            return resultElement;
        }
    }
}