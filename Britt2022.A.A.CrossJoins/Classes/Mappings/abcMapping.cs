namespace Britt2022.A.A.CrossJoins.Classes.Mappings
{
    using Britt2022.A.A.CrossJoins.Interfaces.Mappings;

    public sealed class abcMapping : IabcMapping
    {
        public abcMapping()
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

        public int caUpperBoundProduct(
            int aUpperBound,
            int c)
        {
            return c * aUpperBound;
        }

        public int caUpperBoundbUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int c)
        {
            return c * aUpperBound * bUpperBound;
        }

        public int cbUpperBoundProduct(
            int bUpperBound,
            int c)
        {
            return c * bUpperBound;
        }

        public int cDifference(
            int c,
            int cLowerBound)
        {
            return c - cLowerBound;
        }

        public int cDifferenceaUpperBoundbUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int c,
            int cLowerBound)
        {
            return
                this.cDifference(
                    c: c,
                    cLowerBound: cLowerBound)
                *
                aUpperBound
                *
                bUpperBound;
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

        public int acOI(
            int a,
            int aUpperBound,
            int c)
        {
            return
                a
                +
                this.caUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    c: c);
        }

        public int abcOI(
            int a,
            int aUpperBound,
            int bUpperBound,
            int b,
            int c)
        {
            return
                a
                +
                this.baUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    b: b)
                +
                this.caUpperBoundbUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    bUpperBound: bUpperBound,
                    c: c);
        }

        public int abcZI(
            int a,
            int aLowerBound,
            int aUpperBound,
            int b,
            int bLowerBound,
            int bUpperBound,
            int c,
            int cLowerBound)
        {
            return
                this.aDifference(
                    a: a,
                    aLowerBound: aLowerBound)
                +
                this.bDifferenceaUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    b: b,
                    bLowerBound: bLowerBound)
                +
                this.cDifferenceaUpperBoundbUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    bUpperBound: bUpperBound,
                    c: c,
                    cLowerBound: cLowerBound);
        }

        public int bcOI(
            int b,
            int bUpperBound,
            int c)
        {
            return
                b
                +
                this.cbUpperBoundProduct(
                    bUpperBound: bUpperBound,
                    c: c);
        }

        public int SpanIndex(
            int a,
            int aUpperBound,
            int b,
            int bLowerBound,
            int bUpperBound,
            int c,
            int cLowerBound)
        {
            return
                a
                +
                this.bDifferenceaUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    b: b,
                    bLowerBound: bLowerBound)
                +
                this.cDifferenceaUpperBoundbUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    bUpperBound: bUpperBound,
                    c: c,
                    cLowerBound: cLowerBound);
        }

        public int SpanLength(
            int aUpperBound,
            int bLowerBound,
            int bUpperBound,
            int cLowerBound,
            int cUpperBound)
        {
            return
                aUpperBound
                +
                this.bDifferenceaUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    b: bUpperBound,
                    bLowerBound: bLowerBound)
                +
                this.cDifferenceaUpperBoundbUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    bUpperBound: bUpperBound,
                    c: cUpperBound,
                    cLowerBound: cLowerBound);
        }
    }
}