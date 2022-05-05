namespace Britt2022.A.A.Contexts.InterfacesAbstractFactories
{
    using Britt2022.A.A.Contexts.InterfacesFactories;

    public interface IContextsAbstractFactory
    {
        IWGPMInputContextFactory CreateWGPMInputContextFactory();

        IWGPMOutputContextFactory CreateWGPMOutputContextFactory();
    }
}