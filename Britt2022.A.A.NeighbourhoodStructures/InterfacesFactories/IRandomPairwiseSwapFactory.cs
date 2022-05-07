namespace Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories
{
    using Britt2022.A.A.NeighbourhoodStructures.Interfaces;

    public interface IRandomPairwiseSwapFactory : INeighbourhoodStructureFactory
    {
        INeighbourhoodStructure Create();
    }
}