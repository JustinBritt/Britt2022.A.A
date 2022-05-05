namespace Britt2022.A.A.LAHC.Factories
{
    using Britt2022.A.A.LAHC.Classes;
    using Britt2022.A.A.LAHC.Interfaces;
    using Britt2022.A.A.LAHC.InterfacesFactories;

    internal sealed class LateAcceptanceHillClimbingFactory : ILateAcceptanceHillClimbingFactory
    {
        public LateAcceptanceHillClimbingFactory()
        {
        }

        public ILateAcceptanceHillClimbing Create()
        {
            ILateAcceptanceHillClimbing lateAcceptanceHillClimbing = null;

            try
            {
                lateAcceptanceHillClimbing = new LateAcceptanceHillClimbing();
            }
            finally
            {
            }

            return lateAcceptanceHillClimbing;
        }
    }
}