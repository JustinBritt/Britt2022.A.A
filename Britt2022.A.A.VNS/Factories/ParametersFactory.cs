namespace Britt2022.A.A.VNS.Factories
{
    using System.Collections.Immutable;

    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.VNS.Classes;
    using Britt2022.A.A.VNS.Interfaces;
    using Britt2022.A.A.VNS.InterfacesFactories;

    internal sealed class ParametersFactory : IParametersFactory
    {
        public ParametersFactory()
        {
        }

        public IParameters Create(
            ImmutableDictionary<int, INeighbourhoodStructureFactory> neighbourhoodStructureFactories,
            int numberNeighbourhoodStructures)
        {
            IParameters parameters = null;

            try
            {
                parameters = new Parameters(
                    neighbourhoodStructureFactories: neighbourhoodStructureFactories,
                    numberNeighbourhoodStructures: numberNeighbourhoodStructures);
            }
            finally
            {
            }

            return parameters;
        }

        public IParameters Create(
            ISolverConfiguration solverConfiguration)
        {
            IParameters parameters = null;

            try
            {
                parameters = new Parameters(
                    neighbourhoodStructureFactories: solverConfiguration.NeighbourhoodStructureFactories,
                    numberNeighbourhoodStructures: solverConfiguration.NumberNeighbourhoodStructures);
            }
            finally
            {
            }

            return parameters;
        }
    }
}