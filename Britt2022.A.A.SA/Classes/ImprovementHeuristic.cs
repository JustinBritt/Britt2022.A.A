namespace Britt2022.A.A.SA.Classes
{
    using System;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
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
    using Britt2022.A.A.SA.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    public sealed class ImprovementHeuristic : IImprovementHeuristic
    {
        public ImprovementHeuristic()
        {
        }

        public unsafe void Search(
            INeighbourhoodStructureFactory neighbourhoodStructureFactory,
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
            RedBlackTree<int, RedBlackTree<int, RedBlackTree<int, ΦParameterElement>>> Φ,
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
            Random randomUniform = new Random();

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

            double currentEnergy = initialEnergy;

            double newEnergy = 0;

            double currentTemperature = ((IParameters)parameters).InitialTemperature;

            int NA = 0;

            int NATotal = 0;

            fixed (xVariableElement * xPtr = x)
            {
                while (currentTemperature > ((IParameters)parameters).FinalTemperature)
                {
                    currentEnergy = energyFunction.GetValue(
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

                    NATotal += NA;

                    NA = 0;

                    while (NA < ((IParameters)parameters).MaximumSolutionsAccepted)
                    {
                        INeighbourhoodStructure neighbourhoodStructure = neighbourhoodStructureFactory.Create();

                        neighbourhoodStructure.Swap(
                            i,
                            j,
                            k,
                            r,
                            B1,
                            F2,
                            x);

                        if (neighbourhoodStructure.SwapMade)
                        {
                            if (constraints.IsFeasible(i, j, k, r, ijk, ik, jk, B, B1, F2, H, Li, Π, Ω, x))
                            {
                                newEnergy = energyFunction.GetValue(
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

                                if (newEnergy < currentEnergy)
                                {
                                    // Accept new solution and swap values
                                    NA = NA + 1;

                                    currentEnergy = newEnergy;
                                }
                                else if (newEnergy >= currentEnergy)
                                {
                                    // Metropolis Criterion
                                    if (Math.Exp(-(newEnergy - currentEnergy) / currentTemperature) > randomUniform.NextDouble())
                                    {
                                        // Accept new solution and swap values
                                        NA = NA + 1;

                                        currentEnergy = newEnergy;
                                    }
                                    else
                                    {
                                        //Reject new solution and don't swap values
                                        neighbourhoodStructure.UndoSwap(
                                            x);
                                    }
                                }
                            }
                            else
                            {
                                // Reject due to infeasibility
                                neighbourhoodStructure.UndoSwap(
                                    x);
                            }
                        }
                    }

                    currentTemperature = currentTemperature * ((IParameters)parameters).CoolingRate;
                }
            }
        }
    }
}