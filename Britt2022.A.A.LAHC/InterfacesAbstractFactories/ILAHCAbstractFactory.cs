namespace Britt2022.A.A.LAHC.InterfacesAbstractFactories
{
    using Britt2022.A.A.LAHC.InterfacesFactories;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;

    public interface ILAHCAbstractFactory : IStandaloneLocalSearchAbstractFactory
    {
        IImprovementHeuristicFactory CreateImprovementHeuristicFactory();

        ILateAcceptanceHillClimbingBridgeFactory CreateLateAcceptanceHillClimbingBridgeFactory();

        ILateAcceptanceHillClimbingFactory CreateLateAcceptanceHillClimbingFactory();

        IParametersFactory CreateParametersFactory();

        ISolverConfigurationFactory CreateSolverConfigurationFactory();
    }
}