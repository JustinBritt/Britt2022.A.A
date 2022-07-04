namespace Britt2022.A.A.Solutions.Classes
{
    using System;
    using System.Threading.Tasks;

    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.CrossJoinElements.InterfacesAbstractFactories;
    using Britt2022.A.A.CrossJoins.InterfacesAbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.GS.InterfacesAbstractFactories;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.IndexElements.InterfacesAbstractFactories;
    using Britt2022.A.A.LAHC.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.Models.InterfacesAbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.ResultElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;
    using Britt2022.A.A.SA.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.Solutions.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.VariableElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;
    using Britt2022.A.A.VNS.InterfacesAbstractFactories;

    public sealed class WGPMSolution : IWGPMSolution
    {
        public WGPMSolution()
        {
        }

        public Task<IWGPMOutputContext> Solve(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            ICrossJoinsAbstractFactory crossJoinsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IVariableElementsAbstractFactory variableElementsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration,
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchAbstractFactory = null,
            ISingleEmbeddedLocalSearchSolverConfiguration singleEmbeddedLocalSearchSolverConfiguration = null)
        {
            IWGPMOutputContext WGPMOutputContext = null;

            return Task.Run(() =>
            {
                System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

                stopWatch.Start();

                using (IWGPMModel WGPMModel = modelsAbstractFactory.CreateWGPMModelFactory().Create(
                    constraintsAbstractFactory,
                    crossJoinElementsAbstractFactory,
                    crossJoinsAbstractFactory,
                    indexElementsAbstractFactory,
                    objectiveFunctionsAbstractFactory,
                    parameterElementsAbstractFactory,
                    variableElementsAbstractFactory,
                    variablesAbstractFactory,
                    WGPMInputContext))
                {
                    if (singleEmbeddedLocalSearchSolverConfiguration == null)
                    {
                        this.GetStandaloneLocalSearchBridge(
                            standaloneLocalSearchAbstractFactory,
                            standaloneLocalSearchSolverConfiguration)
                        .Bridge(
                            constructionHeuristicAbstractFactory,
                            neighbourhoodStructuresAbstractFactory,
                            standaloneLocalSearchAbstractFactory,
                            WGPMModel,
                            standaloneLocalSearchSolverConfiguration);
                    }
                    else
                    {
                        this.GetSingleEmbeddedLocalSearchBridge(
                            singleEmbeddedLocalSearchAbstractFactory,
                            singleEmbeddedLocalSearchSolverConfiguration)
                        .Bridge(
                            constructionHeuristicAbstractFactory,
                            neighbourhoodStructuresAbstractFactory,
                            singleEmbeddedLocalSearchAbstractFactory,
                            standaloneLocalSearchAbstractFactory,
                            WGPMModel,
                            singleEmbeddedLocalSearchSolverConfiguration,
                            standaloneLocalSearchSolverConfiguration);
                    }
                    
                    stopWatch.Stop();

                    TimeSpan overallWallTime = stopWatch.Elapsed;

                    WGPMOutputContext = contextsAbstractFactory.CreateWGPMOutputContextFactory().Create(
                        dependenciesAbstractFactory,
                        resultsAbstractFactory,
                        WGPMModel.d1Minus.GetElementsAt(
                            WGPMModel.Surgeons,
                            WGPMModel.Scenarios,
                            WGPMModel.Geti(),
                            WGPMModel.Getω(),
                            WGPMModel.Getijk(),
                            WGPMModel.Getiω(),
                            WGPMModel.GetN(),
                            WGPMModel.Getn(),
                            WGPMModel.GetxWithoutClearing()),
                        WGPMModel.d1Plus.GetElementsAt(
                            WGPMModel.Surgeons,
                            WGPMModel.Scenarios,
                            WGPMModel.Geti(),
                            WGPMModel.Getω(),
                            WGPMModel.Getijk(),
                            WGPMModel.Getiω(),
                            WGPMModel.GetN(),
                            WGPMModel.Getn(),
                            WGPMModel.GetxWithoutClearing()),
                        WGPMModel.d2Minus.GetElementsAt(
                            WGPMModel.Surgeons,
                            WGPMModel.OperatingRooms,
                            WGPMModel.PlanningHorizon,
                            WGPMModel.Scenarios,
                            WGPMModel.Geti(),
                            WGPMModel.Getj(),
                            WGPMModel.Getk(),
                            WGPMModel.Getω(),
                            WGPMModel.Getijkω(),
                            WGPMModel.GetA(),
                            WGPMModel.Getn(),
                            WGPMModel.Getv(),
                            WGPMModel.GetxWithoutClearing()),
                        WGPMModel.I.GetElementsAt(
                            WGPMModel.PlanningHorizon,
                            WGPMModel.Scenarios,
                            WGPMModel.Geti(),
                            WGPMModel.Getj(),
                            WGPMModel.Getk(),
                            WGPMModel.Getl(),
                            WGPMModel.Getω(),
                            WGPMModel.Getilω(),
                            WGPMModel.Getkω(),
                            WGPMModel.GetΦ(),
                            WGPMModel.GetxWithoutClearing()),
                        WGPMModel.IMax.GetElementsAt(
                            WGPMModel.Scenarios,
                            WGPMModel.Geti(),
                            WGPMModel.Getj(),
                            WGPMModel.Getk(),
                            WGPMModel.Getω(),
                            WGPMModel.Getkω(),
                            WGPMModel.I.GetValue(
                                WGPMModel.Geti(),
                                WGPMModel.Getj(),
                                WGPMModel.Getk(),
                                WGPMModel.Getl(),
                                WGPMModel.Getω(),
                                WGPMModel.Getilω(),
                                WGPMModel.GetΦ(),
                                WGPMModel.GetxWithoutClearing())),
                        WGPMModel.IMin.GetElementsAt(
                            WGPMModel.Scenarios,
                            WGPMModel.Geti(),
                            WGPMModel.Getj(),
                            WGPMModel.Getk(),
                            WGPMModel.Getω(),
                            WGPMModel.Getkω(),
                            WGPMModel.I.GetValue(
                                WGPMModel.Geti(),
                                WGPMModel.Getj(),
                                WGPMModel.Getk(),
                                WGPMModel.Getl(),
                                WGPMModel.Getω(),
                                WGPMModel.Getilω(),
                                WGPMModel.GetΦ(),
                                WGPMModel.GetxWithoutClearing())),
                        (decimal)WGPMModel.ObjectiveFunction.GetValue(
                            WGPMModel.Geti(),
                            WGPMModel.Getj(),
                            WGPMModel.Getk(),
                            WGPMModel.Getl(),
                            WGPMModel.Getω(),
                            WGPMModel.Getijk(),
                            WGPMModel.Getijkω(),
                            WGPMModel.Getilω(),
                            WGPMModel.Getiω(),
                            WGPMModel.Getkω(),
                            WGPMModel.GetA(),
                            WGPMModel.GetN(),
                            WGPMModel.Getn(),
                            WGPMModel.Getv(),
                            WGPMModel.Getw1(),
                            WGPMModel.Getw2(),
                            WGPMModel.Getw3(),
                            WGPMModel.Getw4(),
                            WGPMModel.GetΡ(),
                            WGPMModel.GetΦ(),
                            WGPMModel.d1Minus,
                            WGPMModel.d2Minus,
                            WGPMModel.I,
                            WGPMModel.IMax,
                            WGPMModel.IMin,
                            WGPMModel.GetxWithoutClearing(),
                            WGPMModel.Goal1,
                            WGPMModel.Goal2,
                            WGPMModel.Goal3,
                            WGPMModel.Goal4),
                        overallWallTime,
                        WGPMModel.x.GetElementsAt(
                            WGPMModel.PlanningHorizon,
                            WGPMModel.OperatingRooms,
                            WGPMModel.Surgeons,
                            WGPMModel.Getijk(),
                            WGPMModel.GetxWithoutClearing()));
                }

                return WGPMOutputContext;
            });
        }

        private ISingleEmbeddedLocalSearchBridge GetSingleEmbeddedLocalSearchBridge(
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchAbstractFactory,
            ISingleEmbeddedLocalSearchSolverConfiguration singleEmbeddedLocalSearchSolverConfiguration)
        {
            return singleEmbeddedLocalSearchSolverConfiguration switch
            {
                Britt2022.A.A.ILS.Interfaces.ISolverConfiguration => ((IILSAbstractFactory)singleEmbeddedLocalSearchAbstractFactory).CreateIteratedLocalSearchBridgeFactory().Create(),

                Britt2022.A.A.VNS.Interfaces.ISolverConfiguration => ((IVNSAbstractFactory)singleEmbeddedLocalSearchAbstractFactory).CreateVariableNeighbourhoodSearchBridgeFactory().Create(),

                { } => throw new ArgumentNullException(nameof(singleEmbeddedLocalSearchSolverConfiguration)),

                _ => null
            };
        }

        private IStandaloneLocalSearchBridge GetStandaloneLocalSearchBridge(
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration)
        {
            return standaloneLocalSearchSolverConfiguration switch
            {
                Britt2022.A.A.GS.Interfaces.ISolverConfiguration => ((IGSAbstractFactory)standaloneLocalSearchAbstractFactory).CreateGreedySearchBridgeFactory().Create(),

                Britt2022.A.A.LAHC.Interfaces.ISolverConfiguration => ((ILAHCAbstractFactory)standaloneLocalSearchAbstractFactory).CreateLateAcceptanceHillClimbingBridgeFactory().Create(),

                Britt2022.A.A.SA.Interfaces.ISolverConfiguration => ((ISAAbstractFactory)standaloneLocalSearchAbstractFactory).CreateSimulatedAnnealingBridgeFactory().Create(),

                { } => throw new ArgumentNullException(nameof(standaloneLocalSearchSolverConfiguration)),

                _ => null
            };
        }
    }
}