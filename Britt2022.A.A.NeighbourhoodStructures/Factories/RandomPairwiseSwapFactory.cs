namespace Britt2022.A.A.NeighbourhoodStructures.Factories
{
    using Britt2022.A.A.NeighbourhoodStructures.Classes;
    using Britt2022.A.A.NeighbourhoodStructures.Interfaces;
    using Britt2022.A.A.NeighbourhoodStructures.InterfacesFactories;

    internal sealed class RandomPairwiseSwapFactory : IRandomPairwiseSwapFactory
    {
        public RandomPairwiseSwapFactory()
        {
        }

        public INeighbourhoodStructure Create()
        {
            IRandomPairwiseSwap randomPairwiseSwap = null;

            try
            {
                randomPairwiseSwap = new RandomPairwiseSwap();
            }
            finally
            {
            }

            return randomPairwiseSwap;
        }
    }
}