namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class kωCrossJoinElementFactory : IkωCrossJoinElementFactory
    {
        public kωCrossJoinElementFactory()
        {
        }

        public kωCrossJoinElement Create(
            int kIndexElement,
            int ωIndexElement,
            int kωOI,
            int kωZI)
        {
            kωCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new kωCrossJoinElement(
                    kIndexElement: kIndexElement,
                    ωIndexElement: ωIndexElement,
                    kωOI: kωOI,
                    kωZI: kωZI);
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}