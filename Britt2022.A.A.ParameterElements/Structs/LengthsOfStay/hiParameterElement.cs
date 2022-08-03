namespace Britt2022.A.A.ParameterElements.Structs.LengthsOfStay
{
    public readonly struct hiParameterElement
    {
        public const int SizeInBytes = 2 * sizeof(int);

        public hiParameterElement(
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