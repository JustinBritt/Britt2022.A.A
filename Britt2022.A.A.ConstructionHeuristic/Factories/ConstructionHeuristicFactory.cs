namespace Britt2022.A.A.ConstructionHeuristic.Factories
{
    using Britt2022.A.A.ConstructionHeuristic.Classes;
    using Britt2022.A.A.ConstructionHeuristic.Interfaces;
    using Britt2022.A.A.ConstructionHeuristic.InterfacesFactories;

    public sealed class ConstructionHeuristicFactory : IConstructionHeuristicFactory
    {
        public ConstructionHeuristicFactory()
        {
        }

        public IConstructionHeuristic Create()
        {
            IConstructionHeuristic constructionHeuristic = null;

            try
            {
                constructionHeuristic = new ConstructionHeuristic();
            }
            finally
            {
            }

            return constructionHeuristic;
        }
    }
}