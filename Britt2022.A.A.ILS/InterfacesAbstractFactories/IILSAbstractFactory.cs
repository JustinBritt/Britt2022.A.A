namespace Britt2022.A.A.ILS.InterfacesAbstractFactories
{
    using Britt2022.A.A.ILS.InterfacesFactories;

    public interface IILSAbstractFactory
    {
        IImprovementHeuristicFactory CreateImprovementHeuristicFactory();

        IIteratedLocalSearchBridgeFactory CreateIteratedLocalSearchBridgeFactory();

        IIteratedLocalSearchFactory CreateIteratedLocalSearchFactory();

        IParametersFactory CreateParametersFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}