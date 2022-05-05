namespace Britt2022.A.A.LAHC.Factories
{
    using Britt2022.A.A.LAHC.Classes;
    using Britt2022.A.A.LAHC.Interfaces;
    using Britt2022.A.A.LAHC.InterfacesFactories;

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