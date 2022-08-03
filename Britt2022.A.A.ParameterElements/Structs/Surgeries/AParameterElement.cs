namespace Britt2022.A.A.ParameterElements.Structs.Surgeries
{
    public readonly struct AParameterElement
    {
        public const int SizeInBytes = 2 * sizeof(int) + 1 * sizeof(double);

        public AParameterElement(
            int iIndexElement,
            int ωIndexElement,
            double value)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int ωIndexElement { get; }

        public double Value { get; }
    }
}