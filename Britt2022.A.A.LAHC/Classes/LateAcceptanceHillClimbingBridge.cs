﻿namespace Britt2022.A.A.LAHC.Classes
{
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.LAHC.Interfaces;
    using Britt2022.A.A.LAHC.InterfacesAbstractFactories;
    using Britt2022.A.A.LocalSearch.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
   
    internal sealed class LateAcceptanceHillClimbingBridge : ILateAcceptanceHillClimbingBridge
    {
        public LateAcceptanceHillClimbingBridge()
        {
        }

        public void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            ILocalSearchAbstractFactory localSearchAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IWGPMModel WGPMModel,
            Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration solverConfiguration)
        {
            ((ILAHCAbstractFactory)localSearchAbstractFactory).CreateLateAcceptanceHillClimbingFactory().Create().Solve(
                constructionHeuristicFactory: constructionHeuristicAbstractFactory.CreateConstructionHeuristicFactory(),
                randomPairwiseSwapFactory: neighbourhoodStructuresAbstractFactory.CreateRandomPairwiseSwapFactory(),
                improvementHeuristicFactory: ((ILAHCAbstractFactory)localSearchAbstractFactory).CreateImprovementHeuristicFactory(),
                parameters: ((ILAHCAbstractFactory)localSearchAbstractFactory).CreateParametersFactory().Create(
                    (ISolverConfiguration)solverConfiguration),
                i: WGPMModel.Geti(),
                j: WGPMModel.Getj(),
                k: WGPMModel.Getk(),
                l: WGPMModel.Getl(),
                r: WGPMModel.Getr(),
                ω: WGPMModel.Getω(),
                ijk: WGPMModel.Getijk(),
                ijkω: WGPMModel.Getijkω(),
                ik: WGPMModel.Getik(),
                iω: WGPMModel.Getiω(),
                ilω: WGPMModel.Getilω(),
                jk: WGPMModel.Getjk(),
                kω: WGPMModel.Getkω(),
                A: WGPMModel.GetA(),
                B: WGPMModel.GetB(),
                B1: WGPMModel.GetB1(),
                F2: WGPMModel.GetF2(),
                H: WGPMModel.GetH(),
                Li: WGPMModel.GetL(),
                N: WGPMModel.GetN(),
                niω: WGPMModel.Getn(),
                v: WGPMModel.Getv(),
                w1: WGPMModel.Getw1(),
                w2: WGPMModel.Getw2(),
                w3: WGPMModel.Getw3(),
                w4: WGPMModel.Getw4(),
                Π: WGPMModel.GetΠ(),
                Ρ: WGPMModel.GetΡ(),
                Φ: WGPMModel.GetΦ(),
                Ω: WGPMModel.GetΩ(),
                d1Minus: WGPMModel.d1Minus,
                d2Minus: WGPMModel.d2Minus,
                I: WGPMModel.I,
                IMax: WGPMModel.IMax,
                IMin: WGPMModel.IMin,
                x: WGPMModel.Getx(),
                constraints: WGPMModel.Constraints,
                energyFunction: WGPMModel.ObjectiveFunction,
                goal1: WGPMModel.Goal1,
                goal2: WGPMModel.Goal2,
                goal3: WGPMModel.Goal3,
                goal4: WGPMModel.Goal4);
        }
    }
}