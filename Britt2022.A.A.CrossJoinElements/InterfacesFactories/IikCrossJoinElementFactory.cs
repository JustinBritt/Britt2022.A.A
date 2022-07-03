namespace Britt2022.A.A.CrossJoinElements.InterfacesFactories
{
    using Britt2022.A.A.CrossJoinElements.Structs;

    public interface IikCrossJoinElementFactory
    {
        ikCrossJoinElement Create(
            int iIndexElement,
            int kIndexElement,
            int ikOI,
            int ikZI);
    }
}