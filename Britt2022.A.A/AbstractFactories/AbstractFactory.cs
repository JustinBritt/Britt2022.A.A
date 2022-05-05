namespace Britt2022.A.A.AbstractFactories
{
    using Britt2022.A.A.Constraints.AbstractFactories;
    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.AbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.AbstractFactories;
    using Britt2022.A.A.Contexts.InterfacesAbstractFactories;
    using Britt2022.A.A.CrossJoinElements.AbstractFactories;
    using Britt2022.A.A.CrossJoinElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.AbstractFactories;
    using Britt2022.A.A.Dependencies.Hl7.Fhir.R4.Model.InterfacesAbstractFactories;
    using Britt2022.A.A.Exports.AbstractFactories;
    using Britt2022.A.A.Exports.InterfacesAbstractFactories;
    using Britt2022.A.A.GS.AbstractFactories;
    using Britt2022.A.A.GS.InterfacesAbstractFactories;
    using Britt2022.A.A.ILS.AbstractFactories;
    using Britt2022.A.A.ILS.InterfacesAbstractFactories;
    using Britt2022.A.A.IndexElements.AbstractFactories;
    using Britt2022.A.A.IndexElements.InterfacesAbstractFactories;
    using Britt2022.A.A.LAHC.AbstractFactories;
    using Britt2022.A.A.LAHC.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.AbstractFactories;
    using Britt2022.A.A.Models.InterfacesAbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.AbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.AbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.AbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.ResultElements.AbstractFactories;
    using Britt2022.A.A.ResultElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Results.AbstractFactories;
    using Britt2022.A.A.Results.InterfacesAbstractFactories;
    using Britt2022.A.A.SA.AbstractFactories;
    using Britt2022.A.A.SA.InterfacesAbstractFactories;
    using Britt2022.A.A.Solutions.AbstractFactories;
    using Britt2022.A.A.Solutions.InterfacesAbstractFactories;
    using Britt2022.A.A.VariableElements.AbstractFactories;
    using Britt2022.A.A.VariableElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Variables.AbstractFactories;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;

    public sealed class AbstractFactory : Britt2022.A.A.InterfacesAbstractFactories.IAbstractFactory
    {
        public AbstractFactory()
        {
        }

        public IConstraintsAbstractFactory CreateConstraintsAbstractFactory()
        {
            IConstraintsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ConstraintsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IConstructionHeuristicAbstractFactory CreateConstructionHeuristicAbstractFactory()
        {
            IConstructionHeuristicAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ConstructionHeuristicAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IContextsAbstractFactory CreateContextsAbstractFactory()
        {
            IContextsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ContextsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public ICrossJoinElementsAbstractFactory CreateCrossJoinElementsAbstractFactory()
        {
            ICrossJoinElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new CrossJoinElementsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IDependenciesAbstractFactory CreateDependenciesAbstractFactory()
        {
            IDependenciesAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new DependenciesAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IExportsAbstractFactory CreateExportsAbstractFactory()
        {
            IExportsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ExportsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IGSAbstractFactory CreateGSAbstractFactory()
        {
            IGSAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new GSAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IILSAbstractFactory CreateILSAbstractFactory()
        {
            IILSAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ILSAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IIndexElementsAbstractFactory CreateIndexElementsAbstractFactory()
        {
            IIndexElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new IndexElementsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public ILAHCAbstractFactory CreateLAHCAbstractFactory()
        {
            ILAHCAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new LAHCAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IModelsAbstractFactory CreateModelsAbstractFactory()
        {
            IModelsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ModelsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public INeighbourhoodStructuresAbstractFactory CreateNeighbourhoodStructuresAbstractFactory()
        {
            INeighbourhoodStructuresAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new NeighbourhoodStructuresAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IObjectiveFunctionsAbstractFactory CreateObjectiveFunctionsAbstractFactory()
        {
            IObjectiveFunctionsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ObjectiveFunctionsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IParameterElementsAbstractFactory CreateParameterElementsAbstractFactory()
        {
            IParameterElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ParameterElementsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IResultElementsAbstractFactory CreateResultElementsAbstractFactory()
        {
            IResultElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ResultElementsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IResultsAbstractFactory CreateResultsAbstractFactory()
        {
            IResultsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new ResultsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public ISAAbstractFactory CreateSAAbstractFactory()
        {
            ISAAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new SAAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public ISolutionsAbstractFactory CreateSolutionsAbstractFactory()
        {
            ISolutionsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new SolutionsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IVariableElementsAbstractFactory CreateVariableElementsAbstractFactory()
        {
            IVariableElementsAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new VariableElementsAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }

        public IVariablesAbstractFactory CreateVariablesAbstractFactory()
        {
            IVariablesAbstractFactory abstractFactory = null;

            try
            {
                abstractFactory = new VariablesAbstractFactory();
            }
            finally
            {
            }

            return abstractFactory;
        }
    }
}