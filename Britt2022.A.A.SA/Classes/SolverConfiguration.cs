namespace Britt2022.A.A.SA.Classes
{
    using Britt2022.A.A.SA.Interfaces;

    internal sealed class SolverConfiguration : ISolverConfiguration
    {
        public SolverConfiguration(
            double coolingRate,
            double finalTemperature,
            double initialTemperature,
            int maximumSolutionsAccepted)
        {
            this.CoolingRate = coolingRate;

            this.FinalTemperature = finalTemperature;

            this.InitialTemperature = initialTemperature;

            this.MaximumSolutionsAccepted = maximumSolutionsAccepted;
        }

        public double CoolingRate { get; }

        public double FinalTemperature { get; }

        public double InitialTemperature { get; }

        public int MaximumSolutionsAccepted { get; }
    }
}