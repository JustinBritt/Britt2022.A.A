namespace Britt2022.A.A.IndexElements.Factories
{
    using Britt2022.A.A.IndexElements.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;

    internal sealed class jIndexElementFactory : IjIndexElementFactory
    {
        public jIndexElementFactory()
        {
        }

        public jIndexElement Create(
            int value)
        {
            jIndexElement indexElement;

            try
            {
                indexElement = new jIndexElement(
                    value);
            }
            finally
            {
            }

            return indexElement;
        }
    }
}