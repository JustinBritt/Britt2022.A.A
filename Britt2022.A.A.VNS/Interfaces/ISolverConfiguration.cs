namespace Britt2022.A.A.VNS.Interfaces
{
    using System.Collections.Immutable;

    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;

    public interface ISolverConfiguration : ISingleEmbeddedLocalSearchSolverConfiguration
    {
        ImmutableDictionary<int, INeighbourhoodStructureFactory> NeighbourhoodStructureFactories { get; }

        int NumberNeighbourhoodStructures { get; }
    }
}