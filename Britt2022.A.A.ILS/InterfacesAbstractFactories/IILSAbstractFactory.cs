namespace Britt2022.A.A.ILS.InterfacesAbstractFactories
{
    using Britt2022.A.A.ILS.InterfacesFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;

    public interface IILSAbstractFactory : ISingleEmbeddedLocalSearchAbstractFactory
    {
        IImprovementHeuristicFactory CreateImprovementHeuristicFactory();

        IIteratedLocalSearchBridgeFactory CreateIteratedLocalSearchBridgeFactory();

        IIteratedLocalSearchFactory CreateIteratedLocalSearchFactory();

        IParametersFactory CreateParametersFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}