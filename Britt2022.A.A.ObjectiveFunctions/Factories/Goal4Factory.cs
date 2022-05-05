namespace Britt2022.A.A.ObjectiveFunctions.Factories
{
    using Britt2022.A.A.ObjectiveFunctions.Classes;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesFactories;

    internal sealed class Goal4Factory : IGoal4Factory
    {
        public Goal4Factory()
        {
        }

        public IGoal4 Create()
        {
            IGoal4 objectiveFunction = null;

            try
            {
                objectiveFunction = new Goal4();
            }
            finally
            {
            }

            return objectiveFunction;
        }
    }
}