namespace Britt2022.A.A.IndexElements.Structs
{
    public readonly struct ωIndexElement
    {
        public const int SizeInBytes = 1 * sizeof(int);

        public ωIndexElement(
            int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the scenario.
        /// </summary>
        public int Value { get; }
    }
}