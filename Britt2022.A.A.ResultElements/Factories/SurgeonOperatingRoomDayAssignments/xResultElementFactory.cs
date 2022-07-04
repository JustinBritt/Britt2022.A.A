namespace Britt2022.A.A.ResultElements.Factories.SurgeonOperatingRoomDayAssignments
{
    using Hl7.Fhir.Model;

    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;

    internal sealed class xResultElementFactory : IxResultElementFactory
    {
        public xResultElementFactory()
        {
        }

        public xResultElement Create(
            Organization surgeon,
            Location operatingRoom,
            FhirDateTime day,
            bool value)
        {
            xResultElement resultElement = default;

            try
            {
                resultElement = new xResultElement(
                    surgeon: surgeon,
                    operatingRoom: operatingRoom,
                    day: day,
                    value: value);
            }
            finally
            {
            }

            return resultElement;
        }
    }
}