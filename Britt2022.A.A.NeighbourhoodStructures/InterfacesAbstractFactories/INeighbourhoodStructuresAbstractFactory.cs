namespace Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories
{
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;

    public interface INeighbourhoodStructuresAbstractFactory
    {
        IRandomPairwiseSwapFactory CreateRandomPairwiseSwapFactory();
    }
}