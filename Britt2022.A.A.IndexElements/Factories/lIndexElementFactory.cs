namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class lIndexElementFactory : IlIndexElementFactory
    {
        public lIndexElementFactory()
        {
        }

        public lIndexElement Create(
            int value)
        {
            lIndexElement indexElement;

            try
            {
                indexElement = new lIndexElement(
                    value);
            }
            finally
            {
            }

            return indexElement;
        }
    }
}