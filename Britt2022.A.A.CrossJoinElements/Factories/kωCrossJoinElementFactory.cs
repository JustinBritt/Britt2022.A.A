namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class kωCrossJoinElementFactory : IkωCrossJoinElementFactory
    {
        public kωCrossJoinElementFactory()
        {
        }

        public kωCrossJoinElement Create()
        {
            kωCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new kωCrossJoinElement();
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}