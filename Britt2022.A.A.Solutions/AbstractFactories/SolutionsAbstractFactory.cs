namespace Britt2022.A.A.Solutions.AbstractFactories
{
    using Britt2022.A.A.Solutions.Factories;
    using Britt2022.A.A.Solutions.InterfacesAbstractFactories;
    using Britt2022.A.A.Solutions.InterfacesFactories;

    public sealed class SolutionsAbstractFactory : ISolutionsAbstractFactory
    {
        public SolutionsAbstractFactory()
        {
        }

        public IWGPMSolutionFactory CreateWGPMSolutionFactory()
        {
            IWGPMSolutionFactory factory = null;

            try
            {
                factory = new WGPMSolutionFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}