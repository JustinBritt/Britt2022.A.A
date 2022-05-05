namespace Britt2022.A.A.ResultElements.Factories.SurgeonOperatingRoomDayAssignments
{
    using Britt2022.A.A.ResultElements.InterfacesFactories.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.ResultElements.Structs.SurgeonOperatingRoomDayAssignments;

    internal sealed class xResultElementFactory : IxResultElementFactory
    {
        public xResultElementFactory()
        {
        }

        public xResultElement Create()
        {
            xResultElement resultElement = default;

            try
            {
                resultElement = new xResultElement();
            }
            finally
            {
            }

            return resultElement;
        }
    }
}