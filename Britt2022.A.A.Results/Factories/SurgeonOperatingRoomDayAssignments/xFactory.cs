namespace Britt2022.A.A.Results.Factories.SurgeonOperatingRoomDayAssignments
{
    using Britt2022.A.A.Results.Classes.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.Results.Interfaces.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.A.Results.InterfacesFactories.SurgeonOperatingRoomDayAssignments;

    public sealed class xFactory : IxFactory
    {
        public xFactory()
        {
        }

        public Ix Create()
        {
            Ix result = null;

            try
            {
                result = new x();
            }
            finally
            {
            }

            return result;
        }
    }
}