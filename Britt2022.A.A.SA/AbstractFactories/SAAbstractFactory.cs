namespace Britt2022.A.A.SA.AbstractFactories
{
    using Britt2022.A.A.SA.Factories;
    using Britt2022.A.A.SA.InterfacesAbstractFactories;
    using Britt2022.A.A.SA.InterfacesFactories;

    public sealed class SAAbstractFactory : ISAAbstractFactory
    {
        public SAAbstractFactory()
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

        public ISimulatedAnnealingBridgeFactory CreateSimulatedAnnealingBridgeFactory()
        {
            ISimulatedAnnealingBridgeFactory factory = null;

            try
            {
                factory = new SimulatedAnnealingBridgeFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ISimulatedAnnealingFactory CreateSimulatedAnnealingFactory()
        {
            ISimulatedAnnealingFactory factory = null;

            try
            {
                factory = new SimulatedAnnealingFactory();
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
    }
}