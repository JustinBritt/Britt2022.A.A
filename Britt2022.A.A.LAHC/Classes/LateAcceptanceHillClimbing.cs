namespace Britt2022.A.A.LAHC.Classes
{
    using System;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesFactories;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.LAHC.Interfaces;
    using Britt2022.A.A.LAHC.InterfacesFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    internal sealed class LateAcceptanceHillClimbing : ILateAcceptanceHillClimbing
    {
        public LateAcceptanceHillClimbing()
        {
        }

        public unsafe void Solve(
            IConstructionHeuristicFactory constructionHeuristicFactory,
            IRandomPairwiseSwapFactory randomPairwiseSwapFactory,
            IImprovementHeuristicFactory improvementHeuristicFactory,
            IStandaloneLocalSearchParameters parameters,
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
            ReadOnlySpan<ΦParameterElement> Φ,
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
            IGoal4 goal4)
        {
            constructionHeuristicFactory.Create().GenerateInitialFeasibleSchedule(
                i: i,
                j: j,
                k: k,
                r: r,
                ijk: ijk,
                B: B,
                B1: B1,
                F2: F2,
                H: H,
                L: Li,
                Π: Π,
                Ω: Ω,
                x: x);

            improvementHeuristicFactory.Create().Search(
                randomPairwiseSwapFactory: randomPairwiseSwapFactory,
                parameters: parameters,
                i: i,
                j: j,
                k: k,
                l: l,
                r: r,
                ω: ω,
                ijk: ijk,
                ijkω: ijkω,
                ik: ik,
                iω: iω,
                ilω: ilω,
                jk: jk,
                kω: kω,
                A: A,
                B: B,
                B1: B1,
                F2: F2,
                H: H,
                Li: Li,
                N: N,
                niω: niω,
                v: v,
                w1: w1,
                w2: w2,
                w3: w3,
                w4: w4,
                Π: Π,
                Ρ: Ρ,
                Φ: Φ,
                Ω: Ω,
                d1Minus: d1Minus,
                d2Minus: d2Minus,
                I: I,
                IMax: IMax,
                IMin: IMin,
                x: x,
                constraints: constraints,
                energyFunction: energyFunction,
                goal1: goal1,
                goal2: goal2,
                goal3: goal3,
                goal4: goal4);
        }
    }
}