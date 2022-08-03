namespace Britt2022.A.A.VariableElements.Structs
{
    public struct IMinVariableElement
    {
        public const int SizeInBytes = 1 * sizeof(int) + 1 * sizeof(double);

        public IMinVariableElement(
            int ωIndexElement,
            double value)
        {
            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public int ωIndexElement { get; }

        public double Value { get; set; }
    }
}