namespace Britt2022.A.A.ILS.Interfaces
{
    using System;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.ILS.InterfacesFactories;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public interface IIteratedLocalSearch
    {
        void Solve(
            IConstructionHeuristicFactory constructionHeuristicFactory,
            IImprovementHeuristicFactory improvementHeuristicFactory,
            INeighbourhoodStructureFactory neighbourhoodStructureFactory,
            IxVariableElementFactory xVariableElementFactory,
            ISingleEmbeddedLocalSearchParameters parameters,
            IStandaloneLocalSearchImprovementHeuristic standaloneLocalSearchImprovementHeuristic,
            IStandaloneLocalSearchParameters standaloneLocalSearchParameters,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<lIndexElement> l,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ijkωCrossJoinElement> ijkω,
            ReadOnlySpan<ikCrossJoinElement> ik,
            ReadOnlySpan<ilωCrossJoinElement> ilω,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<jkCrossJoinElement> jk,
            ReadOnlySpan<kωCrossJoinElement> kω,
            ReadOnlySpan<AParameterElement> A,
            ReadOnlySpan<BParameterElement> B,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            ReadOnlySpan<HParameterElement> H,
            ReadOnlySpan<LParameterElement> Li,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            double v,
            ReadOnlySpan<ΠParameterElement> Π,
            ReadOnlySpan<ΡParameterElement> Ρ,
            RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, decimal>>> Φ,
            ReadOnlySpan<ΩParameterElement> Ω,
            double w1,
            double w2,
            double w3,
            double w4,
            Id1Minus d1Minus,
            Id2Minus d2Minus,
            II I,
            IIMax IMax,
            IIMin IMin,
            Span<xVariableElement> x,
            IConstraints constraints,
            IObjectiveFunction energyFunction,
            IGoal1 goal1,
            IGoal2 goal2,
            IGoal3 goal3,
            IGoal4 goal4);
    }
}