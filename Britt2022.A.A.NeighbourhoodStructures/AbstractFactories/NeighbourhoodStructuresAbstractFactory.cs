namespace Britt2022.A.A.NeighbourhoodStructures.AbstractFactories
{
    using Britt2022.A.A.NeighbourhoodStructures.Factories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesAbstractFactories;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;

    public sealed class NeighbourhoodStructuresAbstractFactory : INeighbourhoodStructuresAbstractFactory
    {
        public NeighbourhoodStructuresAbstractFactory()
        {
        }

        public IRandomPairwiseSwapFactory CreateRandomPairwiseSwapFactory()
        {
            IRandomPairwiseSwapFactory factory = null;

            try
            {
                factory = new RandomPairwiseSwapFactory();
            }
            finally
            {
            }

            return factory;
        }
    }
}