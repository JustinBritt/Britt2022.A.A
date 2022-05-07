namespace Britt2022.A.A.ILS.Interfaces
{
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;

    public interface ISolverConfiguration : ISingleEmbeddedLocalSearchSolverConfiguration
    {
        int NumberIterations { get; }

        int NumberPerturbations { get; }
    }
}