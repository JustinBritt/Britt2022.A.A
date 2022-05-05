namespace Britt2022.A.A.CrossJoinElements.Structs
{
    public readonly struct ilωCrossJoinElement
    {
        public const int SizeInBytes = 32;

        public ilωCrossJoinElement(
            int iIndexElement,
            int lIndexElement,
            int ωIndexElement,
            int ilωOI,
            int ilωZI)
        {
            this.iIndexElement = iIndexElement;

            this.lIndexElement = lIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.ilωOI = ilωOI;

            this.ilωZI = ilωZI;
        }

        public int iIndexElement { get; }

        public int lIndexElement { get; }

        public int ωIndexElement { get; }

        public int ilωOI { get; }

        public int ilωZI { get; }
    }
}