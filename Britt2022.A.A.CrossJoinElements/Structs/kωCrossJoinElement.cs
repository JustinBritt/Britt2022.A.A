namespace Britt2022.A.A.CrossJoinElements.Structs
{
    public readonly struct kωCrossJoinElement
    {
        public const int SizeInBytes = 16;

        public kωCrossJoinElement(
            int kIndexElement,
            int ωIndexElement,
            int kωOI,
            int kωZI)
        {
            this.kIndexElement = kIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.kωOI = kωOI;

            this.kωZI = kωZI;
        }

        public int kIndexElement { get; }

        public int ωIndexElement { get; }

        public int kωOI { get; }

        public int kωZI { get; }
    }
}