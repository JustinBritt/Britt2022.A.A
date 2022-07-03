namespace Britt2022.A.A.CrossJoinElements.InterfacesFactories
{
    using Britt2022.A.A.CrossJoinElements.Structs;

    public interface IjkCrossJoinElementFactory
    {
        jkCrossJoinElement Create(
            int jIndexElement,
            int kIndexElement,
            int jkOI,
            int jkZI);
    }
}