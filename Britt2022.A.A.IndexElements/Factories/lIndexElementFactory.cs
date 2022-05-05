namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class lIndexElementFactory : IlIndexElementFactory
    {
        public lIndexElementFactory()
        {
        }

        public lIndexElement Create()
        {
            lIndexElement indexElement;

            try
            {
                indexElement = new lIndexElement();
            }
            finally
            {
            }

            return indexElement;
        }
    }
}