﻿namespace Britt2022.A.A.Exports.Classes
{
    using System.Threading.Tasks;

    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.Exports.Interfaces;
    using Britt2022.A.A.IndexElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.InterfacesAbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;
    using Britt2022.A.A.Solutions.InterfacesAbstractFactories;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.Interfaces;
    using Britt2022.A.A.SingleEmbeddedLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.StandaloneLocalSearches.Interfaces;
    using Britt2022.A.A.StandaloneLocalSearches.InterfacesAbstractFactories;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;

    public sealed class WGPMExport : IWGPMExport
    {
        public WGPMExport()
        {
        }

        public Task<IWGPMOutputContext> Solve(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISolutionsAbstractFactory solutionsAbstractFactory,
            IStandaloneLocalSearchAbstractFactory standaloneLocalSearchAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext,
            IStandaloneLocalSearchSolverConfiguration standaloneLocalSearchSolverConfiguration,
            ISingleEmbeddedLocalSearchAbstractFactory singleEmbeddedLocalSearchAbstractFactory = null,
            ISingleEmbeddedLocalSearchSolverConfiguration singleEmbeddedLocalSearchSolverConfiguration = null)
        {
            return solutionsAbstractFactory.CreateWGPMSolutionFactory().Create().Solve(
                constraintsAbstractFactory,
                constructionHeuristicAbstractFactory,
                contextsAbstractFactory,
                dependenciesAbstractFactory,
                indexElementsAbstractFactory,
                modelsAbstractFactory,
                neighbourhoodStructuresAbstractFactory,
                objectiveFunctionsAbstractFactory,
                parameterElementsAbstractFactory,
                resultsAbstractFactory,
                standaloneLocalSearchAbstractFactory,
                variablesAbstractFactory,
                WGPMInputContext,
                standaloneLocalSearchSolverConfiguration,
                singleEmbeddedLocalSearchAbstractFactory,
                singleEmbeddedLocalSearchSolverConfiguration);
        }
    }
}