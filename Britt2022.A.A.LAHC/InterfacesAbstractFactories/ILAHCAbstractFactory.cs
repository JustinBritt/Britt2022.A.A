namespace Britt2022.A.A.LAHC.InterfacesAbstractFactories
{
    using Britt2022.A.A.LAHC.InterfacesFactories;
    using Britt2022.A.A.LocalSearch.InterfacesAbstractFactories;

    public interface ILAHCAbstractFactory : ILocalSearchAbstractFactory
    {
        IImprovementHeuristicFactory CreateImprovementHeuristicFactory();

        ILateAcceptanceHillClimbingBridgeFactory CreateLateAcceptanceHillClimbingBridgeFactory();

        ILateAcceptanceHillClimbingFactory CreateLateAcceptanceHillClimbingFactory();

        IParametersFactory CreateParametersFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}