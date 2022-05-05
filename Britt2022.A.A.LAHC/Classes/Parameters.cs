namespace Britt2022.A.A.LAHC.Classes
{
    using Britt2022.A.A.LAHC.Interfaces;

    internal sealed class Parameters : IParameters
    {
        public Parameters(
            int fitnessArrayLength)
        {
            this.FitnessArrayLength = fitnessArrayLength;
        }

        public int FitnessArrayLength { get; }
    }
}