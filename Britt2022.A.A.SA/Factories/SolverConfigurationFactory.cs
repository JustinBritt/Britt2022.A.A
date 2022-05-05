namespace Britt2022.A.A.SA.Factories
{
    using Britt2022.A.A.SA.Classes;
    using Britt2022.A.A.SA.Interfaces;
    using Britt2022.A.A.SA.InterfacesFactories;

    internal sealed class SolverConfigurationFactory : ISolverConfigurationFactory
    {
        public SolverConfigurationFactory()
        {
        }

        public ISolverConfiguration Create(
            double coolingRate,
            double finalTemperature,
            double initialTemperature,
            int maximumSolutionsAccepted)
        {
            ISolverConfiguration solverConfiguration = null;

            try
            {
                solverConfiguration = new SolverConfiguration(
                    coolingRate: coolingRate,
                    finalTemperature: finalTemperature,
                    initialTemperature: initialTemperature,
                    maximumSolutionsAccepted: maximumSolutionsAccepted);
            }
            finally
            {
            }

            return solverConfiguration;
        }
    }
}