namespace Britt2022.A.A.ParameterElements.Structs.Surgeries
{
    public readonly struct niωParameterElement
    {
        public const int SizeInBytes = 3 * sizeof(int);

        public niωParameterElement(
            int iIndexElement,
            int ωIndexElement,
            int value)
        {
            this.iIndexElement = iIndexElement;

            this.ωIndexElement = ωIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int ωIndexElement { get; }

        public int Value { get; }
    }
}