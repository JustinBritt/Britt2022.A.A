namespace Britt2022.A.A.IndexElements.Structs
{
    public readonly struct eIndexElement
    {
        public const int SizeInBytes = 1 * sizeof(int);

        public eIndexElement(
            int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the cluster.
        /// </summary>
        public int Value { get; }
    }
}