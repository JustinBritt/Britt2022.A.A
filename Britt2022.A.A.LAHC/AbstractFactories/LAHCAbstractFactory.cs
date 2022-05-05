namespace Britt2022.A.A.LAHC.AbstractFactories
{
    using Britt2022.A.A.LAHC.Factories;
    using Britt2022.A.A.LAHC.InterfacesAbstractFactories;
    using Britt2022.A.A.LAHC.InterfacesFactories;

    public sealed class LAHCAbstractFactory : ILAHCAbstractFactory
    {
        public LAHCAbstractFactory()
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

        public ILateAcceptanceHillClimbingBridgeFactory CreateLateAcceptanceHillClimbingBridgeFactory()
        {
            ILateAcceptanceHillClimbingBridgeFactory factory = null;

            try
            {
                factory = new LateAcceptanceHillClimbingBridgeFactory();
            }
            finally
            {
            }

            return factory;
        }

        public ILateAcceptanceHillClimbingFactory CreateLateAcceptanceHillClimbingFactory()
        {
            ILateAcceptanceHillClimbingFactory factory = null;

            try
            {
                factory = new LateAcceptanceHillClimbingFactory();
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