namespace Britt2022.A.A.ParameterElements.Structs.StrategicTargets
{
    public readonly struct LParameterElement
    {
        public const int SizeInBytes = 8;

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