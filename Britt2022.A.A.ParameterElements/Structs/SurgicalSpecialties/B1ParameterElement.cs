namespace Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties
{
    public readonly struct B1ParameterElement
    {
        public const int SizeInBytes = 1 * sizeof(int);

        public B1ParameterElement(
            int value)
        {
            this.Value = value;
        }

        public int Value { get; }
    }
}