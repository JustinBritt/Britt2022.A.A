namespace Britt2022.A.A.VariableElements.Structs
{
    public struct xVariableElement
    {
        public const int SizeInBytes = 16;

        public xVariableElement(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int value)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int jIndexElement { get; }

        public int kIndexElement { get; }

        public int Value { get; set; }
    }
}