namespace Britt2022.A.A.Models.AbstractFactories
{
    using Britt2022.A.A.Models.Factories;
    using Britt2022.A.A.Models.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.InterfacesFactories;

    public sealed class ModelsAbstractFactory : IModelsAbstractFactory
    {
        public ModelsAbstractFactory()
        {
        }

        public IWGPMModelFactory CreateWGPMModelFactory()
        {
            IWGPMModelFactory factory = null;

            try
            {
                factory = new WGPMModelFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}