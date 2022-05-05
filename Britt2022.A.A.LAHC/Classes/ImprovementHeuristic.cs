namespace Britt2022.A.A.LAHC.Classes
{
    using System;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.LAHC.Interfaces;
    using Britt2022.A.A.LocalSearch.Interfaces;
    using Britt2022.A.A.IndexElements.Structs;
    using Britt2022.A.A.NeighbourhoodStructures.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ParameterElements.Structs.LengthsOfStay;
    using Britt2022.A.A.ParameterElements.Structs.PreferencesOfSurgeons;
    using Britt2022.A.A.ParameterElements.Structs.ScenarioProbabilities;
    using Britt2022.A.A.ParameterElements.Structs.StrategicTargets;
    using Britt2022.A.A.ParameterElements.Structs.Surgeries;
    using Britt2022.A.A.ParameterElements.Structs.SurgicalSpecialties;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    internal sealed class ImprovementHeuristic : IImprovementHeuristic
    {
        public ImprovementHeuristic()
        {
        }

        public unsafe Span<xVariableElement> Search(
            IRandomPairwiseSwapFactory randomPairwiseSwapFactory,
            ILocalSearchParameters parameters,
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
            // Initial solution and its energy
            double initialEnergy = energyFunction.GetValue(
                i,
                j,
                k,
                l,
                ω,
                ijk,
                ijkω,
                ilω,
                iω,
                kω,
                A,
                N,
                niω,
                v,
                w1,
                w2,
                w3,
                w4,
                Ρ,
                Φ,
                d1Minus,
                d2Minus,
                I,
                IMax,
                IMin,
                x,
                goal1,
                goal2,
                goal3,
                goal4);

            // For all k in {0...L_h - 1} f_k := c(s)
            Span<double> f = (Span<double>)Array.CreateInstance(typeof(double), ((IParameters)parameters).FitnessArrayLength);

            for (int w = 0; w < ((IParameters)parameters).FitnessArrayLength; w = w + 1)
            {
                f[w] = initialEnergy;
            }

            // First iteration: It := 0, It_idle := 0
            int It = 0;

            int It_Idle = 0;

            while (It <= 100000 && It_Idle <= 0.02 * It)
            {
                double incumbentEnergy = energyFunction.GetValue(
                    i,
                    j,
                    k,
                    l,
                    ω,
                    ijk,
                    ijkω,
                    ilω,
                    iω,
                    kω,
                    A,
                    N,
                    niω,
                    v,
                    w1,
                    w2,
                    w3,
                    w4,
                    Ρ,
                    Φ,
                    d1Minus,
                    d2Minus,
                    I,
                    IMax,
                    IMin,
                    x,
                    goal1,
                    goal2,
                    goal3,
                    goal4);

                // Construct a candidate solution s*
                bool feasibleCandidateSolution = false;

                IRandomPairwiseSwap randomPairwiseSwap = randomPairwiseSwapFactory.Create();

                while (!feasibleCandidateSolution)
                {
                    randomPairwiseSwap.Swap(
                        i,
                        j,
                        k,
                        r,
                        B1,
                        F2,
                        x);

                    if (randomPairwiseSwap.SwapMade)
                    {
                        if (constraints.IsFeasible(i, j, k, r, ijk, ik, jk, B, B1, F2, H, Li, Π, Ω, x))
                        {
                            feasibleCandidateSolution = true;
                        }
                        else
                        {
                            // Reject due to infeasibility
                            randomPairwiseSwap.UndoSwap(
                                x);
                        }
                    }
                }
                
                // Calculate a candidate cost function C(s*)
                double candidateEnergy = energyFunction.GetValue(
                    i,
                    j,
                    k,
                    l,
                    ω,
                    ijk,
                    ijkω,
                    ilω,
                    iω,
                    kω,
                    A,
                    N,
                    niω,
                    v,
                    w1,
                    w2,
                    w3,
                    w4,
                    Ρ,
                    Φ,
                    d1Minus,
                    d2Minus,
                    I,
                    IMax,
                    IMin,
                    x,
                    goal1,
                    goal2,
                    goal3,
                    goal4);

                // If C(s*) >= C(s)
                if (candidateEnergy >= incumbentEnergy)
                {
                    // Then increment the idle iterations number It_idle := It_idle + 1
                    It_Idle = It_Idle + 1;
                }
                // Else reset the idle iterations number It_idle := 0
                else
                {
                    It_Idle = 0;
                }

                // Calculate the virtual beginning vB := It mod L_h
                int vB = It % ((IParameters)parameters).FitnessArrayLength;

                // If C(s*) < f_v or C(s*) <= C(s)
                if (candidateEnergy < f[vB] || candidateEnergy <= incumbentEnergy)
                {
                    // Then accept the candidate s : = s*

                }
                // Else reject the candidate s := s
                else
                {
                    randomPairwiseSwap.UndoSwap(
                        x);
                }

                // If C(s) < f_v
                if (incumbentEnergy < f[vB])
                {
                    // Then update the fitness array f_v := C(s)
                    f[vB] = incumbentEnergy;
                }

                //Increment the iteration number It := It + 1
                It = It + 1;
            }

            return x;
        }
    }
}