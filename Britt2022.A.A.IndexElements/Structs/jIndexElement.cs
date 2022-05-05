namespace Britt2022.A.A.IndexElements.Structs
{
    public readonly struct jIndexElement
    {
        public const int SizeInBytes = 4;

        public jIndexElement(
            int value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the operating room.
        /// </summary>
        public int Value { get; }
    }
}