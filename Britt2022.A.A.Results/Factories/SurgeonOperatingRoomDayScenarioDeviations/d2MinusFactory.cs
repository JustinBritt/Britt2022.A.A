namespace Britt2022.A.A.Results.Factories.SurgeonOperatingRoomDayScenarioDeviations
{
    using Britt2022.A.A.Results.Classes.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.Results.Interfaces.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;

    public sealed class d2MinusFactory : Id2MinusFactory
    {
        public d2MinusFactory()
        {
        }

        public Id2Minus Create()
        {
            Id2Minus result = null;

            try
            {
                result = new d2Minus();
            }
            finally
            {
            }

            return result;
        }
    }
}