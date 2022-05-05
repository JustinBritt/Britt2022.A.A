namespace Britt2022.A.A.Results.AbstractFactories
{
    using Britt2022.A.A.Results.InterfacesAbstractFactories;

    public sealed class AbstractFactory : IAbstractFactory
    {
        public AbstractFactory()
        {
        }

        public IResultsAbstractFactory CreateResultsAbstractFactory()
        {
            IResultsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ResultsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }
    }
}