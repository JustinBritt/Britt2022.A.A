namespace Britt2022.A.A.ConstructionHeuristic.InterfacesAbstractFactories
{
    using Britt2022.A.A.ConstructionHeuristic.InterfacesFactories;

    public interface IConstructionHeuristicAbstractFactory
    {
        IConstructionHeuristicFactory CreateConstructionHeuristicFactory();
    }
}
