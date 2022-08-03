namespace Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities
{
    public readonly struct ΡParameterElement
    {
        public const int SizeInBytes = 1 * sizeof(int) + 1 * sizeof(double);

        public ΡParameterElement(
            int ωIndexElement,
            double value)
        {
            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public int ωIndexElement { get; }

        public double Value { get; }
    }
}