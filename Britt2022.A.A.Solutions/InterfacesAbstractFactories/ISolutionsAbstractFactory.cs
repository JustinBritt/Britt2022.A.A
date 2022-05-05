namespace Britt2022.A.A.Solutions.InterfacesAbstractFactories
{
    using Britt2022.A.A.Solutions.InterfacesFactories;

    public interface ISolutionsAbstractFactory
    {
        IWGPMSolutionFactory CreateWGPMSolutionFactory();
    }
}