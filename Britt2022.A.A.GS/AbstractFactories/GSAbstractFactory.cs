namespace Britt2022.A.A.GS.AbstractFactories
{
    using Britt2022.A.A.GS.Factories;
    using Britt2022.A.A.GS.InterfacesAbstractFactories;
    using Britt2022.A.A.GS.InterfacesFactories;

    public sealed class GSAbstractFactory : IGSAbstractFactory
    {
        public GSAbstractFactory()
        {
        }
  
        public IGreedySearchBridgeFactory CreateGreedySearchBridgeFactory()
        {
            IGreedySearchBridgeFactory factory = null;

            try
            {
                factory = new GreedySearchBridgeFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IGreedySearchFactory CreateGreedySearchFactory()
        {
            IGreedySearchFactory factory = null;

            try
            {
                factory = new GreedySearchFactory();
            }
            finally
            {
            }

            return factory;
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
    }
}