namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ijkωCrossJoinElementFactory : IijkωCrossJoinElementFactory
    {
        public ijkωCrossJoinElementFactory()
        {
        }

        public ijkωCrossJoinElement Create()
        {
            ijkωCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ijkωCrossJoinElement();
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}