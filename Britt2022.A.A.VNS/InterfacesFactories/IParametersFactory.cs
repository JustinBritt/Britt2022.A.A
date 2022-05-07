namespace Britt2022.A.A.VNS.InterfacesFactories
{
    using System.Collections.Immutable;

    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.VNS.Interfaces;

    public interface IParametersFactory
    {
        IParameters Create(
            ImmutableDictionary<int, INeighbourhoodStructureFactory> neighbourhoodStructureFactories,
            int numberNeighbourhoodStructures);

        IParameters Create(
            ISolverConfiguration solverConfiguration);
    }
}