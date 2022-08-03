namespace Britt2022.A.A.CrossJoinElements.Structs
{
    public readonly struct ijkωCrossJoinElement
    {
        public const int SizeInBytes = 8 * sizeof(int);

        public ijkωCrossJoinElement(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int ωIndexElement,
            int ijkOI,
            int ijkωOI,
            int ijkωZI,
            int iωOI)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.ijkOI = ijkOI;

            this.ijkωOI = ijkωOI;

            this.ijkωZI = ijkωZI;

            this.iωOI = iωOI;
        }

        public int iIndexElement { get; }

        public int jIndexElement { get; }

        public int kIndexElement { get; }

        public int ωIndexElement { get; }

        public int ijkOI { get; }

        public int ijkωOI { get; }

        public int ijkωZI { get; }

        public int iωOI { get; }
    }
}