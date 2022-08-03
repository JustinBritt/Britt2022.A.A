namespace Britt2022.A.A.CrossJoinElements.Structs
{
    public readonly struct ijCrossJoinElement
    {
        public const int SizeInBytes = 4 * sizeof(int);

        public ijCrossJoinElement(
            int iIndexElement,
            int jIndexElement,
            int ijOI,
            int ijZI)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.ijOI = ijOI;

            this.ijZI = ijZI;
        }

        public int iIndexElement { get; }

        public int jIndexElement { get; }

        public int ijOI { get; }

        public int ijZI { get; }
    }
}