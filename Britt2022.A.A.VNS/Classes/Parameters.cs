namespace Britt2022.A.A.VNS.Classes
{
    using System.Collections.Immutable;

    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.VNS.Interfaces;

    internal sealed class Parameters : IParameters
    {
        public Parameters(
            ImmutableDictionary<int, INeighbourhoodStructureFactory> neighbourhoodStructureFactories,
            int numberNeighbourhoodStructures)
        {
            this.NeighbourhoodStructureFactories = neighbourhoodStructureFactories;

            this.NumberNeighbourhoodStructures = numberNeighbourhoodStructures;
        }

        public ImmutableDictionary<int, INeighbourhoodStructureFactory> NeighbourhoodStructureFactories { get; }

        public int NumberNeighbourhoodStructures { get; }
    }
}