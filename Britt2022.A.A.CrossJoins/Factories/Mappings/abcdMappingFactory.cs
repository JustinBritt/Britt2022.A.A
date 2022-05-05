namespace Britt2022.A.A.CrossJoins.Factories.Mappings
{
    using Britt2022.A.A.CrossJoins.Classes.Mappings;
    using Britt2022.A.A.CrossJoins.Interfaces.Mappings;
    using Britt2022.A.A.CrossJoins.InterfacesFactories.Mappings;

    internal sealed class abcdMappingFactory : IabcdMappingFactory
    {
        public abcdMappingFactory()
        {
        }

        public IabcdMapping Create()
        {
            IabcdMapping mapping;

            try
            {
                mapping = new abcdMapping();
            }
            finally
            {
            }

            return mapping;
        }
    }
}