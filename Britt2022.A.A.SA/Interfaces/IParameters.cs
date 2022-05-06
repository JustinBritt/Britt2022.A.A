namespace Britt2022.A.A.SA.Interfaces
{
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;

    public interface IParameters : ILocalSearchParameters
    {
        double CoolingRate { get; }

        double FinalTemperature { get; }

        double InitialTemperature { get; }

        int MaximumSolutionsAccepted { get; }
    }
}