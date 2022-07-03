namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class jkCrossJoinElementFactory : IjkCrossJoinElementFactory
    {
        public jkCrossJoinElementFactory()
        {
        }

        public jkCrossJoinElement Create(
            int jIndexElement,
            int kIndexElement,
            int jkOI,
            int jkZI)
        {
            jkCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new jkCrossJoinElement(
                    jIndexElement: jIndexElement,
                    kIndexElement: kIndexElement,
                    jkOI: jkOI,
                    jkZI: jkZI);
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}