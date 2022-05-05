namespace Britt2022.A.A.CrossJoinElements.Structs
{
    public readonly struct jkCrossJoinElement
    {
        public const int SizeInBytes = 16;

        public jkCrossJoinElement(
            int jIndexElement,
            int kIndexElement,
            int jkOI,
            int jkZI)
        {
            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.jkOI = jkOI;

            this.jkZI = jkZI;
        }

        public int jIndexElement { get; }

        public int kIndexElement { get; }

        public int jkOI { get; }

        public int jkZI { get; }
    }
}