﻿namespace Britt2022.A.A.StandaloneLocalSearches.Interfaces
{
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.LocalSearches.Interfaces;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;

    public interface IStandaloneLocalSearchBridge : ILocalSearchBridge
    {
        void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IWGPMModel WGPMModel,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration);
    }
}