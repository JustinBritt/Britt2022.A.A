namespace Britt2022.A.A.GS.InterfacesAbstractFactories
{
    using Britt2022.A.A.GS.InterfacesFactories;
    using Britt2022.A.A.LocalSearch.InterfacesAbstractFactories;

    public interface IGSAbstractFactory : ILocalSearchAbstractFactory
    {
        IGreedySearchBridgeFactory CreateGreedySearchBridgeFactory();

        IGreedySearchFactory CreateGreedySearchFactory();

        IImprovementHeuristicFactory CreateImprovementHeuristicFactory();

        IParametersFactory CreateParametersFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}