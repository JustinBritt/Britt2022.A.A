namespace Britt2022.A.A.GS.Factories
{
    using Britt2022.A.A.GS.Classes;
    using Britt2022.A.A.GS.Interfaces;
    using Britt2022.A.A.GS.InterfacesFactories;

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