namespace Britt2022.A.A.CrossJoinElements.Factories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;

    internal sealed class ijCrossJoinElementFactory : IijCrossJoinElementFactory
    {
        public ijCrossJoinElementFactory()
        {
        }

        public ijCrossJoinElement Create()
        {
            ijCrossJoinElement crossJoinElement;

            try
            {
                crossJoinElement = new ijCrossJoinElement();
            }
            finally
            {
            }

            return crossJoinElement;
        }
    }
}