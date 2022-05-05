namespace Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons
{
    public readonly struct ΩParameterElement
    {
        public const int SizeInBytes = 12;

        public ΩParameterElement(
            int iIndexElement,
            int kIndexElement,
            int value)
        {
            this.iIndexElement = iIndexElement;

            this.kIndexElement = kIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int kIndexElement { get; }

        public int Value { get; }
    }
}