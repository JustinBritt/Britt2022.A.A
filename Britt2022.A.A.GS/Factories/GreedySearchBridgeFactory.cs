namespace Britt2022.A.A.GS.Factories
{
    using Britt2022.A.A.GS.Classes;
    using Britt2022.A.A.GS.Interfaces;
    using Britt2022.A.A.GS.InterfacesFactories;

    internal sealed class GreedySearchBridgeFactory : IGreedySearchBridgeFactory
    {
        public GreedySearchBridgeFactory()
        {
        }

        public IGreedySearchBridge Create()
        {
            IGreedySearchBridge greedySearchBridge = null;

            try
            {
                greedySearchBridge = new GreedySearchBridge();
            }
            finally
            {
            }

            return greedySearchBridge;
        }
    }
}