namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class iωCrossJoinElementFactory : IiωCrossJoinElementFactory
    {
        public iωCrossJoinElementFactory()
        {
        }

        public iωCrossJoinElement Create(
            int iIndexElement,
            int ωIndexElement,
            int iωOI,
            int iωZI)
        {
            iωCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new iωCrossJoinElement(
                    iIndexElement: iIndexElement,
                    ωIndexElement: ωIndexElement,
                    iωOI: iωOI,
                    iωZI: iωZI);
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}