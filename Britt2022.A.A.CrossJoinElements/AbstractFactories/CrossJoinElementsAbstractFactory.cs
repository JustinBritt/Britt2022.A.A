namespace Britt2022.A.A.CrossJoinElements.AbstractFactories
{
    using Britt2022.A.A.CrossJoinElements.Factories;
    using Britt2022.A.A.CrossJoinElements.InterfacesAbstractFactories;
    using Britt2022.A.A.CrossJoinElements.InterfacesFactories;

    public sealed class CrossJoinElementsAbstractFactory : ICrossJoinElementsAbstractFactory
    {
        public CrossJoinElementsAbstractFactory()
        {
        }

        public IijCrossJoinElementFactory CreateijCrossJoinElementFactory()
        {
            IijCrossJoinElementFactory factory = null;

            try
            {
                factory = new ijCrossJoinElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IijkCrossJoinElementFactory CreateijkCrossJoinElementFactory()
        {
            IijkCrossJoinElementFactory factory = null;

            try
            {
                factory = new ijkCrossJoinElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IijkωCrossJoinElementFactory CreateijkωCrossJoinElementFactory()
        {
            IijkωCrossJoinElementFactory factory = null;

            try
            {
                factory = new ijkωCrossJoinElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IikCrossJoinElementFactory CreateikCrossJoinElementFactory()
        {
            IikCrossJoinElementFactory factory = null;

            try
            {
                factory = new ikCrossJoinElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IilωCrossJoinElementFactory CreateilωCrossJoinElementFactory()
        {
            IilωCrossJoinElementFactory factory = null;

            try
            {
                factory = new ilωCrossJoinElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IiωCrossJoinElementFactory CreateiωCrossJoinElementFactory()
        {
            IiωCrossJoinElementFactory factory = null;

            try
            {
                factory = new iωCrossJoinElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IjkCrossJoinElementFactory CreatejkCrossJoinElementFactory()
        {
            IjkCrossJoinElementFactory factory = null;

            try
            {
                factory = new jkCrossJoinElementFactory();
            }
            finally
            {
            }

            return factory;
        }

        public IkωCrossJoinElementFactory CreatekωCrossJoinElementFactory()
        {
            IkωCrossJoinElementFactory factory = null;

            try
            {
                factory = new kωCrossJoinElementFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}