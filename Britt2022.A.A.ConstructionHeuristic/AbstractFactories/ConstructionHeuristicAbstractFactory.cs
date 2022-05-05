namespace Britt2022.A.A.ConstructionHeuristic.AbstractFactories
{
    using Britt2022.A.A.ConstructionHeuristic.Factories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesFactories;

    public sealed class ConstructionHeuristicAbstractFactory : IConstructionHeuristicAbstractFactory
    {
        public ConstructionHeuristicAbstractFactory()
        {
        }

        public IConstructionHeuristicFactory CreateConstructionHeuristicFactory()
        {
            IConstructionHeuristicFactory factory = null;

            try
            {
                factory = new ConstructionHeuristicFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}