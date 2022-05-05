namespace Britt2022.A.A.ObjectiveFunctions.Factories
{
    using Britt2022.A.A.ObjectiveFunctions.Classes;
    using Britt2022.A.A.ObjectiveFunctions.Interfaces;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesFactories;

    internal sealed class Goal1Factory : IGoal1Factory
    {
        public Goal1Factory()
        {
        }

        public IGoal1 Create()
        {
            IGoal1 objectiveFunction = null;

            try
            {
                objectiveFunction = new Goal1();
            }
            finally
            {
            }

            return objectiveFunction;
        }
    }
}