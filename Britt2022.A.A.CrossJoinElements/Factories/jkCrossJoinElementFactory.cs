namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class jkCrossJoinElementFactory : IjkCrossJoinElementFactory
    {
        public jkCrossJoinElementFactory()
        {
        }

        public jkCrossJoinElement Create()
        {
            jkCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new jkCrossJoinElement();
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}