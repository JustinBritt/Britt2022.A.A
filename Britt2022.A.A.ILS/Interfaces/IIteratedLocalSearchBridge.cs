namespace Britt2022.A.A.ILS.Interfaces
{
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.LocalSearch.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;

    public interface IIteratedLocalSearchBridge
    {
        void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IILSAbstractFactory ILSAbstractFactory,
            ILocalSearchAbstractFactory localSearchAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IWGPMModel WGPMModel,
            ISolverConfiguration ILSSolverConfiguration,
            Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration localSearchSolverConfiguration);
    }
}