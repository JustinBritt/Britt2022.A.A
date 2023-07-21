namespace Britt2022.A.A.Comparers.Factories
{
    using Britt2022.A.A.Comparers.Classes;
    using Britt2022.A.A.Comparers.Interfaces;
    using Britt2022.A.A.Comparers.InterfacesFactories;

    internal sealed class FhirDateTimeComparerFactory : IFhirDateTimeComparerFactory
    {
        public FhirDateTimeComparerFactory()
        {
        }

        public IFhirDateTimeComparer Create()
        {
            IFhirDateTimeComparer instance = null;

            try
            {
                instance = new FhirDateTimeComparer();
            }
            finally
            {
            }

            return instance;
        }
    }
}