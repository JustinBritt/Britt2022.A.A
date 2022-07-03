namespace Britt2022.A.A.CrossJoins.Interfaces.Mappings
{
    public interface IabMapping
    {
        int aDifference(
            int a,
            int aLowerBound);

        int baUpperBoundProduct(
            int aUpperBound,
            int b);

        int bDifference(
            int b,
            int bLowerBound);

        int bDifferenceaUpperBoundProduct(
            int aUpperBound,
            int b,
            int bLowerBound);

        int abOI(
            int a,
            int aUpperBound,
            int b);

        int abZI(
            int a,
            int aLowerBound,
            int aUpperBound,
            int b,
            int bLowerBound);

        int SpanIndex(
            int a,
            int aUpperBound,
            int b,
            int bLowerBound);

        int SpanLength(
            int aUpperBound,
            int bLowerBound,
            int bUpperBound);
    }
}