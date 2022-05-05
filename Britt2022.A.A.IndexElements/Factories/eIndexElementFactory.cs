namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class eIndexElementFactory : IeIndexElementFactory
    {
        public eIndexElementFactory()
        {
        }

        public eIndexElement Create()
        {
            eIndexElement indexElement;

            try
            {
                indexElement = new eIndexElement();
            }
            finally
            {
            }

            return indexElement;
        }
    }
}