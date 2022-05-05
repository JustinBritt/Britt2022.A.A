namespace Britt2022.A.A.GS.Factories
{
    using Britt2022.A.A.GS.Classes;
    using Britt2022.A.A.GS.Interfaces;
    using Britt2022.A.A.GS.InterfacesFactories;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        public SolverConfigurationFactory()
        {
        }

        public ISolverConfiguration Create(
            long maximumNumberTicks)
        {
            ISolverConfiguration solverConfiguration = null;

            try
            {
                solverConfiguration = new SolverConfiguration(
                    maximumNumberTicks);
            }
            finally
            {
            }

            return solverConfiguration;
        }
    }
}