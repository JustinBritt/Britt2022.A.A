namespace Britt2022.A.A.CrossJoinElements.InterfacesFactories
{
    using Britt2022.A.A.CrossJoinElements.Structs;

    public interface IijkωCrossJoinElementFactory
    {
        ijkωCrossJoinElement Create(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int ωIndexElement,
            int ijkOI,
            int ijkωOI,
            int ijkωZI,
            int iωOI);
    }
}