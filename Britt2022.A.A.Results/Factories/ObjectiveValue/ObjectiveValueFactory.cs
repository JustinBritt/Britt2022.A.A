namespace Britt2022.A.A.Results.Factories.ObjectiveValue
{
    using Britt2022.A.A.Results.Classes.ObjectiveValue;
    using Britt2022.A.A.Results.Interfaces.ObjectiveValue;
    using Britt2022.A.A.Results.InterfacesFactories.ObjectiveValue;

    internal sealed class ObjectiveValueFactory : IObjectiveValueFactory
    {
        public ObjectiveValueFactory()
        {
        }

        public IObjectiveValue Create(
            decimal value)
        {
            IObjectiveValue result = null;

            try
            {
                result = new ObjectiveValue(
                    value);
            }
            finally
            {
            }

            return result;
        }
    }
}