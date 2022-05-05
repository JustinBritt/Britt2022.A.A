namespace Britt2022.A.A.GS.Interfaces
{
    using Britt2022.A.A.LocalSearch.Interfaces;

    public interface IParameters : ILocalSearchParameters
    {
        long MaximumNumberTicks { get; }
    }
}