namespace Britt2022.A.A.LAHC.Interfaces
{
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;

    public interface ISolverConfiguration : IStandaloneLocalSearchSolverConfiguration
    {
        int FitnessArrayLength { get; }
    }
}