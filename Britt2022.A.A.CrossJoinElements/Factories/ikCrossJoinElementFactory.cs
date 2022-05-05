namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ikCrossJoinElementFactory : IikCrossJoinElementFactory
    {
        public ikCrossJoinElementFactory()
        {
        }

        public ikCrossJoinElement Create()
        {
            ikCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ikCrossJoinElement();
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}