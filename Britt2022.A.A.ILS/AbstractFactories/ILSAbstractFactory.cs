namespace Britt2022.A.A.ILS.AbstractFactories
{
    using Britt2022.A.A.ILS.Factories;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.ILS.InterfacesFactories;

    public sealed class ILSAbstractFactory : IILSAbstractFactory
    {
        public ILSAbstractFactory()
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

        public IIteratedLocalSearchBridgeFactory CreateIteratedLocalSearchBridgeFactory()
        {
            IIteratedLocalSearchBridgeFactory factory = null;

            try
            {
                factory = new IteratedLocalSearchBridgeFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIteratedLocalSearchFactory CreateIteratedLocalSearchFactory()
        {
            IIteratedLocalSearchFactory factory = null;

            try
            {
                factory = new IteratedLocalSearchFactory();
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