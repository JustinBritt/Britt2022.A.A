namespace Britt2022.A.A.CrossJoinElements.Structs
{
    public readonly struct iωCrossJoinElement
    {
        public const int SizeInBytes = 4 * sizeof(int);

        public iωCrossJoinElement(
            int iIndexElement,
            int ωIndexElement,
            int iωOI,
            int iωZI)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.iωOI = iωOI;

            this.iωZI = iωZI;
        }

        public int iIndexElement { get; }

        public int ωIndexElement { get; }

        public int iωOI { get; }

        public int iωZI { get; }
    }
}