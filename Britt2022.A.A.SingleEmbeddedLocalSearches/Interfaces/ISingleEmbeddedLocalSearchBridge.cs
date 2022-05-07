namespace Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces
{
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;

    public interface ISingleEmbeddedLocalSearchBridge
    {
        void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchesAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IWGPMModel WGPMModel,
            ISingleEmbeddedLocalSearchSolverConfiguration singleEmbeddedLocalSearchSolverConfiguration,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration);
    }
}