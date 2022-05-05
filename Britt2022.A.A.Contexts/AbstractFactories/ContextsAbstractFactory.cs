namespace Britt2022.A.A.Contexts.AbstractFactories
{
    using Britt2022.A.A.Contexts.Factories;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.InterfacesFactories;

    public sealed class ContextsAbstractFactory : IContextsAbstractFactory
    {
        public ContextsAbstractFactory()
        {
        }

        public IWGPMInputContextFactory CreateWGPMInputContextFactory()
        {
            IWGPMInputContextFactory factory = null;

            try
            {
                factory = new WGPMInputContextFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IWGPMOutputContextFactory CreateWGPMOutputContextFactory()
        {
            IWGPMOutputContextFactory factory = null;

            try
            {
                factory = new WGPMOutputContextFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}