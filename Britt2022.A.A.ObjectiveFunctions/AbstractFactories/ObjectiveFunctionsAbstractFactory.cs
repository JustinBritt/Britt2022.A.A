namespace Britt2022.A.A.ObjectiveFunctions.AbstractFactories
{
    using Britt2022.A.A.ObjectiveFunctions.Factories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesAbstractFactories;
    using Britt2022.A.A.ObjectiveFunctions.InterfacesFactories;

    public sealed class ObjectiveFunctionsAbstractFactory : IObjectiveFunctionsAbstractFactory
    {
        public ObjectiveFunctionsAbstractFactory()
        {
        }

        public IGoal1Factory CreateGoal1Factory()
        {
            IGoal1Factory factory = null;

            try
            {
                factory = new Goal1Factory();
            }
            finally
            {
            }

            return factory;
        }

        public IGoal2Factory CreateGoal2Factory()
        {
            IGoal2Factory factory = null;

            try
            {
                factory = new Goal2Factory();
            }
            finally
            {
            }

            return factory;
        }

        public IGoal3Factory CreateGoal3Factory()
        {
            IGoal3Factory factory = null;

            try
            {
                factory = new Goal3Factory();
            }
            finally
            {
            }

            return factory;
        }

        public IGoal4Factory CreateGoal4Factory()
        {
            IGoal4Factory factory = null;

            try
            {
                factory = new Goal4Factory();
            }
            finally
            {
            }

            return factory;
        }

        public IObjectiveFunctionFactory CreateObjectiveFunctionFactory()
        {
            IObjectiveFunctionFactory factory = null;

            try
            {
                factory = new ObjectiveFunctionFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}