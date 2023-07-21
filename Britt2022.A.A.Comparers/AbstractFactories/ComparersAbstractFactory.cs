namespace Britt2022.A.A.Comparers.AbstractFactories
{
    using Britt2022.A.A.Comparers.Factories;
    using Britt2022.A.A.Comparers.InterfacesAbstractFactories;
    using Britt2022.A.A.Comparers.InterfacesFactories;

    public sealed class ComparersAbstractFactory : IComparersAbstractFactory
    {
        public ComparersAbstractFactory()
        {
        }

        public IFhirDateTimeComparerFactory CreateFhirDateTimeComparerFactory()
        {
            IFhirDateTimeComparerFactory factory = null;

            try
            {
                factory = new FhirDateTimeComparerFactory();
            }
            finally
            {
            }

            return factory;
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