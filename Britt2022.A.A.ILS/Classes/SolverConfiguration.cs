namespace Britt2022.A.A.ILS.Classes
{
    using Britt2022.A.A.ILS.Interfaces;

    internal sealed class SolverConfiguration : ISolverConfiguration
    {
        public SolverConfiguration(
            int numberIterations,
            int numberPerturbations)
        {
            this.NumberIterations = numberIterations;

            this.NumberPerturbations = numberPerturbations;
        }

        public int NumberIterations { get; }

        public int NumberPerturbations { get; }
    }
}