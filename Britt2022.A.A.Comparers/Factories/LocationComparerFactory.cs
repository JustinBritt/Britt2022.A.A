namespace Britt2022.A.A.Comparers.Factories
{
    using Britt2022.A.A.Comparers.Classes;
    using Britt2022.A.A.Comparers.Interfaces;
    using Britt2022.A.A.Comparers.InterfacesFactories;

    internal sealed class LocationComparerFactory : ILocationComparerFactory
    {
        public LocationComparerFactory()
        {
        }

        public ILocationComparer Create()
        {
            ILocationComparer instance = null;

            try
            {
                instance = new LocationComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}