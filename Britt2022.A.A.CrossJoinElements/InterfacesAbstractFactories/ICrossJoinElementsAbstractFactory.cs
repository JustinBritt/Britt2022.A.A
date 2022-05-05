namespace Britt2022.A.A.CrossJoinElements.InterfacesAbstractFactories
{
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;

    public interface ICrossJoinElementsAbstractFactory
    {
        IijCrossJoinElementFactory CreateijCrossJoinElementFactory();

        IijkCrossJoinElementFactory CreateijkCrossJoinElementFactory();

        IijkωCrossJoinElementFactory CreateijkωCrossJoinElementFactory();

        IikCrossJoinElementFactory CreateikCrossJoinElementFactory();

        IilωCrossJoinElementFactory CreateilωCrossJoinElementFactory();

        IiωCrossJoinElementFactory CreateiωCrossJoinElementFactory();

        IjkCrossJoinElementFactory CreatejkCrossJoinElementFactory();

        IkωCrossJoinElementFactory CreatekωCrossJoinElementFactory();
    }
}