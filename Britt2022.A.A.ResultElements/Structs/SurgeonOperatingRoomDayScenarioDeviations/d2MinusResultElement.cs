namespace Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations
{
    using Hl7.Fhir.Model;

    public struct d2MinusResultElement
    {
        public d2MinusResultElement(
            Organization surgeon,
            Location operatingRoom,
            FhirDateTime day,
            INullableValue<int> scenario,
            decimal value)
        {
            this.Surgeon = surgeon;

            this.OperatingRoom = operatingRoom;

            this.Day = day;

            this.Scenario = scenario;

            this.Value = value;
        }

        public Organization Surgeon { get; }

        public Location OperatingRoom { get; }

        public FhirDateTime Day { get; }

        public INullableValue<int> Scenario { get; }

        public decimal Value { get; }
    }
}