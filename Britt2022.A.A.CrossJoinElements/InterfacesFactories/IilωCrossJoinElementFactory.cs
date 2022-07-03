namespace Britt2022.A.A.CrossJoinElements.InterfacesFactories
{
    using Britt2022.A.A.CrossJoinElements.Structs;

    public interface IilωCrossJoinElementFactory
    {
        ilωCrossJoinElement Create(
            int iIndexElement,
            int lIndexElement,
            int ωIndexElement,
            int ilωOI,
            int ilωZI);
    }
}