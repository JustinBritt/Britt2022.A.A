namespace Britt2022.A.A.SA.Factories
{
    using Britt2022.A.A.SA.Classes;
    using Britt2022.A.A.SA.Interfaces;
    using Britt2022.A.A.SA.InterfacesFactories;

    internal sealed class SimulatedAnnealingBridgeFactory : ISimulatedAnnealingBridgeFactory
    {
        public SimulatedAnnealingBridgeFactory()
        {
        }

        public ISimulatedAnnealingBridge Create()
        {
            ISimulatedAnnealingBridge simulatedAnnealingBridge = null;

            try
            {
                simulatedAnnealingBridge = new SimulatedAnnealingBridge();
            }
            finally
            {
            }

            return simulatedAnnealingBridge;
        }
    }
}