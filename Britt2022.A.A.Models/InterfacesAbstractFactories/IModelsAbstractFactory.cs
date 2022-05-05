namespace Britt2022.A.A.Models.InterfacesAbstractFactories
{
    using Britt2022.A.A.Models.InterfacesFactories;

    public interface IModelsAbstractFactory
    {
        IWGPMModelFactory CreateWGPMModelFactory();
    }
}