namespace Britt2022.A.A.Solutions.Classes
{
    using System;
    using System.Threading.Tasks;

    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.GS.InterfacesAbstractFactories;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.LAHC.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.Models.InterfacesAbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;
    using Britt2022.A.A.SA.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.Solutions.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;
    
    public sealed class WGPMSolution : IWGPMSolution
    {
        public WGPMSolution()
        {
        }

        // StandaloneLocalSearches
        public Task<IWGPMOutputContext> Solve(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration)
        {
            IWGPMOutputContext WGPMOutputContext = null;

            return Task.Run(() =>
            {
                System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

                stopWatch.Start();

                using (IWGPMModel WGPMModel = modelsAbstractFactory.CreateWGPMModelFactory().Create(
                    constraintsAbstractFactory,
                    objectiveFunctionsAbstractFactory,
                    parameterElementsAbstractFactory,
                    variablesAbstractFactory,
                    WGPMInputContext))
                {
                    if (typeof(Britt2022.A.A.GS.Interfaces.ISolverConfiguration).IsAssignableFrom(standaloneLocalSearchSolverConfiguration.GetType()))
                    {
                        ((IGSAbstractFactory)standaloneLocalSearchAbstractFactory).CreateGreedySearchBridgeFactory().Create().Bridge(
                            constructionHeuristicAbstractFactory,
                            neighbourhoodStructuresAbstractFactory,
                            ((IGSAbstractFactory)standaloneLocalSearchAbstractFactory),
                            WGPMModel,
                            standaloneLocalSearchSolverConfiguration);
                    }
                    else if (typeof(Britt2022.A.A.LAHC.Interfaces.ISolverConfiguration).IsAssignableFrom(standaloneLocalSearchSolverConfiguration.GetType()))
                    {
                        ((ILAHCAbstractFactory)standaloneLocalSearchAbstractFactory).CreateLateAcceptanceHillClimbingBridgeFactory().Create().Bridge(
                            constructionHeuristicAbstractFactory,
                            neighbourhoodStructuresAbstractFactory,
                            ((ILAHCAbstractFactory)standaloneLocalSearchAbstractFactory),
                            WGPMModel,
                            standaloneLocalSearchSolverConfiguration);
                    }
                    else if (typeof(Britt2022.A.A.SA.Interfaces.ISolverConfiguration).IsAssignableFrom(standaloneLocalSearchSolverConfiguration.GetType()))
                    {
                        ((ISAAbstractFactory)standaloneLocalSearchAbstractFactory).CreateSimulatedAnnealingBridgeFactory().Create().Bridge(
                            constructionHeuristicAbstractFactory,
                            neighbourhoodStructuresAbstractFactory,
                            ((ISAAbstractFactory)standaloneLocalSearchAbstractFactory),
                            WGPMModel,
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

        // SingleEmbeddedLocalSearches
        public Task<IWGPMOutputContext> Solve(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext,
            ISingleEmbeddedLocalSearchSolverConfiguration singleEmbeddedLocalSearchSolverConfiguration,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration)
        {
            IWGPMOutputContext WGPMOutputContext = null;

            return Task.Run(() =>
            {
                System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();

                stopWatch.Start();

                using (IWGPMModel WGPMModel = modelsAbstractFactory.CreateWGPMModelFactory().Create(
                    constraintsAbstractFactory,
                    objectiveFunctionsAbstractFactory,
                    parameterElementsAbstractFactory,
                    variablesAbstractFactory,
                    WGPMInputContext))
                {
                    if (typeof(Britt2022.A.A.ILS.Interfaces.ISolverConfiguration).IsAssignableFrom(singleEmbeddedLocalSearchSolverConfiguration.GetType()))
                    {
                        ((IILSAbstractFactory)singleEmbeddedLocalSearchAbstractFactory).CreateIteratedLocalSearchBridgeFactory().Create().Bridge(
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
    }
}