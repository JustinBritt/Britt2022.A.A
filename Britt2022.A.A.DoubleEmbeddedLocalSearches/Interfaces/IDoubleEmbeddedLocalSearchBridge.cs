namespace Britt2022.A.A.DoubleEmbeddedLocalSearches.Interfaces
{
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.DoubleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.LocalSearches.Interfaces;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;

    public interface IDoubleEmbeddedLocalSearchBridge : ILocalSearchBridge
    {
        void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IDoubleEmbeddedLocalSearchAbstractFactory doubleEmbeddedLocalSearchAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchesAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IWGPMModel WGPMModel,
            IDoubleEmbeddedLocalSearchSolverConfiguration doubleEmbeddedLocalSearchSolverConfiguration,
            ISingleEmbeddedLocalSearchSolverConfiguration singleEmbeddedLocalSearchSolverConfiguration,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration);
    }
}