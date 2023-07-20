namespace Britt2022.A.A.ObjectiveFunctions.Interfaces
{
    using System;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public interface IObjectiveFunction
    {
        double GetValue(
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<lIndexElement> l,
            ReadOnlySpan<ωIndexElement> ω,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ijkωCrossJoinElement> ijkω,
            ReadOnlySpan<ilωCrossJoinElement> ilω,
            ReadOnlySpan<iωCrossJoinElement> iω,
            ReadOnlySpan<kωCrossJoinElement> kω,
            ReadOnlySpan<AParameterElement> A,
            ReadOnlySpan<NParameterElement> N,
            ReadOnlySpan<niωParameterElement> niω,
            double v,
            double w1,
            double w2,
            double w3,
            double w4,
            ReadOnlySpan<ΡParameterElement> Ρ,
            RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>> Φ,
            Id1Minus d1Minus,
            Id2Minus d2Minus,
            II I,
            IIMax IMax,
            IIMin IMin,
            Span<xVariableElement> x,
            IGoal1 goal1,
            IGoal2 goal2,
            IGoal3 goal3,
            IGoal4 goal4);
    }
}