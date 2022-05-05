namespace Britt2022.A.A.CrossJoins.Classes.Mappings
{
    using Britt2022.A.A.CrossJoins.Interfaces.Mappings;

    public sealed class abcdMapping : IabcdMapping
    {
        public abcdMapping()
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

        public int caUpperBoundbUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int c)
        {
            return c * aUpperBound * bUpperBound;
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

        public int daUpperBoundProduct(
            int aUpperBound,
            int d)
        {
            return d * aUpperBound;
        }

        public int daUpperBoundbUpperBoundcUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int cUpperBound,
            int d)
        {
            return d * aUpperBound * bUpperBound * cUpperBound;
        }

        public int dDifference(
            int d,
            int dLowerBound)
        {
            return d - dLowerBound;
        }

        public int dDifferenceaUpperBoundbUpperBoundcUpperBoundProduct(
            int aUpperBound,
            int bUpperBound,
            int cUpperBound,
            int d,
            int dLowerBound)
        {
            return
                this.dDifference(
                    d: d,
                    dLowerBound: dLowerBound)
                *
                aUpperBound
                *
                bUpperBound
                *
                cUpperBound;
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

        public int abcdOI(
            int a,
            int aUpperBound,
            int b,
            int bUpperBound,
            int c,
            int cUpperBound,
            int d)
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
                    c: c)
                +
                this.daUpperBoundbUpperBoundcUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    bUpperBound: bUpperBound,
                    cUpperBound: cUpperBound,
                    d: d);
        }

        public int abcdZI(
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
            int dLowerBound)
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
                    cLowerBound: cLowerBound)
                +
                this.dDifferenceaUpperBoundbUpperBoundcUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    bUpperBound: bUpperBound,
                    cUpperBound: cUpperBound,
                    d: d,
                    dLowerBound: dLowerBound);
        }

        public int adOI(
            int a,
            int aUpperBound,
            int d)
        {
            return
                a
                +
                this.daUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    d: d);
        }

        public int SpanIndex(
            int a,
            int aUpperBound,
            int b,
            int bLowerBound,
            int bUpperBound,
            int c,
            int cLowerBound,
            int cUpperBound,
            int d,
            int dLowerBound)
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
                    cLowerBound: cLowerBound)
                +
                this.dDifferenceaUpperBoundbUpperBoundcUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    bUpperBound: bUpperBound,
                    cUpperBound: cUpperBound,
                    d: d,
                    dLowerBound: dLowerBound);
        }

        public int SpanLength(
            int aUpperBound,
            int bLowerBound,
            int bUpperBound,
            int cLowerBound,
            int cUpperBound,
            int dLowerBound,
            int dUpperBound)
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
                    cLowerBound: cLowerBound)
                +
                this.dDifferenceaUpperBoundbUpperBoundcUpperBoundProduct(
                    aUpperBound: aUpperBound,
                    bUpperBound: bUpperBound,
                    cUpperBound: cUpperBound,
                    d: dUpperBound,
                    dLowerBound: dLowerBound);
        }
    }
}