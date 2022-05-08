namespace Britt2022.A.A.InterfacesAbstractFactories
{
    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.CrossJoinElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.Exports.InterfacesAbstractFactories;
    using Britt2022.A.A.GS.InterfacesAbstractFactories;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.IndexElements.InterfacesAbstractFactories;
    using Britt2022.A.A.LAHC.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.InterfacesAbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.ResultElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;
    using Britt2022.A.A.SA.InterfacesAbstractFactories;
    using Britt2022.A.A.Solutions.InterfacesAbstractFactories;
    using Britt2022.A.A.VariableElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;
    using Britt2022.A.A.VNS.InterfacesAbstractFactories;

    public interface IAbstractFactory
    {
        IConstraintsAbstractFactory CreateConstraintsAbstractFactory();

        IConstructionHeuristicAbstractFactory CreateConstructionHeuristicAbstractFactory();

        IContextsAbstractFactory CreateContextsAbstractFactory();

        ICrossJoinElementsAbstractFactory CreateCrossJoinElementsAbstractFactory();

        IDependenciesAbstractFactory CreateDependenciesAbstractFactory();

        IExportsAbstractFactory CreateExportsAbstractFactory();

        IGSAbstractFactory CreateGSAbstractFactory();

        IILSAbstractFactory CreateILSAbstractFactory();

        IIndexElementsAbstractFactory CreateIndexElementsAbstractFactory();

        ILAHCAbstractFactory CreateLAHCAbstractFactory();

        IModelsAbstractFactory CreateModelsAbstractFactory();

        INeighbourhoodStructuresAbstractFactory CreateNeighbourhoodStructuresAbstractFactory();

        IObjectiveFunctionsAbstractFactory CreateObjectiveFunctionsAbstractFactory();

        IParameterElementsAbstractFactory CreateParameterElementsAbstractFactory();

        IResultElementsAbstractFactory CreateResultElementsAbstractFactory();

        IResultsAbstractFactory CreateResultsAbstractFactory();

        ISAAbstractFactory CreateSAAbstractFactory();

        ISolutionsAbstractFactory CreateSolutionsAbstractFactory();

        IVariableElementsAbstractFactory CreateVariableElementsAbstractFactory();

        IVariablesAbstractFactory CreateVariablesAbstractFactory();

        IVNSAbstractFactory CreateVNSAbstractFactory();
    }
}