namespace Britt2022.A.A.CrossJoins.Factories.Mappings
{
    using Britt2022.A.A.CrossJoins.Classes.Mappings;
    using Britt2022.A.A.CrossJoins.Interfaces.Mappings;
    using Britt2022.A.A.CrossJoins.InterfacesFactories.Mappings;

    internal sealed class abMappingFactory : IabMappingFactory
    {
        public abMappingFactory()
        {
        }

        public IabMapping Create()
        {
            IabMapping mapping;

            try
            {
                mapping = new abMapping();
            }
            finally
            {
            }

            return mapping;
        }
    }
}