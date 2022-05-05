namespace Britt2022.A.A.IndexElements.AbstractFactories
{
    using Britt2022.A.A.IndexElements.Factories;
    using Britt2022.A.A.IndexElements.InterfacesAbstractFactories;
    using Britt2022.A.A.IndexElements.InterfacesFactories;

    public sealed class IndexElementsAbstractFactory : IIndexElementsAbstractFactory
    {
        public IndexElementsAbstractFactory()
        {
        }

        public IeIndexElementFactory CreateeIndexElementFactory()
        {
            IeIndexElementFactory factory = null;

            try
            {
                factory = new eIndexElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IiIndexElementFactory CreateiIndexElementFactory()
        {
            IiIndexElementFactory factory = null;

            try
            {
                factory = new iIndexElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IjIndexElementFactory CreatejIndexElementFactory()
        {
            IjIndexElementFactory factory = null;

            try
            {
                factory = new jIndexElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IkIndexElementFactory CreatekIndexElementFactory()
        {
            IkIndexElementFactory factory = null;

            try
            {
                factory = new kIndexElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IlIndexElementFactory CreatelIndexElementFactory()
        {
            IlIndexElementFactory factory = null;

            try
            {
                factory = new lIndexElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IrIndexElementFactory CreaterIndexElementFactory()
        {
            IrIndexElementFactory factory = null;

            try
            {
                factory = new rIndexElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IωIndexElementFactory CreateωIndexElementFactory()
        {
            IωIndexElementFactory factory = null;

            try
            {
                factory = new ωIndexElementFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}