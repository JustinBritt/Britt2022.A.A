namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class ωIndexElementFactory : IωIndexElementFactory
    {
        public ωIndexElementFactory()
        {
        }

        public ωIndexElement Create()
        {
            ωIndexElement indexElement;

            try
            {
                indexElement = new ωIndexElement();
            }
            finally
            {
            }

            return indexElement;
        }
    }
}