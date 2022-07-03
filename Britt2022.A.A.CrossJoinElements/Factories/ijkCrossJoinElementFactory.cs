namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ijkCrossJoinElementFactory : IijkCrossJoinElementFactory
    {
        public ijkCrossJoinElementFactory()
        {
        }

        public ijkCrossJoinElement Create(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int ijOI,
            int ijkOI,
            int ijkZI,
            int ikOI,
            int jkOI)
        {
            ijkCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ijkCrossJoinElement(
                    iIndexElement: iIndexElement,
                    jIndexElement: jIndexElement,
                    kIndexElement: kIndexElement,
                    ijOI: ijOI,
                    ijkOI: ijkOI,
                    ijkZI: ijkZI,
                    ikOI: ikOI,
                    jkOI: jkOI);
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}