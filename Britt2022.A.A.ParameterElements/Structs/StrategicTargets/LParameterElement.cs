namespace Britt2022.A.A.ParameterElements.Structs.StrategicTargets
{
    public readonly struct LParameterElement
    {
        public const int SizeInBytes = 2 * sizeof(int);

        public LParameterElement(
            int iIndexElement,
            int value)
        {
            this.iIndexElement = iIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int Value { get; }
    }
}