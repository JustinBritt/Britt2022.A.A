namespace Britt2022.A.A.ILS.InterfacesFactories
{
    using Britt2022.A.A.ILS.Interfaces;

    public interface IParametersFactory
    {
        IParameters Create(
            int numberIterations,
            int numberPerturbations);

        IParameters Create(
            ISolverConfiguration solverConfiguration);
    }
}