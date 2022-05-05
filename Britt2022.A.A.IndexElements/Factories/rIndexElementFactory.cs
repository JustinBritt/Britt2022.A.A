namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class rIndexElementFactory : IrIndexElementFactory
    {
        public rIndexElementFactory()
        {
        }

        public rIndexElement Create()
        {
            rIndexElement indexElement;

            try
            {
                indexElement = new rIndexElement();
            }
            finally
            {
            }

            return indexElement;
        }
    }
}