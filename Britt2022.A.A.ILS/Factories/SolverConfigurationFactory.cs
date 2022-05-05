namespace Britt2022.A.A.ILS.Factories
{
    using Britt2022.A.A.ILS.Classes;
    using Britt2022.A.A.ILS.Interfaces;
    using Britt2022.A.A.ILS.InterfacesFactories;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        public SolverConfigurationFactory()
        {
        }

        public ISolverConfiguration Create(
            int numberIterations,
            int numberPerturbations)
        {
            ISolverConfiguration solverConfiguration = null;

            try
            {
                solverConfiguration = new SolverConfiguration(
                    numberIterations: numberIterations,
                    numberPerturbations: numberPerturbations);
            }
            finally
            {
            }

            return solverConfiguration;
        }
    }
}