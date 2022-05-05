namespace Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties
{
    public readonly struct F2ParameterElement
    {
        public const int SizeInBytes = 4;

        public F2ParameterElement(
            int value)
        {
            this.Value = value;
        }

        public int Value { get; }
    }
}