namespace Britt2022.A.A.ObjectiveFunctions.InterfacesFactories
{
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;

    public interface IObjectiveFunctionFactory
    {
        IObjectiveFunction Create();
    }
}