namespace Britt2022.A.A.VNS.AbstractFactories
{
    using Britt2022.A.A.VNS.Factories;
    using Britt2022.A.A.VNS.InterfacesAbstractFactories;
    using Britt2022.A.A.VNS.InterfacesFactories;

    public sealed class VNSAbstractFactory : IVNSAbstractFactory
    {
        public VNSAbstractFactory()
        {
        }

        public IImprovementHeuristicFactory CreateImprovementHeuristicFactory()
        {
            IImprovementHeuristicFactory factory = null;

            try
            {
                factory = new ImprovementHeuristicFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IParametersFactory CreateParametersFactory()
        {
            IParametersFactory factory = null;

            try
            {
                factory = new ParametersFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISolverConfigurationFactory CreateSolverConfigurationFactory()
        {
            ISolverConfigurationFactory factory = null;

            try
            {
                factory = new SolverConfigurationFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IVariableNeighbourhoodSearchBridgeFactory CreateVariableNeighbourhoodSearchBridgeFactory()
        {
            IVariableNeighbourhoodSearchBridgeFactory factory = null;

            try
            {
                factory = new VariableNeighbourhoodSearchBridgeFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IVariableNeighbourhoodSearchFactory CreateVariableNeighbourhoodSearchFactory()
        {
            IVariableNeighbourhoodSearchFactory factory = null;

            try
            {
                factory = new VariableNeighbourhoodSearchFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}