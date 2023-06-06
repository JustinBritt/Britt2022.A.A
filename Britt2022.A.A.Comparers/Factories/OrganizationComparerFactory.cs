namespace Britt2022.A.A.Comparers.Factories
{
    using Britt2022.A.A.Comparers.Classes;
    using Britt2022.A.A.Comparers.Interfaces;
    using Britt2022.A.A.Comparers.InterfacesFactories;

    internal sealed class OrganizationComparerFactory : IOrganizationComparerFactory
    {
        public OrganizationComparerFactory()
        {
        }

        public IOrganizationComparer Create()
        {
            IOrganizationComparer instance = null;

            try
            {
                instance = new OrganizationComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}