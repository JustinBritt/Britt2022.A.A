namespace Britt2022.A.A.VariableElements.Structs
{
    public struct IVariableElement
    {
        public const int SizeInBytes = 2 * sizeof(int) + 1 * sizeof(double);

        public IVariableElement(
            int kIndexElement,
            int ωIndexElement,
            double value)
        {
            this.kIndexElement = kIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public int kIndexElement { get; }

        public int ωIndexElement { get; }

        public double Value { get; set; }
    }
}