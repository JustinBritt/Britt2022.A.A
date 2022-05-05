namespace Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons
{
    public readonly struct ΠParameterElement
    {
        public const int SizeInBytes = 12;

        public ΠParameterElement(
            int iIndexElement,
            int jIndexElement,
            int value)
        {
            this.iIndexElement = iIndexElement;

            this.jIndexElement = jIndexElement;

            this.Value = value;
        }

        public int iIndexElement { get; }

        public int jIndexElement { get; }

        public int Value { get; }
    }
}