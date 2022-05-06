﻿namespace Britt2022.A.A.ILS.Classes
{
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.GS.InterfacesAbstractFactories;
    using Britt2022.A.A.ILS.Interfaces;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.LAHC.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.SA.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;

    internal sealed class IteratedLocalSearchBridge : IIteratedLocalSearchBridge
    {
        public IteratedLocalSearchBridge()
        {
        }

        // ILS
        public void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IILSAbstractFactory ILSAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IWGPMModel WGPMModel,
            IStandaloneLocalSearchImprovementHeuristic standalonelocalSearchImprovementHeuristic,
            IStandaloneLocalSearchParameters standalonelocalSearchParameters,
            ISingleEmbeddedLocalSearchParameters parameters)
        {
            ILSAbstractFactory.CreateIteratedLocalSearchFactory().Create().Solve(
                constructionHeuristicFactory: constructionHeuristicAbstractFactory.CreateConstructionHeuristicFactory(),
                randomPairwiseSwapFactory: neighbourhoodStructuresAbstractFactory.CreateRandomPairwiseSwapFactory(),
                improvementHeuristicFactory: ILSAbstractFactory.CreateImprovementHeuristicFactory(),
                parameters: parameters,
                standalonelocalSearchImprovementHeuristic: standalonelocalSearchImprovementHeuristic,
                standalonelocalSearchParameters: standalonelocalSearchParameters,
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

        // ILS
        public void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IWGPMModel WGPMModel,
            Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration localSearchSolverConfiguration,
            Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration ILSSolverConfiguration) 
        {
            IStandaloneLocalSearchParameters standalonelocalSearchParameters = null;

            IStandaloneLocalSearchImprovementHeuristic standalonelocalSearchImprovementHeuristic = null;

            if (typeof(Britt2022.A.A.GS.Interfaces.ISolverConfiguration).IsAssignableFrom(localSearchSolverConfiguration.GetType()))
            {
                standalonelocalSearchParameters = ((IGSAbstractFactory)standaloneLocalSearchAbstractFactory).CreateParametersFactory().Create(
                        (Britt2022.A.A.GS.Interfaces.ISolverConfiguration)localSearchSolverConfiguration);

                standalonelocalSearchImprovementHeuristic = ((IGSAbstractFactory)standaloneLocalSearchAbstractFactory).CreateImprovementHeuristicFactory().Create();
            }
            else if (typeof(Britt2022.A.A.LAHC.Interfaces.ISolverConfiguration).IsAssignableFrom(localSearchSolverConfiguration.GetType()))
            {
                standalonelocalSearchParameters = ((ILAHCAbstractFactory)standaloneLocalSearchAbstractFactory).CreateParametersFactory().Create(
                        (Britt2022.A.A.LAHC.Interfaces.ISolverConfiguration)localSearchSolverConfiguration);

                standalonelocalSearchImprovementHeuristic = ((ILAHCAbstractFactory)standaloneLocalSearchAbstractFactory).CreateImprovementHeuristicFactory().Create();
            }
            else if (typeof(Britt2022.A.A.SA.Interfaces.ISolverConfiguration).IsAssignableFrom(localSearchSolverConfiguration.GetType()))
            {
                standalonelocalSearchParameters = ((ISAAbstractFactory)standaloneLocalSearchAbstractFactory).CreateParametersFactory().Create(
                        (Britt2022.A.A.SA.Interfaces.ISolverConfiguration)localSearchSolverConfiguration);

                standalonelocalSearchImprovementHeuristic = ((ISAAbstractFactory)standaloneLocalSearchAbstractFactory).CreateImprovementHeuristicFactory().Create();
            }
     
            this.Bridge(
                constructionHeuristicAbstractFactory,
                (IILSAbstractFactory)singleEmbeddedLocalSearchAbstractFactory,
                neighbourhoodStructuresAbstractFactory,
                WGPMModel,
                standalonelocalSearchImprovementHeuristic,
                standalonelocalSearchParameters,
                ((IILSAbstractFactory)singleEmbeddedLocalSearchAbstractFactory).CreateParametersFactory().Create(
                    (ISolverConfiguration)ILSSolverConfiguration));
        }
    }
}