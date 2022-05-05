namespace Britt2022.A.A.Exports.InterfacesAbstractFactories
{
    using Britt2022.A.A.Exports.InterfacesFactories;

    public interface IExportsAbstractFactory
    {
        IWGPMExportFactory CreateWGPMExportFactory();
    }
}