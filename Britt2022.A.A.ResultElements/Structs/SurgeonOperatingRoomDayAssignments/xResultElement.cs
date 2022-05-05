namespace Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments
{
    using Hl7.Fhir.Model;

    public struct xResultElement
    {
        public xResultElement(
            Organization surgeon,
            Location operatingRoom,
            FhirDateTime day,
            bool value)
        {
            this.Surgeon = surgeon;

            this.OperatingRoom = operatingRoom;

            this.Day = day;

            this.Value = value;
        }

        public Organization Surgeon { get; }

        public Location OperatingRoom { get; }

        public FhirDateTime Day { get; }

        public bool Value { get; }
    }
}