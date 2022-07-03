namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ikCrossJoinElementFactory : IikCrossJoinElementFactory
    {
        public ikCrossJoinElementFactory()
        {
        }

        public ikCrossJoinElement Create(
            int iIndexElement,
            int kIndexElement,
            int ikOI,
            int ikZI)
        {
            ikCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ikCrossJoinElement(
                    iIndexElement: iIndexElement,
                    kIndexElement: kIndexElement,
                    ikOI: ikOI,
                    ikZI: ikZI);
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}