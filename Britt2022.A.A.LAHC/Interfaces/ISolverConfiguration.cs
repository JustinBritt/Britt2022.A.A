namespace Britt2022.A.A.LAHC.Interfaces
{

    public interface ISolverConfiguration : Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration
    {
        int FitnessArrayLength { get; }
    }
}