namespace Britt2022.A.A.ILS.InterfacesFactories
{
    using Britt2022.A.A.ILS.Interfaces;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            int numberIterations,
            int numberPerturbations);
    }
}