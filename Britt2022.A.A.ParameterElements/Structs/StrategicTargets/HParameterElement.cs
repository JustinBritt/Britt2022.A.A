namespace Britt2022.A.A.ParameterElements.Structs.StrategicTargets
{
    public readonly struct HParameterElement
    {
        public const int SizeInBytes = 2 * sizeof(int);

        public HParameterElement(
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