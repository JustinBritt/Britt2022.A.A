namespace Britt2022.A.A.ObjectiveFunctions.Factories
{
    using Britt2022.A.A.ObjectiveFunctions.Classes;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesFactories;

    internal sealed class Goal3Factory : IGoal3Factory
    {
        public Goal3Factory()
        {
        }

        public IGoal3 Create()
        {
            IGoal3 objectiveFunction = null;

            try
            {
                objectiveFunction = new Goal3();
            }
            finally
            {
            }

            return objectiveFunction;
        }
    }
}