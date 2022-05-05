namespace Britt2022.A.A.SA.InterfacesFactories
{
    using Britt2022.A.A.SA.Interfaces;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            double coolingRate,
            double finalTemperature,
            double initialTemperature,
            int maximumSolutionsAccepted);
    }
}