namespace Britt2022.A.A.IndexElements.Structs
{
    public readonly struct rIndexElement
    {
        public const int SizeInBytes = 1 * sizeof(int);

        public rIndexElement(
            int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the surgical specialty.
        /// </summary>
        public int Value { get; }
    }
}