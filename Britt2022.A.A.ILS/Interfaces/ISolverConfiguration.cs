namespace Britt2022.A.A.ILS.Interfaces
{
    public interface ISolverConfiguration : Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration
    {
        int NumberIterations { get; }

        int NumberPerturbations { get; }
    }
}