﻿namespace Britt2022.A.A.Exports.Classes
{
    using System.Threading.Tasks;

    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.Exports.Interfaces;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.InterfacesAbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;
    using Britt2022.A.A.Solutions.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;

    public sealed class WGPMExport : IWGPMExport
    {
        public WGPMExport()
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
            ISolutionsAbstractFactory solutionsAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration)
        {
            return solutionsAbstractFactory.CreateWGPMSolutionFactory().Create().Solve(
                constraintsAbstractFactory,
                constructionHeuristicAbstractFactory,
                contextsAbstractFactory,
                dependenciesAbstractFactory,
                modelsAbstractFactory,
                neighbourhoodStructuresAbstractFactory,
                objectiveFunctionsAbstractFactory,
                parameterElementsAbstractFactory,
                resultsAbstractFactory,
                standaloneLocalSearchAbstractFactory,
                variablesAbstractFactory,
                WGPMInputContext,
                standaloneLocalSearchSolverConfiguration);
        }

        // SingleEmbeddedLocalSearches
        public Task<IWGPMOutputContext> Solve(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IILSAbstractFactory ILSAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISolutionsAbstractFactory solutionsAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext,
            Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration singleEmbeddedLocalSearchSolverConfiguration,
            Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration standaloneLocalSearchSolverConfiguration)
        {
            return solutionsAbstractFactory.CreateWGPMSolutionFactory().Create().Solve(
                constraintsAbstractFactory,
                constructionHeuristicAbstractFactory,
                contextsAbstractFactory,
                dependenciesAbstractFactory,
                modelsAbstractFactory,
                neighbourhoodStructuresAbstractFactory,
                objectiveFunctionsAbstractFactory,
                parameterElementsAbstractFactory,
                resultsAbstractFactory,
                ILSAbstractFactory,
                standaloneLocalSearchAbstractFactory,
                variablesAbstractFactory,
                WGPMInputContext,
                singleEmbeddedLocalSearchSolverConfiguration,
                standaloneLocalSearchSolverConfiguration);
        }
    }
}