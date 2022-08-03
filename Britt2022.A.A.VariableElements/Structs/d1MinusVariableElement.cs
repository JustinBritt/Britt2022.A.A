namespace Britt2022.A.A.VariableElements.Structs
{
    public struct d1MinusVariableElement
    {
        public const int SizeInBytes = 3 * sizeof(int);

        public d1MinusVariableElement(
            int iIndexElement,
            int ωIndexElement,
            int value)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int ωIndexElement { get; }

        public int Value { get; set; }
    }
}