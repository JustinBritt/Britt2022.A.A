namespace Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces
{
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.LocalSearches.Interfaces;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.VariableElements.InterfacesAbstractFactories;

    public interface ISingleEmbeddedLocalSearchBridge : ILocalSearchBridge
    {
        void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchesAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IVariableElementsAbstractFactory variableElementsAbstractFactory,
            IWGPMModel WGPMModel,
            ISingleEmbeddedLocalSearchSolverConfiguration singleEmbeddedLocalSearchSolverConfiguration,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration);
    }
}