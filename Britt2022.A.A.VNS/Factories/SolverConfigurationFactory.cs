namespace Britt2022.A.A.VNS.Factories
{
    using System.Collections.Immutable;

    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.VNS.Classes;
    using Britt2022.A.A.VNS.Interfaces;
    using Britt2022.A.A.VNS.InterfacesFactories;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        public SolverConfigurationFactory()
        {
        }

        public ISolverConfiguration Create(
            ImmutableDictionary<int, INeighbourhoodStructureFactory> neighbourhoodStructureFactories,
            int numberNeighbourhoodStructures)
        {
            ISolverConfiguration solverConfiguration = null;

            try
            {
                solverConfiguration = new SolverConfiguration(
                    neighbourhoodStructureFactories: neighbourhoodStructureFactories,
                    numberNeighbourhoodStructures: numberNeighbourhoodStructures);
            }
            finally
            {
            }

            return solverConfiguration;
        }
    }
}