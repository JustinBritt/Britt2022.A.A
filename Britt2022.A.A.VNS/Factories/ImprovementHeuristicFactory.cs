namespace Britt2022.A.A.VNS.Factories
{
    using Britt2022.A.A.VNS.Classes;
    using Britt2022.A.A.VNS.Interfaces;
    using Britt2022.A.A.VNS.InterfacesFactories;

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