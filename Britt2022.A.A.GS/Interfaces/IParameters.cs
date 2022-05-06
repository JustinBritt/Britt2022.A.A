namespace Britt2022.A.A.GS.Interfaces
{
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;

    public interface IParameters : IStandaloneLocalSearchParameters
    {
        long MaximumNumberTicks { get; }
    }
}