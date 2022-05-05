namespace Britt2022.A.A.GS.InterfacesFactories
{
    using Britt2022.A.A.GS.Interfaces;

    public interface IParametersFactory
    {
        IParameters Create(
            long maximumNumberTicks);

        IParameters Create(
            ISolverConfiguration solverConfiguration);
    }
}