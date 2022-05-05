namespace Britt2022.A.A.LAHC.Factories
{
    using Britt2022.A.A.LAHC.Classes;
    using Britt2022.A.A.LAHC.Interfaces;
    using Britt2022.A.A.LAHC.InterfacesFactories;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        public SolverConfigurationFactory()
        {
        }

        public ISolverConfiguration Create(
            int fitnessArrayLength)
        {
            ISolverConfiguration solverConfiguration = null;

            try
            {
                solverConfiguration = new SolverConfiguration(
                    fitnessArrayLength);
            }
            finally
            {
            }

            return solverConfiguration;
        }
    }
}