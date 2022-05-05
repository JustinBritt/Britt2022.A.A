namespace Britt2022.A.A.ILS.Factories
{
    using Britt2022.A.A.ILS.Classes;
    using Britt2022.A.A.ILS.Interfaces;
    using Britt2022.A.A.ILS.InterfacesFactories;

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