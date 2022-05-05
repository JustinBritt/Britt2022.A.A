namespace Britt2022.A.A.SA.Factories
{
    using Britt2022.A.A.SA.Classes;
    using Britt2022.A.A.SA.Interfaces;
    using Britt2022.A.A.SA.InterfacesFactories;

    internal sealed class ParametersFactory : IParametersFactory
    {
        public ParametersFactory()
        {
        }

        public IParameters Create(
            double coolingRate,
            double finalTemperature,
            double initialTemperature,
            int maximumSolutionsAccepted)
        {
            IParameters parameters = null;

            try
            {
                parameters = new Parameters(
                    coolingRate: coolingRate,
                    finalTemperature: finalTemperature,
                    initialTemperature: initialTemperature,
                    maximumSolutionsAccepted: maximumSolutionsAccepted);
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
                    coolingRate: solverConfiguration.CoolingRate,
                    finalTemperature: solverConfiguration.FinalTemperature,
                    initialTemperature: solverConfiguration.InitialTemperature,
                    maximumSolutionsAccepted: solverConfiguration.MaximumSolutionsAccepted);
            }
            finally
            {
            }

            return parameters;
        }
    }
}