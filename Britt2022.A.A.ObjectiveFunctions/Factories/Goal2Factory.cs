namespace Britt2022.A.A.ObjectiveFunctions.Factories
{
    using Britt2022.A.A.ObjectiveFunctions.Classes;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesFactories;

    internal sealed class Goal2Factory : IGoal2Factory
    {
        public Goal2Factory()
        {
        }

        public IGoal2 Create()
        {
            IGoal2 objectiveFunction = null;

            try
            {
                objectiveFunction = new Goal2();
            }
            finally
            {
            }

            return objectiveFunction;
        }
    }
}