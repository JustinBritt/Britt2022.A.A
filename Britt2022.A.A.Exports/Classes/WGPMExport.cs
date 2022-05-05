namespace Britt2022.A.A.Exports.Classes
{
    using System.Threading.Tasks;

    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.Exports.Interfaces;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.LocalSearch.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.InterfacesAbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;
    using Britt2022.A.A.Solutions.InterfacesAbstractFactories;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;

    public sealed class WGPMExport : IWGPMExport
    {
        public WGPMExport()
        {
        }

        // Non-iterated local searches
        public Task<IWGPMOutputContext> Solve(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            ILocalSearchAbstractFactory localSearchAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISolutionsAbstractFactory solutionsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext,
            Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration solverConfiguration)
        {
            return solutionsAbstractFactory.CreateWGPMSolutionFactory().Create().Solve(
                constraintsAbstractFactory,
                constructionHeuristicAbstractFactory,
                contextsAbstractFactory,
                dependenciesAbstractFactory,
                localSearchAbstractFactory,
                modelsAbstractFactory,
                neighbourhoodStructuresAbstractFactory,
                objectiveFunctionsAbstractFactory,
                parameterElementsAbstractFactory,
                resultsAbstractFactory,
                variablesAbstractFactory,
                WGPMInputContext,
                solverConfiguration);
        }

        // ILS
        public Task<IWGPMOutputContext> Solve(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            IConstructionHeuristicAbstractFactory constructionHeuristicAbstractFactory,
            IContextsAbstractFactory contextsAbstractFactory,
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IILSAbstractFactory ILSAbstractFactory,
            ILocalSearchAbstractFactory localSearchAbstractFactory,
            IModelsAbstractFactory modelsAbstractFactory,
            INeighbourhoodStructuresAbstractFactory neighbourhoodStructuresAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            ISolutionsAbstractFactory solutionsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext,
            Britt2022.A.A.ILS.Interfaces.ISolverConfiguration ILSSolverConfiguration,
            Britt2022.A.A.SolverConfigurations.Interfaces.ISolverConfiguration localSearchSolverConfiguration)
        {
            return solutionsAbstractFactory.CreateWGPMSolutionFactory().Create().Solve(
                constraintsAbstractFactory,
                constructionHeuristicAbstractFactory,
                contextsAbstractFactory,
                dependenciesAbstractFactory,
                ILSAbstractFactory,
                localSearchAbstractFactory,
                modelsAbstractFactory,
                neighbourhoodStructuresAbstractFactory,
                objectiveFunctionsAbstractFactory,
                parameterElementsAbstractFactory,
                resultsAbstractFactory,
                variablesAbstractFactory,
                WGPMInputContext,
                ILSSolverConfiguration,
                localSearchSolverConfiguration);
        }
    }
}