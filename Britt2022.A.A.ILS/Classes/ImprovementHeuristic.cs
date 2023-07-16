namespace Britt2022.A.A.ILS.Classes
{
    using System;
    using System.Linq;

    using Britt2022.A.A.Constraints.Interfaces;
    using Britt2022.A.A.CrossJoinElements.Structs;
    using Britt2022.A.A.ILS.Interfaces;
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
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.VariableElements.InterfacesFactories;
    using Britt2022.A.A.VariableElements.Structs;
    using Britt2022.A.A.Variables.Interfaces;

    internal sealed class ImprovementHeuristic : IImprovementHeuristic
    {
        public ImprovementHeuristic()
        {
        }

        public unsafe void Search(
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
            Span<xVariableElement> x0Span = (Span<xVariableElement>)Array.CreateInstance(
                typeof(xVariableElement),
                1 + ijk.ToArray().Select(w => w.ijkOI).Max());

            x0Span.Clear();

            for (int w = 1; w < ijk.Length; w = w + 1)
            {
                x0Span[ijk[w].ijkOI] = xVariableElementFactory.Create(
                    ijk[w].iIndexElement,
                    ijk[w].jIndexElement,
                    ijk[w].kIndexElement,
                    0);
            }

            Span<xVariableElement> xStarSpan = (Span<xVariableElement>)Array.CreateInstance(
                typeof(xVariableElement),
                1 + ijk.ToArray().Select(w => w.ijkOI).Max());

            xStarSpan.Clear();

            for (int w = 1; w < ijk.Length; w = w + 1)
            {
                xStarSpan[ijk[w].ijkOI] = xVariableElementFactory.Create(
                    ijk[w].iIndexElement,
                    ijk[w].jIndexElement,
                    ijk[w].kIndexElement,
                    0);
            }

            Span<xVariableElement> xPrimeSpan = (Span<xVariableElement>)Array.CreateInstance(
                typeof(xVariableElement),
                1 + ijk.ToArray().Select(w => w.ijkOI).Max());

            xPrimeSpan.Clear();

            for (int w = 1; w < ijk.Length; w = w + 1)
            {
                xPrimeSpan[ijk[w].ijkOI] = xVariableElementFactory.Create(
                    ijk[w].iIndexElement,
                    ijk[w].jIndexElement,
                    ijk[w].kIndexElement,
                    0);
            }

            Span<xVariableElement> xStarPrimeSpan = (Span<xVariableElement>)Array.CreateInstance(
                typeof(xVariableElement),
                1 + ijk.ToArray().Select(w => w.ijkOI).Max());

            xStarPrimeSpan.Clear();

            for (int w = 1; w < ijk.Length; w = w + 1)
            {
                xStarPrimeSpan[ijk[w].ijkOI] = xVariableElementFactory.Create(
                    ijk[w].iIndexElement,
                    ijk[w].jIndexElement,
                    ijk[w].kIndexElement,
                    0);
            }

            int numberIterations = 0;

            x.CopyTo(
                x0Span);

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
                null,//Φ,
                d1Minus,
                d2Minus,
                I,
                IMax,
                IMin,
                x0Span,
                goal1,
                goal2,
                goal3,
                goal4);

            x0Span.CopyTo(
                xStarSpan);

            standaloneLocalSearchImprovementHeuristic.Search(
                neighbourhoodStructureFactory,
                standaloneLocalSearchParameters,
                i,
                j,
                k,
                l,
                r,
                ω,
                ijk,
                ijkω,
                ik,
                ilω,
                iω,
                jk,
                kω,
                A,
                B,
                B1,
                F2,
                H,
                Li,
                N,
                niω,
                v,
                Π,
                Ρ,
                Φ,
                Ω,
                w1,
                w2,
                w3,
                w4,
                d1Minus,
                d2Minus,
                I,
                IMax,
                IMin,
                xStarSpan,
                constraints,
                energyFunction,
                goal1,
                goal2,
                goal3,
                goal4);

            while (numberIterations < ((IParameters)parameters).NumberIterations)
            {
                double xStarEnergy = energyFunction.GetValue(
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
                    null,//Φ,
                    d1Minus,
                    d2Minus,
                    I,
                    IMax,
                    IMin,
                    xStarSpan,
                    goal1,
                    goal2,
                    goal3,
                    goal4);

                xStarSpan.CopyTo(
                    xPrimeSpan);

                this.Perturbation(
                    neighbourhoodStructureFactory,
                    i,
                    j,
                    k,
                    r,
                    ijk,
                    ik,
                    jk,
                    B,
                    B1,
                    F2,
                    H,
                    Li,
                    Π,
                    Ω,
                    xPrimeSpan,
                    constraints,
                    ((IParameters)parameters).NumberPerturbations);

                xPrimeSpan.CopyTo(
                    xStarPrimeSpan);

                standaloneLocalSearchImprovementHeuristic.Search(
                    neighbourhoodStructureFactory,
                    standaloneLocalSearchParameters,
                    i,
                    j,
                    k,
                    l,
                    r,
                    ω,
                    ijk,
                    ijkω,
                    ik,
                    ilω,
                    iω,
                    jk,
                    kω,
                    A,
                    B,
                    B1,
                    F2,
                    H,
                    Li,
                    N,
                    niω,
                    v,
                    Π,
                    Ρ,
                    null,//Φ,
                    Ω,
                    w1,
                    w2,
                    w3,
                    w4,
                    d1Minus,
                    d2Minus,
                    I,
                    IMax,
                    IMin,
                    xStarPrimeSpan,
                    constraints,
                    energyFunction,
                    goal1,
                    goal2,
                    goal3,
                    goal4);

                double xStarPrimeEnergy = energyFunction.GetValue(
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
                    null,// Φ,
                    d1Minus,
                    d2Minus,
                    I,
                    IMax,
                    IMin,
                    xStarPrimeSpan,
                    goal1,
                    goal2,
                    goal3,
                    goal4);

                if (xStarPrimeEnergy <= xStarEnergy)
                {
                    xStarPrimeSpan.CopyTo(
                        xStarSpan);
                }

                numberIterations = numberIterations + 1;
            }

            xStarSpan.CopyTo(
                x);
        }

        private Span<xVariableElement> Perturbation(
            INeighbourhoodStructureFactory neighbourhoodStructureFactory,
            ReadOnlySpan<iIndexElement> i,
            ReadOnlySpan<jIndexElement> j,
            ReadOnlySpan<kIndexElement> k,
            ReadOnlySpan<rIndexElement> r,
            ReadOnlySpan<ijkCrossJoinElement> ijk,
            ReadOnlySpan<ikCrossJoinElement> ik,
            ReadOnlySpan<jkCrossJoinElement> jk,
            ReadOnlySpan<BParameterElement> B,
            ReadOnlySpan<B1ParameterElement> B1,
            ReadOnlySpan<F2ParameterElement> F2,
            ReadOnlySpan<HParameterElement> H,
            ReadOnlySpan<LParameterElement> Li,
            ReadOnlySpan<ΠParameterElement> Π,
            ReadOnlySpan<ΩParameterElement> Ω,
            Span<xVariableElement> x,
            IConstraints constraints,
            int swapsTarget)
        {
            int swapCounter = 0;

            while (swapCounter < swapsTarget)
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
                        swapCounter = swapCounter + 1;
                    }
                    else
                    {
                        // Reject swap
                        neighbourhoodStructure.UndoSwap(
                            x);
                    }
                }
            }

            return x;
        }
    }
}