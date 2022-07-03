namespace Britt2022.A.A.CrossJoins.Interfaces.Mappings
{
    public interface IabcdMapping
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

        int caUpperBoundbUpperBoundProduct(
            int aUpperBound,
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

        int daUpperBoundProduct(
            int aUpperBound,
            int d);

        int daUpperBoundbUpperBoundcUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int cUpperBound,
            int d);

        int dDifference(
            int d,
            int dLowerBound);

        int dDifferenceaUpperBoundbUpperBoundcUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int cUpperBound,
            int d,
            int dLowerBound);

        int abcOI(
            int a,
            int aUpperBound,
            int bUpperBound,
            int b,
            int c);

        int abcdOI(
            int a,
            int aUpperBound,
            int b,
            int bUpperBound,
            int c,
            int cUpperBound,
            int d);

        int abcdZI(
            int a,
            int aLowerBound,
            int aUpperBound,
            int b,
            int bLowerBound,
            int bUpperBound,
            int c,
            int cLowerBound,
            int cUpperBound,
            int d,
            int dLowerBound);

        int adOI(
            int a,
            int aUpperBound,
            int d);

        int SpanIndex(
            int a,
            int aUpperBound,
            int b,
            int bLowerBound,
            int bUpperBound,
            int c,
            int cLowerBound,
            int cUpperBound,
            int d,
            int dLowerBound);

        int SpanLength(
            int aUpperBound,
            int bLowerBound,
            int bUpperBound,
            int cLowerBound,
            int cUpperBound,
            int dLowerBound,
            int dUpperBound);
    }
}