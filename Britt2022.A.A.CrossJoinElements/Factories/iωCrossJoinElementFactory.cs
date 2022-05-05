namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class iωCrossJoinElementFactory : IiωCrossJoinElementFactory
    {
        public iωCrossJoinElementFactory()
        {
        }

        public iωCrossJoinElement Create()
        {
            iωCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new iωCrossJoinElement();
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}