namespace Britt2022.A.A.Comparers.AbstractFactories
{
    using Britt2022.A.A.Comparers.Factories;
    using Britt2022.A.A.Comparers.InterfacesAbstractFactories;
    using Britt2022.A.A.Comparers.InterfacesFactories;

    internal sealed class ComparersAbstractFactory : IComparersAbstractFactory
    {
        public ComparersAbstractFactory()
        {
        }

        public IOrganizationComparerFactory CreateOrganizationComparerFactory()
        {
            IOrganizationComparerFactory factory = null;

            try
            {
                factory = new OrganizationComparerFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}