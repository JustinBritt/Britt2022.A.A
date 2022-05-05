namespace Britt2022.A.A.ResultElements.Factories.SurgeonOperatingRoomDayScenarioDeviations
{
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2MinusResultElementFactory : Id2MinusResultElementFactory
    {
        public d2MinusResultElementFactory()
        {
        }

        public d2MinusResultElement Create()
        {
            d2MinusResultElement resultElement = default;

            try
            {
                resultElement = new d2MinusResultElement();
            }
            finally
            {
            }

            return resultElement;
        }
    }
}