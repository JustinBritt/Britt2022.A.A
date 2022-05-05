namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ilωCrossJoinElementFactory : IilωCrossJoinElementFactory
    {
        public ilωCrossJoinElementFactory()
        {
        }

        public ilωCrossJoinElement Create()
        {
            ilωCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ilωCrossJoinElement();
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}