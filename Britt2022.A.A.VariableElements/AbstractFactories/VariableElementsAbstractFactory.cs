namespace Britt2022.A.A.VariableElements.AbstractFactories
{
    using Britt2022.A.A.VariableElements.Factories;
    using Britt2022.A.A.VariableElements.InterfacesAbstractFactories;
    using Britt2022.A.A.VariableElements.InterfacesFactories;

    public sealed class VariableElementsAbstractFactory : IVariableElementsAbstractFactory
    {
        public VariableElementsAbstractFactory()
        {
        }

        public Id1MinusVariableElementFactory Created1MinusVariableElementFactory()
        {
            Id1MinusVariableElementFactory factory = null;

            try
            {
                factory = new d1MinusVariableElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public Id1PlusVariableElementFactory Created1PlusVariableElementFactory()
        {
            Id1PlusVariableElementFactory factory = null;

            try
            {
                factory = new d1PlusVariableElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public Id2MinusVariableElementFactory Created2MinusVariableElementFactory()
        {
            Id2MinusVariableElementFactory factory = null;

            try
            {
                factory = new d2MinusVariableElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIMaxVariableElementFactory CreateIMaxVariableElementFactory()
        {
            IIMaxVariableElementFactory factory = null;

            try
            {
                factory = new IMaxVariableElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIMinVariableElementFactory CreateIMinVariableElementFactory()
        {
            IIMinVariableElementFactory factory = null;

            try
            {
                factory = new IMinVariableElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IIVariableElementFactory CreateIVariableElementFactory()
        {
            IIVariableElementFactory factory = null;

            try
            {
                factory = new IVariableElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IxVariableElementFactory CreatexVariableElementFactory()
        {
            IxVariableElementFactory factory = null;

            try
            {
                factory = new xVariableElementFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}