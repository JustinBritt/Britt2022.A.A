namespace Britt2022.A.A.LAHC.Factories
{
    using Britt2022.A.A.LAHC.Classes;
    using Britt2022.A.A.LAHC.Interfaces;
    using Britt2022.A.A.LAHC.InterfacesFactories;

    internal sealed class LateAcceptanceHillClimbingBridgeFactory : ILateAcceptanceHillClimbingBridgeFactory
    {
        public LateAcceptanceHillClimbingBridgeFactory()
        {
        }

        public ILateAcceptanceHillClimbingBridge Create()
        {
            ILateAcceptanceHillClimbingBridge lateAcceptanceHillClimbingBridge = null;

            try
            {
                lateAcceptanceHillClimbingBridge = new LateAcceptanceHillClimbingBridge();
            }
            finally
            {
            }

            return lateAcceptanceHillClimbingBridge;
        }
    }
}