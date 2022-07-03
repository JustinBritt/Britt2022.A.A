namespace Britt2022.A.A.CrossJoins.Interfaces.Mappings
{
    public interface IabcMapping
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

        int caUpperBoundProduct(
            int aUpperBound,
            int c);

        int caUpperBoundbUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int c);

        int cbUpperBoundProduct(
            int bUpperBound,
            int c);

        int cDifference(
            int c,
            int cLowerBound);

        int cDifferenceaUpperBoundbUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int c,
            int cLowerBound);

        int abOI(
            int a,
            int aUpperBound,
            int b);

        int acOI(
            int a,
            int aUpperBound,
            int c);

        int abcOI(
            int a,
            int aUpperBound,
            int bUpperBound,
            int b,
            int c);

        int abcZI(
            int a,
            int aLowerBound,
            int aUpperBound,
            int b,
            int bLowerBound,
            int bUpperBound,
            int c,
            int cLowerBound);

        int bcOI(
            int b,
            int bUpperBound,
            int c);

        int SpanIndex(
            int a,
            int aUpperBound,
            int b,
            int bLowerBound,
            int bUpperBound,
            int c,
            int cLowerBound);

        int SpanLength(
            int aUpperBound,
            int bLowerBound,
            int bUpperBound,
            int cLowerBound,
            int cUpperBound);
    }
}