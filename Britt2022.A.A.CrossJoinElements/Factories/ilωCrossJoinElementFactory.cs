namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ilωCrossJoinElementFactory : IilωCrossJoinElementFactory
    {
        public ilωCrossJoinElementFactory()
        {
        }

        public ilωCrossJoinElement Create(
            int iIndexElement,
            int lIndexElement,
            int ωIndexElement,
            int ilωOI,
            int ilωZI)
        {
            ilωCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ilωCrossJoinElement(
                    iIndexElement: iIndexElement,
                    lIndexElement: lIndexElement,
                    ωIndexElement: ωIndexElement,
                    ilωOI: ilωOI,
                    ilωZI: ilωZI);
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}