namespace Britt2022.A.A.SA.InterfacesAbstractFactories
{
    using Britt2022.A.A.LocalSearch.InterfacesAbstractFactories;
    using Britt2022.A.A.SA.InterfacesFactories;

    public interface ISAAbstractFactory : ILocalSearchAbstractFactory
    {
        IImprovementHeuristicFactory CreateImprovementHeuristicFactory();

        IParametersFactory CreateParametersFactory();

        ISimulatedAnnealingBridgeFactory CreateSimulatedAnnealingBridgeFactory();

        ISimulatedAnnealingFactory CreateSimulatedAnnealingFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}