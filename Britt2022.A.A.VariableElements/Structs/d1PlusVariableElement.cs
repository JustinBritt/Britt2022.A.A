namespace Britt2022.A.A.VariableElements.Structs
{
    public struct d1PlusVariableElement
    {
        public const int SizeInBytes = 3 * sizeof(int);

        public d1PlusVariableElement(
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

        public int Value { get; set; }
    }
}