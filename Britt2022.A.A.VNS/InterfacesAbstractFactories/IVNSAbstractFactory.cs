namespace Britt2022.A.A.VNS.InterfacesAbstractFactories
{
    using Britt2022.A.A.VNS.InterfacesFactories;

    public interface IVNSAbstractFactory
    {
        IImprovementHeuristicFactory CreateImprovementHeuristicFactory();

        IParametersFactory CreateParametersFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();

        IVariableNeighbourhoodSearchBridgeFactory CreateVariableNeighbourhoodSearchBridgeFactory();

        IVariableNeighbourhoodSearchFactory CreateVariableNeighbourhoodSearchFactory();
    }
}