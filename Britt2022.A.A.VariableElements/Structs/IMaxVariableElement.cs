namespace Britt2022.A.A.VariableElements.Structs
{
    public struct IMaxVariableElement
    {
        public const int SizeInBytes = 32;

        public IMaxVariableElement(
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