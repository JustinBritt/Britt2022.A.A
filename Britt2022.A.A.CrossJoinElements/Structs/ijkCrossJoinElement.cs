namespace Britt2022.A.A.CrossJoinElements.Structs
{
    public readonly struct ijkCrossJoinElement
    {
        public const int SizeInBytes = 8 * sizeof(int);

        public ijkCrossJoinElement(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int ijOI,
            int ijkOI,
            int ijkZI,
            int ikOI,
            int jkOI)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.ijOI = ijOI;

            this.ijkOI = ijkOI;

            this.ijkZI = ijkZI;

            this.ikOI = ikOI;

            this.jkOI = jkOI;
        }

        public int iIndexElement { get; }

        public int jIndexElement { get; }

        public int kIndexElement { get; }

        public int ijOI { get; }

        public int ijkOI { get; }

        public int ijkZI { get; }

        public int ikOI { get; }

        public int jkOI { get; }
    }
}