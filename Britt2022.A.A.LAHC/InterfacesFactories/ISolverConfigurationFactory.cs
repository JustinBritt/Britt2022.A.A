namespace Britt2022.A.A.LAHC.InterfacesFactories
{
    using Britt2022.A.A.LAHC.Interfaces;

    public interface ISolverConfigurationFactory
    {
        ISolverConfiguration Create(
            int fitnessArrayLength);
    }
}