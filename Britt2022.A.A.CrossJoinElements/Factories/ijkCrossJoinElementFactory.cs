namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ijkCrossJoinElementFactory : IijkCrossJoinElementFactory
    {
        public ijkCrossJoinElementFactory()
        {
        }

        public ijkCrossJoinElement Create()
        {
            ijkCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ijkCrossJoinElement();
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}