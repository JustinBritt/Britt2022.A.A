namespace Britt2022.A.A.LAHC.Classes
{
    using Britt2022.A.A.LAHC.Interfaces;

    internal sealed class SolverConfiguration : ISolverConfiguration
    {
        public SolverConfiguration(
            int fitnessArrayLength)
        {
            this.FitnessArrayLength = fitnessArrayLength;
        }

        public int FitnessArrayLength { get; }
    }
}