namespace Britt2022.A.A.Models.Factories
{
    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.Contexts.Interfaces;
    using Britt2022.A.A.CrossJoinElements.InterfacesAbstractFactories;
    using Britt2022.A.A.IndexElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Models.Classes;
    using Britt2022.A.A.Models.Interfaces;
    using Britt2022.A.A.Models.InterfacesFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ParameterElements.InterfacesAbstractFactories;
    using Britt2022.A.A.Variables.InterfacesAbstractFactories;

    internal sealed class WGPMModelFactory : IWGPMModelFactory
    {
        public WGPMModelFactory()
        {
        }

        public IWGPMModel Create(
            IConstraintsAbstractFactory constraintsAbstractFactory,
            ICrossJoinElementsAbstractFactory crossJoinElementsAbstractFactory,
            IIndexElementsAbstractFactory indexElementsAbstractFactory,
            IObjectiveFunctionsAbstractFactory objectiveFunctionsAbstractFactory,
            IParameterElementsAbstractFactory parameterElementsAbstractFactory,
            IVariablesAbstractFactory variablesAbstractFactory,
            IWGPMInputContext WGPMInputContext)
        {
            IWGPMModel model = null;

            try
            {
                model = new WGPMModel(
                    constraintsAbstractFactory,
                    crossJoinElementsAbstractFactory,
                    indexElementsAbstractFactory,
                    objectiveFunctionsAbstractFactory,
                    parameterElementsAbstractFactory,
                    variablesAbstractFactory,
                    WGPMInputContext);
            }
            finally
            {
            }

            return model;
        }
    }
}