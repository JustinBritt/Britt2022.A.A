namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class eIndexElementFactory : IeIndexElementFactory
    {
        public eIndexElementFactory()
        {
        }

        public eIndexElement Create(
            int value)
        {
            eIndexElement indexElement;

            try
            {
                indexElement = new eIndexElement(
                    value);
            }
            finally
            {
            }

            return indexElement;
        }
    }
}