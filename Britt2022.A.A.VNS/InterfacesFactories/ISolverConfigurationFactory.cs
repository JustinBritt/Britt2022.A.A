namespace Britt2022.A.A.VNS.InterfacesFactories
{
    using System.Collections.Immutable;

    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.VNS.Interfaces;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            ImmutableDictionary<int, INeighbourhoodStructureFactory> neighbourhoodStructureFactories,
            int numberNeighbourhoodStructures);
    }
}