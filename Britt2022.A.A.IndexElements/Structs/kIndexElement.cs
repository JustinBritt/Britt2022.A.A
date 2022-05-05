namespace Britt2022.A.A.IndexElements.Structs
{
    public readonly struct kIndexElement
    {
        public const int SizeInBytes = 4;

        public kIndexElement(
            int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        public int Value { get; }
    }
}