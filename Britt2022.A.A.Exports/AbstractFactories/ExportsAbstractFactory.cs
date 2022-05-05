namespace Britt2022.A.A.Exports.AbstractFactories
{
    using Britt2022.A.A.Exports.Factories;
    using Britt2022.A.A.Exports.InterfacesAbstractFactories;
    using Britt2022.A.A.Exports.InterfacesFactories;

    public sealed class ExportsAbstractFactory : IExportsAbstractFactory
    {
        public ExportsAbstractFactory()
        {
        }

        public IWGPMExportFactory CreateWGPMExportFactory()
        {
            IWGPMExportFactory factory = null;

            try
            {
                factory = new WGPMExportFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}