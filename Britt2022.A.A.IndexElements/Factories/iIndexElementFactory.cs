namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class iIndexElementFactory : IiIndexElementFactory
    {
        public iIndexElementFactory()
        {
        }

        public iIndexElement Create()
        {
            iIndexElement indexElement;

            try
            {
                indexElement = new iIndexElement();
            }
            finally
            {
            }

            return indexElement;
        }
    }
}