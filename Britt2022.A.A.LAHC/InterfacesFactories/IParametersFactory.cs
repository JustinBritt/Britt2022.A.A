namespace Britt2022.A.A.LAHC.InterfacesFactories
{
    using Britt2022.A.A.LAHC.Interfaces;

    public interface IParametersFactory
    {
        IParameters Create(
            int fitnessArrayLength);

        IParameters Create(
            ISolverConfiguration solverConfiguration);
    }
}