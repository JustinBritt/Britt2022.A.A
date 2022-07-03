namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ijCrossJoinElementFactory : IijCrossJoinElementFactory
    {
        public ijCrossJoinElementFactory()
        {
        }

        public ijCrossJoinElement Create(
            int iIndexElement,
            int jIndexElement,
            int ijOI,
            int ijZI)
        {
            ijCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ijCrossJoinElement(
                    iIndexElement: iIndexElement,
                    jIndexElement: jIndexElement,
                    ijOI: ijOI,
                    ijZI: ijZI);
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}