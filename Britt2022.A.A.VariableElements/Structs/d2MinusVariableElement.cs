namespace Britt2022.A.A.VariableElements.Structs
{
    public struct d2MinusVariableElement
    {
        public const int SizeInBytes = 32;

        public d2MinusVariableElement(
            int iIndexElement,
            int jIndexElement,
            int kIndexElement,
            int ωIndexElement,
            double value)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.kIndexElement = kIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int jIndexElement { get; }

        public int kIndexElement { get; }

        public int ωIndexElement { get; }

        public double Value { get; set; }
    }
}