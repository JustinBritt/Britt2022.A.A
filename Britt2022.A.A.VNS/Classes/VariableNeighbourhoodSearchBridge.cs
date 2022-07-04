namespace Britt2022.A.A.VNS.Classes
{
    using System;

    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.GS.InterfacesAbstractFactories;
    using Britt2022.A.A.LAHC.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.SA.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.VariableElements.InterfacesAbstractFactories;
    using Britt2022.A.A.VNS.Interfaces;
    using Britt2022.A.A.VNS.InterfacesAbstractFactories;

    internal sealed class VariableNeighbourhoodSearchBridge : IVariableNeighbourhoodSearchBridge
    {
        public VariableNeighbourhoodSearchBridge()
        {
        }

        public void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IVNSAbstractFactory VNSAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IVariableElementsAbstractFactory variableElementsAbstractFactory,
            IWGPMModel WGPMModel,
            IStandaloneLocalSearchImprovementHeuristic standaloneLocalSearchImprovementHeuristic,
            ISingleEmbeddedLocalSearchParameters singleEmbeddedLocalSearchParameters,
            IStandaloneLocalSearchParameters standaloneLocalSearchParameters)
        {
            VNSAbstractFactory.CreateVariableNeighbourhoodSearchFactory().Create().Solve(
                constructionHeuristicFactory: constructionHeuristicAbstractFactory.CreateConstructionHeuristicFactory(),
                neighbourhoodStructureFactory: neighbourhoodStructuresAbstractFactory.CreateRandomPairwiseSwapFactory(),
                improvementHeuristicFactory: VNSAbstractFactory.CreateImprovementHeuristicFactory(),
                xVariableElementFactory: variableElementsAbstractFactory.CreatexVariableElementFactory(),
                parameters: singleEmbeddedLocalSearchParameters,
                standaloneLocalSearchImprovementHeuristic: standaloneLocalSearchImprovementHeuristic,
                standaloneLocalSearchParameters: standaloneLocalSearchParameters,
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

        public void Bridge(
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IVariableElementsAbstractFactory variableElementsAbstractFactory,
            IWGPMModel WGPMModel,
            ISingleEmbeddedLocalSearchSolverConfiguration singleEmbeddedLocalSearchSolverConfiguration,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration)
        {
            this.Bridge(
                constructionHeuristicAbstractFactory,
                (IVNSAbstractFactory)singleEmbeddedLocalSearchAbstractFactory,
                neighbourhoodStructuresAbstractFactory,
                variableElementsAbstractFactory,
                WGPMModel,
                this.GetStandaloneLocalSearchImprovementHeuristic(
                    standaloneLocalSearchAbstractFactory,
                    standaloneLocalSearchSolverConfiguration),
                ((IVNSAbstractFactory)singleEmbeddedLocalSearchAbstractFactory).CreateParametersFactory().Create(
                    (ISolverConfiguration)singleEmbeddedLocalSearchSolverConfiguration),
                this.GetStandaloneLocalSearchParameters(
                    standaloneLocalSearchAbstractFactory,
                    standaloneLocalSearchSolverConfiguration));
        }

        private IStandaloneLocalSearchImprovementHeuristic GetStandaloneLocalSearchImprovementHeuristic(
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration)
        {
            return standaloneLocalSearchSolverConfiguration switch
            {
                Britt2022.A.A.GS.Interfaces.ISolverConfiguration => ((IGSAbstractFactory)standaloneLocalSearchAbstractFactory).CreateImprovementHeuristicFactory().Create(),

                Britt2022.A.A.LAHC.Interfaces.ISolverConfiguration => ((ILAHCAbstractFactory)standaloneLocalSearchAbstractFactory).CreateImprovementHeuristicFactory().Create(),

                Britt2022.A.A.SA.Interfaces.ISolverConfiguration => ((ISAAbstractFactory)standaloneLocalSearchAbstractFactory).CreateImprovementHeuristicFactory().Create(),

                { } => throw new ArgumentNullException(nameof(standaloneLocalSearchSolverConfiguration)),

                _ => null
            };
        }

        private IStandaloneLocalSearchParameters GetStandaloneLocalSearchParameters(
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration)
        {
            return standaloneLocalSearchSolverConfiguration switch
            {
                Britt2022.A.A.GS.Interfaces.ISolverConfiguration => ((IGSAbstractFactory)standaloneLocalSearchAbstractFactory).CreateParametersFactory().Create(
                        (Britt2022.A.A.GS.Interfaces.ISolverConfiguration)standaloneLocalSearchSolverConfiguration),

                Britt2022.A.A.LAHC.Interfaces.ISolverConfiguration => ((ILAHCAbstractFactory)standaloneLocalSearchAbstractFactory).CreateParametersFactory().Create(
                        (Britt2022.A.A.LAHC.Interfaces.ISolverConfiguration)standaloneLocalSearchSolverConfiguration),

                Britt2022.A.A.SA.Interfaces.ISolverConfiguration => ((ISAAbstractFactory)standaloneLocalSearchAbstractFactory).CreateParametersFactory().Create(
                        (Britt2022.A.A.SA.Interfaces.ISolverConfiguration)standaloneLocalSearchSolverConfiguration),

                { } => throw new ArgumentNullException(nameof(standaloneLocalSearchSolverConfiguration)),

                _ => null
            };
        }
    }
}