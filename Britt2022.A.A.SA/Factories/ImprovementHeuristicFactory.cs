namespace Britt2022.A.A.SA.Factories
{
    using Britt2022.A.A.SA.Classes;
    using Britt2022.A.A.SA.Interfaces;
    using Britt2022.A.A.SA.InterfacesFactories;

    internal sealed class ImprovementHeuristicFactory : IImprovementHeuristicFactory
    {
        public ImprovementHeuristicFactory()
        {
        }

        public IImprovementHeuristic Create()
        {
            IImprovementHeuristic improvementHeuristic = null;

            try
            {
                improvementHeuristic = new ImprovementHeuristic();
            }
            finally
            {
            }

            return improvementHeuristic;
        }
    }
}