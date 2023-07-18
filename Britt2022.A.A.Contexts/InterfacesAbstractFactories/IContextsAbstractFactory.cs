namespace Britt2022.A.A.Contexts.InterfacesAbstractFactories
{
    using Britt2022.A.A.Contexts.InterfacesFactories;

    public interface IContextsAbstractFactory
    {
        IPlanningHorizonVisitorFactory CreatePlanningHorizonVisitorFactory();

        IWGPMInputContextFactory CreateWGPMInputContextFactory();

        IWGPMOutputContextFactory CreateWGPMOutputContextFactory();
    }
}