namespace Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories
{
    using Britt2022.A.A.ObjectiveFunctions.InterfacesFactories;

    public interface IObjectiveFunctionsAbstractFactory
    {
        IGoal1Factory CreateGoal1Factory();

        IGoal2Factory CreateGoal2Factory();

        IGoal3Factory CreateGoal3Factory();

        IGoal4Factory CreateGoal4Factory();

        IObjectiveFunctionFactory CreateObjectiveFunctionFactory();
    }
}