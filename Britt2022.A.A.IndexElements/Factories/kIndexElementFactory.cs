namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class kIndexElementFactory : IkIndexElementFactory
    {
        public kIndexElementFactory()
        {
        }

        public kIndexElement Create(
            int value)
        {
            kIndexElement indexElement;

            try
            {
                indexElement = new kIndexElement(
                    value);
            }
            finally
            {
            }

            return indexElement;
        }
    }
}