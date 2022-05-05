namespace Britt2022.A.A.CrossJoins.Factories.Mappings
{
    using Britt2022.A.A.CrossJoins.Classes.Mappings;
    using Britt2022.A.A.CrossJoins.Interfaces.Mappings;
    using Britt2022.A.A.CrossJoins.InterfacesFactories.Mappings;

    internal sealed class abcMappingFactory : IabcMappingFactory
    {
        public abcMappingFactory()
        {
        }

        public IabcMapping Create()
        {
            IabcMapping mapping;

            try
            {
                mapping = new abcMapping();
            }
            finally
            {
            }

            return mapping;
        }
    }
}