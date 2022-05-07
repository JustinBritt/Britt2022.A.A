namespace Britt2022.A.A.GS.Interfaces
{
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;

    public interface ISolverConfiguration : IStandaloneLocalSearchSolverConfiguration
    {
        long MaximumNumberTicks { get; }
    }
}