namespace Britt2022.A.A.ObjectiveFunctions.Factories
{
    using Britt2022.A.A.ObjectiveFunctions.Classes;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesFactories;

    internal sealed class ObjectiveFunctionFactory : IObjectiveFunctionFactory
    {
        public ObjectiveFunctionFactory()
        {
        }

        public IObjectiveFunction Create()
        {
            IObjectiveFunction objectiveFunction = null;

            try
            {
                objectiveFunction = new ObjectiveFunction();
            }
            finally
            {
            }

            return objectiveFunction;
        }
    }
}