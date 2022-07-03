namespace Britt2022.A.A.CrossJoins.AbstractFactories
{
    using Britt2022.A.A.CrossJoins.Factories.Mappings;
    using Britt2022.A.A.CrossJoins.InterfacesAbstractFactories;
    using Britt2022.A.A.CrossJoins.InterfacesFactories.Mappings;

    public sealed class CrossJoinsAbstractFactory : ICrossJoinsAbstractFactory
    {
        public CrossJoinsAbstractFactory()
        {
        }

        public IabMappingFactory CreateabMappingFactory()
        {
            IabMappingFactory factory = null;

            try
            {
                factory = new abMappingFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IabcMappingFactory CreateabcMappingFactory()
        {
            IabcMappingFactory factory = null;

            try
            {
                factory = new abcMappingFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IabcdMappingFactory CreateabcdMappingFactory()
        {
            IabcdMappingFactory factory = null;

            try
            {
                factory = new abcdMappingFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}