namespace Britt2022.A.A.SA.InterfacesAbstractFactories
{
    using Britt2022.A.A.SA.InterfacesFactories;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;

    public interface ISAAbstractFactory : IStandaloneLocalSearchesAbstractFactory
    {
        IImprovementHeuristicFactory CreateImprovementHeuristicFactory();

        IParametersFactory CreateParametersFactory();

        ISimulatedAnnealingBridgeFactory CreateSimulatedAnnealingBridgeFactory();

        ISimulatedAnnealingFactory CreateSimulatedAnnealingFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}