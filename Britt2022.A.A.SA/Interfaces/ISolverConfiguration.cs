namespace Britt2022.A.A.SA.Interfaces
{
    public interface ISolverConfiguration : Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration
    {
        double CoolingRate { get; }

        double FinalTemperature { get; }

        double InitialTemperature { get; }

        int MaximumSolutionsAccepted { get; }
    }
}