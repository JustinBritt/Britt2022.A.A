namespace Britt2022.A.A.IndexElements.Structs
{
    public readonly struct lIndexElement
    {
        public const int SizeInBytes = 4;

        public lIndexElement(
            int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the day.
        /// </summary>
        public int Value { get; }
    }
}