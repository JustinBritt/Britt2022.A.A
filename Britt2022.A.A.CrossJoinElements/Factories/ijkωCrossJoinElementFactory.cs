namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ijkωCrossJoinElementFactory : IijkωCrossJoinElementFactory
    {
        public ijkωCrossJoinElementFactory()
        {
        }

        public ijkωCrossJoinElement Create(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int ωIndexElement,
            int ijkOI,
            int ijkωOI,
            int ijkωZI,
            int iωOI)
        {
            ijkωCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ijkωCrossJoinElement(
                    iIndexElement: iIndexElement,
                    jIndexElement: jIndexElement,
                    kIndexElement: kIndexElement,
                    ωIndexElement: ωIndexElement,
                    ijkOI: ijkOI,
                    ijkωOI: ijkωOI,
                    ijkωZI: ijkωZI,
                    iωOI: iωOI);
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}