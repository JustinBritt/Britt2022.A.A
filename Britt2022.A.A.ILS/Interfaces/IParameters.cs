namespace Britt2022.A.A.ILS.Interfaces
{
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;

    public interface IParameters : ISingleEmbeddedLocalSearchParameters
    {
        int NumberIterations { get; }

        int NumberPerturbations { get; }
    }
}