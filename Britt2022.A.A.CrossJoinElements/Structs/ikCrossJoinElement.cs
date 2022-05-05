namespace Britt2022.A.A.CrossJoinElements.Structs
{
    public readonly struct ikCrossJoinElement
    {
        public const int SizeInBytes = 16;

        public ikCrossJoinElement(
            int iIndexElement,
            int kIndexElement,
            int ikOI,
            int ikZI)
        {
            this.iIndexElement = iIndexElement;

            this.kIndexElement = kIndexElement;

            this.ikOI = ikOI;

            this.ikZI = ikZI;
        }

        public int iIndexElement { get; }

        public int kIndexElement { get; }

        public int ikOI { get; }

        public int ikZI { get; }
    }
}