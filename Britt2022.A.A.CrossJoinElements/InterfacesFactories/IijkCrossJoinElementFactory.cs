namespace Britt2022.A.A.CrossJoinElements.InterfacesFactories
{
    using Britt2022.A.A.CrossJoinElements.Structs;

    public interface IijkCrossJoinElementFactory
    {
        ijkCrossJoinElement Create(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int ijOI,
            int ijkOI,
            int ijkZI,
            int ikOI,
            int jkOI);
    }
}