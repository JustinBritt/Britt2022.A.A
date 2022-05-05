namespace Britt2022.A.A.ILS.Factories
{
    using Britt2022.A.A.ILS.Classes;
    using Britt2022.A.A.ILS.Interfaces;
    using Britt2022.A.A.ILS.InterfacesFactories;

    internal sealed class IteratedLocalSearchBridgeFactory : IIteratedLocalSearchBridgeFactory
    {
        public IteratedLocalSearchBridgeFactory()
        {
        }

        public IIteratedLocalSearchBridge Create()
        {
            IIteratedLocalSearchBridge iteratedLocalSearchBridge = null;

            try
            {
                iteratedLocalSearchBridge = new IteratedLocalSearchBridge();
            }
            finally
            {
            }

            return iteratedLocalSearchBridge;
        }
    }
}