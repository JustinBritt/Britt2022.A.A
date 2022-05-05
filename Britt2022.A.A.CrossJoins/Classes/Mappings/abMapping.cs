namespace Britt2022.A.A.CrossJoins.Classes.Mappings
{
    using Britt2022.A.A.CrossJoins.Interfaces.Mappings;

    public sealed class abMapping : IabMapping
    {
        public abMapping()
        {
        }

        public int aDifference(
            int a,
            int aLowerBound)
        {
            return a - aLowerBound;
        }

        public int baUpperBoundProduct(
            int aUpperBound,
            int b)
        {
            return b * aUpperBound;
        }

        public int bDifference(
            int b,
            int bLowerBound)
        {
            return b - bLowerBound;
        }

        public int bDifferenceaUpperBoundProduct(
            int aUpperBound,
            int b,
            int bLowerBound)
        {
            return
                this.bDifference(
                    b: b,
                    bLowerBound: bLowerBound)
                *
                aUpperBound;
        }

        public int abOI(
            int a,
            int aUpperBound,
            int b)
        {
            return
                a
                +
                this.baUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    b: b);
        }

        public int abZI(
            int a,
            int aLowerBound,
            int aUpperBound,
            int b,
            int bLowerBound)
        {
            return
                this.aDifference(
                    a: a,
                    aLowerBound: aLowerBound)
                +
                this.bDifferenceaUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    b: b,
                    bLowerBound: bLowerBound);
        }

        public int SpanIndex(
            int a,
            int aUpperBound,
            int b,
            int bLowerBound)
        {
            return
                a
                +
                this.bDifferenceaUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    b: b,
                    bLowerBound: bLowerBound);
        }

        public int SpanLength(
            int aUpperBound,
            int bLowerBound,
            int bUpperBound)
        {
            return
                aUpperBound
                +
                this.bDifferenceaUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    b: bUpperBound,
                    bLowerBound: bLowerBound);
        }
    }
}