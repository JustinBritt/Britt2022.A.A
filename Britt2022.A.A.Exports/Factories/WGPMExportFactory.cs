namespace Britt2022.A.A.Exports.Factories
{
    using Britt2022.A.A.Exports.Classes;
    using Britt2022.A.A.Exports.Interfaces;
    using Britt2022.A.A.Exports.InterfacesFactories;

    internal sealed class WGPMExportFactory : IWGPMExportFactory
    {
        public WGPMExportFactory()
        {
        }

        public IWGPMExport Create()
        {
            IWGPMExport export;

            try
            {
                export = new WGPMExport();
            }
            finally
            {
            }

            return export;
        }
    }
}