namespace Britt2022.A.A.Constraints.AbstractFactories
{
    using Britt2022.A.A.Constraints.Factories;
    using Britt2022.A.A.Constraints.InterfacesAbstractFactories;
    using Britt2022.A.A.Constraints.InterfacesFactories;

    public sealed class ConstraintsAbstractFactory : IConstraintsAbstractFactory
    {
        public ConstraintsAbstractFactory()
        {
        }

        public IConstraintsFactory CreateConstraintsFactory()
        {
            IConstraintsFactory factory = null;

            try
            {
                factory = new ConstraintsFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IConstraints1Factory CreateConstraints1Factory()
        {
            IConstraints1Factory factory = null;

            try
            {
                factory = new Constraints1Factory();
            }
            finally
            {
            }

            return factory;
        }

        public IConstraints2Factory CreateConstraints2Factory()
        {
            IConstraints2Factory factory = null;

            try
            {
                factory = new Constraints2Factory();
            }
            finally
            {
            }

            return factory;
        }

        public IConstraints3Factory CreateConstraints3Factory()
        {
            IConstraints3Factory factory = null;

            try
            {
                factory = new Constraints3Factory();
            }
            finally
            {
            }

            return factory;
        }

        public IConstraints4Factory CreateConstraints4Factory()
        {
            IConstraints4Factory factory = null;

            try
            {
                factory = new Constraints4Factory();
            }
            finally
            {
            }

            return factory;
        }

        public IConstraints5LFactory CreateConstraints5LFactory()
        {
            IConstraints5LFactory factory = null;

            try
            {
                factory = new Constraints5LFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IConstraints5UFactory CreateConstraints5UFactory()
        {
            IConstraints5UFactory factory = null;

            try
            {
                factory = new Constraints5UFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IConstraints9Factory CreateConstraints9Factory()
        {
            IConstraints9Factory factory = null;

            try
            {
                factory = new Constraints9Factory();
            }
            finally
            {
            }

            return factory;
        }
    }
}