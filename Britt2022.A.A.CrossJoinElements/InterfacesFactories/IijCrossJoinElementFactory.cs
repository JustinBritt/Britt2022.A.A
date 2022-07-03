namespace Britt2022.A.A.CrossJoinElements.InterfacesFactories
{
    using Britt2022.A.A.CrossJoinElements.Structs;

    public interface IijCrossJoinElementFactory
    {
        ijCrossJoinElement Create(
            int iIndexElement,
            int jIndexElement,
            int ijOI,
            int ijZI);
    }
}